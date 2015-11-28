(function () {

	'use strict';

	angular
		.module('home')
		.service('homeApiService', homeApiService);

	homeApiService.$inject = ['$http'];

	function homeApiService($http) {

		this.getTotalRating = getTotalRating;

		function getTotalRating() {
			return $http.get('http://localhost:21598/api/Rating');
		}
	}
})();