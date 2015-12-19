(function () {

	'use strict';

	angular.module('navigate', ['duScroll']);
	angular.module('dataAccess', ['ngFileUpload']);
	angular.module('home', []);
	angular.module('faculty', []);
	angular.module('department', []);
	angular.module('subject', []);
	angular.module('account', []);
	angular.module('file', []);
	

	angular.module('app',
    [
        'ngRoute',
        'ngAnimate',
		'navigate',
		'dataAccess',
        'home',
		'faculty',
		'department',
		'subject',
		'account',
		'file'
    ]);

})();