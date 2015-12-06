(function () {

	'use strict';

	angular
		.module('department')
		.service('departmentApiService', departmentApiService);

	departmentApiService.$inject = ['$http'];

	function departmentApiService($http) {

		this.getAll = getAll;
		this.getByFacultyId = getByFacultyId;

		function getAll() {
			return $http.get('http://localhost:21598/api/Department');
		}
		function getByFacultyId() {
			return $http.get('http://localhost:21598/api/Department/7');
		}
	}
})();