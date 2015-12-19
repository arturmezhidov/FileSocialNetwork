(function () {

	'use strict';

	angular
		.module('account')
		.service('accountService', accountService);

	accountService.$inject = ['$rootScope', 'accountApiService'];

	function accountService($rootScope, accountApiService) {

		var status = {
			data: {},
			isAuthorize: false,
			isAdmin: false
		};

		this.register = register;
		this.login = login;
		this.logout = logout;
		this.getStatus = getStatus;

		function register(data) {
			return accountApiService.register(data);
		}
		function login(username, password, success, error) {

			var loginData = {
				grant_type: 'password',
				username: username,
				password: password
			};

			return accountApiService.login(loginData).success(function (data) {
				status.data = data;
				status.isAuthorize = true;
				if (typeof (success) == 'function') {
					success(data);
				}
			}).error(function (err) {
				status.data = { };
				status.isAuthorize = false;
				status.isAdmin = false;
				if (typeof (error) == 'function') {
					error(err.error_description);
				}
			});
		}
		function logout() {
			status.data = {};
			status.isAuthorize = false;
			status.isAdmin = false;
			accountApiService.logout();
		}
		function getStatus() {
			return status;
		}
	}
})();