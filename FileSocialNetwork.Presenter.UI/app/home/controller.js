(function () {

	'use strict';

	angular
		.module('home')
		.controller('homeController', homeController);

	homeController.$inject = ['$scope', 'dataContext', 'accountService'];

	function homeController($scope, dataContext, accountService) {

	    $scope.accountState = accountService.getStatus();

		dataContext.getRating(function(rating) {
			$scope.totalRating = rating;
		});
	}

})();