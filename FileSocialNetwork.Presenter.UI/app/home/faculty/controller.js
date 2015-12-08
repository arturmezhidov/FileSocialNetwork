(function () {

	'use strict';

	angular
		.module('faculty')
		.controller('facultyController', facultyController);

	facultyController.$inject = ['$scope', 'dataContext'];

	function facultyController($scope, dataContext) {

		dataContext.getFaculties(function (faculties) {
			$scope.faculties = faculties.items;
		});

		$scope.select = function (faculty) {
			dataContext.setSelectFaculty(faculty.Id);
		}
	}
})();