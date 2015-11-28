(function () {

    'use strict';

    angular.module('app')
        .config(['$routeProvider', function ($routeProvider) {
            $routeProvider
                            .when('/', {
                                templateUrl: '/app/home/view.html',
                                controller: 'homeController',
                                controllerAs: 'ctrl'
                            })
                            .otherwise({
                                redirectTo: '/'
                            });
        }]);

})();