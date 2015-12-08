(function () {

	'use strict';

	angular
		.module('dataAccess')
		.service('apiService', apiService);

	apiService.$inject = ['$http'];

	function apiService($http) {

		this.getTotalRating = getTotalRating;
		this.getFaculties = getFaculties;
		this.getDepartments = getDepartments;
		this.getGroupsBySpecialityId = getGroupsBySpecialityId;

		function getTotalRating() {
			return $http.get('http://localhost:21598/api/Rating');
		}
		function getFaculties() {
			return $http.get('http://localhost:21598/api/Faculty');
		}
		function getDepartments() {
			return $http.get('http://localhost:21598/api/Department');
		}
		function getGroupsBySpecialityId(specialityId) {
			return $http.get('http://localhost:21598/api/Group/' + specialityId);
		}
	}
})();