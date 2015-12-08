(function () {

	'use strict';

	angular
		.module('account')
		.controller('loginController', loginController);

	loginController.$inject = ['$scope', '$location', 'accountService'];

	function loginController($scope, $location, accountService) {

		$scope.login = function () {
			accountService.login($scope.username, $scope.password, function() {
				$scope.error = false;
				$location.path('/');
			}, function (err) {
				$scope.error = true;
				$scope.errorMessage = err;
			});
		}
	}
})();