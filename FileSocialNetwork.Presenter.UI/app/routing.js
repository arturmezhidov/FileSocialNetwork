(function () {

	'use strict';

	angular.module('app')
        .config(['$routeProvider', function ($routeProvider) {
        	$routeProvider
                            .when('/', {
                            	templateUrl: 'app/home/view.html',
                            	controller: 'homeController',
                            	controllerAs: 'ctrl'
                            })
                            .when('/register', {
                            	templateUrl: '/app/account/register/view.html',
                            	controller: 'registerController',
                            	controllerAs: 'ctrl'
                            })
                            .when('/login', {
                            	templateUrl: '/app/account/login/view.html',
                            	controller: 'loginController',
                            	controllerAs: 'ctrl'
                            })
                            .otherwise({
                            	redirectTo: '/'
                            });
        }]);

})();