(function () {

	'use strict';

	angular
		.module('account')
		.controller('loginController', loginController);

	loginController.$inject = ['$scope', 'accountService'];

	function loginController($scope, accountService) {
		$scope.login = function () {
			accountService.login($scope.username, $scope.password, function() {
			    $scope.error = false;
			    accountService.redirect();
				
			}, function (err) {
				$scope.error = true;
				$scope.errorMessage = err;
			});
		}
	}

})();