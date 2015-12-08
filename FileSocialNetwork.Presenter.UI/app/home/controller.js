(function () {

	'use strict';

	angular
		.module('home')
		.controller('homeController', homeController);

	homeController.$inject = ['$scope', 'dataContext'];

	function homeController($scope, dataContext) {

		dataContext.getRating(function(rating) {
			$scope.totalRating = rating;
		});
	}

})();