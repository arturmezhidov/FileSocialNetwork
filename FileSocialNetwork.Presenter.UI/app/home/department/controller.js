(function () {

	'use strict';

	angular
		.module('department')
		.controller('departmentController', facultyController);

	facultyController.$inject = ['$scope', 'facultyFactory'];

	function facultyController($scope, facultyFactory) {

		$scope.faculties = facultyFactory.get();
		$scope.selectFacultyInfo = facultyFactory.selectInfo;

	}
})();