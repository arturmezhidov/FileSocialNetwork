(function () {

	'use strict';

	angular
		.module('subject')
		.controller('subjectController', subjectController);

	subjectController.$inject = ['$scope', 'dataContext'];

	function subjectController($scope, dataContext) {

		dataContext.getFaculties(function (faculties) {
			$scope.faculties = faculties;
		});

		$scope.departments = dataContext.getDepartments();

		$scope.$watch('departments.select', function (newValue) {
			if (newValue) {
				dataContext.getByDepartmentId(newValue.Id).success(function (data) {
					$scope.subjects = data;
				});
			}
		});
	}
})();