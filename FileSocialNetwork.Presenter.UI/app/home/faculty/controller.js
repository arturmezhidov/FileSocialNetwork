(function () {

	'use strict';

	angular
		.module('faculty')
		.controller('facultyController', facultyController);

	facultyController.$inject = ['$scope', 'facultyApiService', 'facultyFactory'];

	function facultyController($scope, facultyApiService, facultyFactory) {

		facultyApiService.getAll().success(function (response) {
			facultyFactory.update(response);
			$scope.faculties = facultyFactory.get();
		});

		$scope.select = function (faculty) {
			facultyFactory.selectInfo.faculty = faculty;
		}
	}
})();