(function () {

	'use strict';

	angular
		.module('faculty')
		.service('facultyApiService', facultyApiService);

	facultyApiService.$inject = ['$http'];

	function facultyApiService($http) {

		this.getAll = getAll;

		function getAll() {
			return $http.get('http://localhost:21598/api/Faculty');
		}
	}
})();