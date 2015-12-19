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
		this.getByDepartmentId = getByDepartmentId;
		this.getAllFileCategoryes = getAllFileCategoryes;
		this.upload = upload;

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
		function getByDepartmentId(departmentId) {
			return $http.get('http://localhost:21598/api/Subject/' + departmentId);
		}
		function getAllFileCategoryes() {
			return $http.get('http://localhost:21598/api/FileCategory');
		}
		function upload(data) {
			return $http({
				method: 'POST', url: 'http://localhost:21598/api/File', data: data, headers: {
					'Content-Type': 'multipart/form-data; boundary=----WebKitFormBoundary2e1CoqUGbBBBo2jM'
				}
			});
		}
	}
})();