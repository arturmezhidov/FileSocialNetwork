(function () {

	'use strict';

	angular
		.module('department')
		.controller('departmentController', departmentController);

	departmentController.$inject = ['$scope', 'departmentApiService', 'facultyFactory', 'departmentFactory'];

	function departmentController($scope, departmentApiService, facultyFactory, departmentFactory) {

		$scope.faculties = facultyFactory.get();
		$scope.selectFacultyInfo = facultyFactory.selectInfo;

		departmentApiService.getAll().success(function (response) {
			departmentFactory.update(response);
			$scope.departments = departmentFactory.get();
		});

		$scope.select = function (department) {
			departmentFactory.selectInfo.department = department;
		}
	}
})();