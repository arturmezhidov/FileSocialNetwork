(function () {

	'use strict';

	angular.module('home', []);
	angular.module('faculty', []);
	angular.module('department', []);
	angular.module('subject', []);

	angular.module('app',
    [
        'ngRoute',
        'home',
		'faculty',
		'department',
		'subject'
    ]);

})();