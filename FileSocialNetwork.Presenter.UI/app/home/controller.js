(function () {

	'use strict';

	angular
		.module('home')
		.controller('homeController', homeController);

	homeController.$inject = ['$scope', 'homeApiService'];

	function homeController($scope, homeApiService) {

		$scope.faculties = [];

		homeApiService.getTotalRating().success(function (response) {
			$scope.totalRating = response;
		});
	}

})();