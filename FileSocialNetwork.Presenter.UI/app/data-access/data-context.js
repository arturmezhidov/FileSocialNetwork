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
        var departments = {
            select: {}
        }
        var factory = {
            getRating: getRating,
            getFaculties: getFaculties,
            getDepartments: getDepartments,
            setSelectFaculty: setSelectFaculty,
            setSelectDepartment: setSelectDepartment,
            getGroupsBySpecialityId: getGroupsBySpecialityId,
            getByDepartmentId: getByDepartmentId,
            getAllFileCategoryes: getAllFileCategoryes,
            upload: upload,
            like: like,
            saveFaculty: saveFaculty
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
            else {
                apiService
                    .getFaculties()
                    .success(function (response) {
                        faculties.items = response;
                        faculties.updated = true;
                        success(faculties);
                    });
            }
        }
        function setSelectFaculty(facultyId) {
            for (var i = 0; i < faculties.items.length; i++) {
                if (faculties.items[i].Id === facultyId) {
                    faculties.select = faculties.items[i];
                }
            }
        }
        function getDepartments() {
            return departments;
        }
        function setSelectDepartment(dep) {
            departments.select = dep;
        }
        function getGroupsBySpecialityId(specialityId, success) {
            return apiService
					.getGroupsBySpecialityId(specialityId)
					.success(success);
        }
        function getByDepartmentId(id) {
            return apiService.getByDepartmentId(id);
        }
        function getAllFileCategoryes(success) {
            return apiService
				.getAllFileCategoryes()
				.success(success);
        }
        function upload(data) {
            return apiService.upload(data);
        }
        function like(fileId) {
            return apiService.like({ fileId: fileId });
        }
        function saveFaculty(faculties) {
            return apiService.saveFaculty(faculties);
        }

        return factory;
    }
})();