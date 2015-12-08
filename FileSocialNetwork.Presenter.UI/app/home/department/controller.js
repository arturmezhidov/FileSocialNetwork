(function () {

	'use strict';

	angular
		.module('department')
		.controller('departmentController', departmentController);

	departmentController.$inject = ['$scope', 'dataContext'];

	function departmentController($scope, dataContext) {

		dataContext.getFaculties(function (faculties) {
			$scope.faculties = faculties;
		});

		//$scope.$watch('faculties.select', function (newValue, oldValue) {
		//	$scope.selectFaculty = newValue;
		//});

		//$scope.select = function (faculty) {
		//	facultiesInfo.select = faculty;
		//}



		//$scope.faculties = facultyFactory.get();
		//$scope.selectFacultyInfo = facultyFactory.selectInfo;

		//departmentApiService.getAll().success(function (response) {
		//	departmentFactory.update(response);
		//	$scope.departments = departmentFactory.get();
		//});

		//$scope.select = function (department) {
		//	departmentFactory.selectInfo.department = department;
		//}
	}
})();