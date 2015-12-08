(function () {

	'use strict';

	angular
		.module('account')
		.service('accountApiService', accountApiService);

	accountApiService.$inject = ['$http'];

	function accountApiService($http) {

		$http.defaults.cache = false;

		this.register = register;
		this.login = login;
		this.logout = logout;
 
		function register(data) {
			return $http({
				method: 'POST', url: 'http://localhost:21598/api/Account/Register', data: $.param(data), headers: {
					'Content-Type': 'application/x-www-form-urlencoded; charset=UTF-8'
				}
			});
		}
		function login(data) {
			return $http({
				method: 'POST', url: 'http://localhost:21598/Token', data: $.param(data), headers: {
					'Content-Type': 'application/x-www-form-urlencoded; charset=UTF-8'
				}
			});
		}
		function logout() {
			return $http.post('http://localhost:21598/api/Account/Logout');
		}
	}
})();