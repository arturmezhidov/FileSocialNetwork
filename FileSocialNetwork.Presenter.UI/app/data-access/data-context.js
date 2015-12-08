(function () {

	'use strict';

	angular
		.module('dataAccess')
		.factory('dataContext', dataContext);

	dataContext.$inject = ['apiService'];

	function dataContext(apiService) {

		var rating = {
			subjectsCount: 0,
			filesCount: 0,
			usersCount: 0
		};
		var faculties = {
			items: [],
			select: {},
			updated: false
		};
		var factory = {
			getRating: getRating,
			getFaculties: getFaculties,
			setSelectFaculty: setSelectFaculty,
			getGroupsBySpecialityId: getGroupsBySpecialityId
		}

		function getRating(success) {
			apiService
				.getTotalRating()
				.success(function (response) {
					rating.subjectsCount = response.SubjectsCount;
					rating.filesCount = response.FilesCount;
					rating.usersCount = response.UsersCount;
					rating.updated = true;
					success(rating);
				});
		}
		function getFaculties(success) {
			if (faculties.updated) {
				success(faculties);
			}
			apiService
				.getFaculties()
				.success(function (response) {
					faculties.items = response;
					faculties.updated = true;
					success(faculties);
				});
		}
		function setSelectFaculty(facultyId) {
			for (var i = 0; i < faculties.items.length; i++) {
				if (faculties.items[i].Id === facultyId) {
					faculties.select = faculties.items[i];
				}
			}
		}
		function getGroupsBySpecialityId(specialityId, success) {
			return apiService
					.getGroupsBySpecialityId(specialityId)
					.success(success);
		}

		return factory;
	}
})();