(function () {

	'use strict';

	angular
		.module('faculty')
		.service('httpService', httpService);

	httpService.$inject = ['$http'];

	function httpService($http) {

		this.getAll = getAll;

		function getAll() {
			return $http.get('http://localhost:21598/api/Faculty');
		}
	}
})();