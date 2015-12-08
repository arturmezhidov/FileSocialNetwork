(function () {

	'use strict';

	angular.module('dataAccess', []);
	angular.module('home', []);
	angular.module('faculty', []);
	angular.module('department', []);
	angular.module('subject', []);
	angular.module('account', []);

	angular.module('app',
    [
        'ngRoute',
		'dataAccess',
        'home',
		'faculty',
		'department',
		'subject',
		'account'
    ]);

})();