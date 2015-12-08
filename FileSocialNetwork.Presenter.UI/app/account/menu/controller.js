(function () {

	'use strict';

	angular
		.module('account')
		.controller('menuController', menuController);

	menuController.$inject = ['$scope', '$location', 'accountService'];

	function menuController($scope, $location, accountService) {
		$scope.status = accountService.getStatus();
		$scope.logout = function() {
			accountService.logout();
			$location.path('/');
		}
	}

})();