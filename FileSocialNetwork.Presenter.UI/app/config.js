(function () {

    'use strict';

    angular.module('app')
		.constant('config', {
		    DOMEN: 'http://localhost:21598/',
		    BASE_URL: 'http://localhost:21598/api/',
		    CTRL_RATING: 'Rating',
		    CTRL_FACULTY: 'Faculty/',
		    CTRL_DEPARTMENT: 'Department/',
		    CTRL_GROUP: 'Group/',
		    CTRL_SUBJECT: 'Subject/',
		    CTRL_FILE_CATEGORY: 'FileCategory/',
		    CTRL_ACCOUNT_REGISTER: 'Account/Register/',
		    CTRL_ACCOUNT_LOGIN: 'Token',
		    CTRL_CONFIRM: 'AccountState/ConfirmLogin',
		    CTRL_ACCOUNT_LOGOUT: 'Account/Logout',
		    CTRL_UPLOAD: 'File',
		    CTRL_LIKE: 'Like',
            AUTH_TOKEN: 'auth_token'
		});
})();
