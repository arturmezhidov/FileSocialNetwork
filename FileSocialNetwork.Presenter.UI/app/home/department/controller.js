(function () {

	'use strict';

	angular
		.module('department')
		.controller('departmentController', departmentController);

	departmentController.$inject = ['$scope', '$rootScope', 'dataContext'];

	function departmentController($scope, $rootScope,dataContext) {

		dataContext.getFaculties(function (faculties) {
			$scope.faculties = faculties;
		});

		$scope.select = function(department) {
			dataContext.setSelectDepartment(department);
			$rootScope.toSubject();
		}
	}
})();