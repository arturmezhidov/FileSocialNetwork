(function () {

	'use strict';

	angular
		.module('subject')
		.controller('subjectController', subjectController);

	subjectController.$inject = ['$scope', 'facultyFactory', 'departmentFactory'];

	function subjectController($scope, facultyFactory, departmentFactory) {

		$scope.departments = departmentFactory.get();
		$scope.selectDepartmentInfo = departmentFactory.selectInfo;
		$scope.selectFacultyInfo = facultyFactory.selectInfo;

		$scope.$watch('selectDepartmentInfo.department', function (newValue, oldValue) {
			alert('newValue:  ' + newValue.Title + '\noldValue:  ' + oldValue.Title);
		});

		//departmentApiService.getAll().success(function (response) {
		//	departmentFactory.update(response);
		//	$scope.departments = departmentFactory.get();
		//});

		//$scope.select = function (department) {
		//	departmentFactory.selectInfo.department = department;
		//}
	}
})();