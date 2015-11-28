(function () {

    'use strict';

    angular.module('home', []);
    angular.module('faculty', []);

    angular.module('app',
    [
        'ngRoute',
        'home',
		'faculty'
    ]);

})();