(function () {

	'use strict';

	angular
		.module('account')
		.service('accountService', accountService);

	accountService.$inject = ['$location', 'apiService'];

	function accountService($location, apiService) {

	    var status = {
	        data: {},
	        isAuthorize: false,
	        isAdmin: false,
	        redirectUrl: ''
		};

		this.register = register;
		this.login = login;
		this.logout = logout;
		this.getStatus = getStatus;
		this.check = check;
		this.redirect = redirect;

		function register(data, success, error) {
		    return apiService.register(data).success(function () {
		        if (typeof (success) == 'function') {
		            success(data);
		        }
		    }).error(function (err) {
		        if (typeof (error) == 'function') {
		            error(err);
		        }
		    });
		}
		function login(username, password, success, error) {

			var loginData = {
				grant_type: 'password',
				username: username,
				password: password
			};

			return apiService.login(loginData).success(function (data) {
			    apiService.confirm(data.access_token).success(function (response) {
			        status.data = data;
				    status.isAuthorize = response.IsAuthorize;
				    status.isAdmin = response.IsAdmin;;
				    apiService.token(data.access_token);
				    if (typeof (success) == 'function') {
				        success(data);
				    }
			    });
			}).error(function (err) {
			    status.data = {};
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
			apiService.logout();
			apiService.token('');
		}
		function getStatus() {
			return status;
		}
		function check(redirectUrl) {
		    if (!status.isAuthorize) {
		        $location.path('/login');
		        status.redirectUrl = redirectUrl;
		    } else {
		        status.redirectUrl = '/';
		    }
		}
		function redirect() {
		    $location.path(status.redirectUrl);
		}
	}
})();