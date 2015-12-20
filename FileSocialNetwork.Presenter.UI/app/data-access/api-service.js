(function () {

    'use strict';

    angular
		.module('dataAccess')
		.service('apiService', apiService);

    apiService.$inject = ['$http', 'config', 'Upload'];

    function apiService($http, config, Upload) {

        $http.defaults.cache = false;

        this.getTotalRating = getTotalRating;
        this.getFaculties = getFaculties;
        this.getDepartments = getDepartments;
        this.getGroupsBySpecialityId = getGroupsBySpecialityId;
        this.getByDepartmentId = getByDepartmentId;
        this.getAllFileCategoryes = getAllFileCategoryes;
        this.register = register;
        this.login = login;
        this.confirm = confirm;
        this.logout = logout;
        this.upload = upload;
        this.like = like;
        this.token = token;

        function getTotalRating() {
            //return $http.get(config.BASE_URL + config.CTRL_RATING);
            return $http({
                method: 'GET',
                url: config.BASE_URL + config.CTRL_RATING,
                xsrfHeaderName: 'Authorization',
                headers: {
                    'Authorization': "Bearer " + token()
                }
            });
        }
        function getFaculties() {
            return $http.get(config.BASE_URL + config.CTRL_FACULTY);
        }
        function getDepartments() {
            return $http.get(config.BASE_URL + config.CTRL_DEPARTMENT);
        }
        function getGroupsBySpecialityId(specialityId) {
            return $http.get(config.BASE_URL + config.CTRL_GROUP + specialityId);
        }
        function getByDepartmentId(departmentId) {
         //   return $http.get(config.BASE_URL + config.CTRL_SUBJECT + departmentId);
            return $http({
                method: 'GET',
                url: config.BASE_URL + config.CTRL_SUBJECT + departmentId,
                xsrfHeaderName: 'Authorization',
                headers: {
                    'Authorization': "Bearer " + token()
                }
            });
        }
        function getAllFileCategoryes() {
            return $http.get(config.BASE_URL + config.CTRL_FILE_CATEGORY);
        }
        function register(data) {
            return $http({
                method: 'POST',
                url: config.BASE_URL + config.CTRL_ACCOUNT_REGISTER,
                data: $.param(data),
                headers: {
                    'Content-Type': 'application/x-www-form-urlencoded; charset=UTF-8'
                }
            });
        }
        function login(data) {
            return $http({
                method: 'POST', url: config.DOMEN + config.CTRL_ACCOUNT_LOGIN, data: $.param(data), headers: {
                    'Content-Type': 'application/x-www-form-urlencoded; charset=UTF-8'
                }
            });
        }
        function confirm(token) {
            return $http({
                method: 'GET',
                url: config.BASE_URL + config.CTRL_CONFIRM,
                xsrfHeaderName: 'Authorization',
                headers: {
                    'Authorization': "Bearer " + token
                }
            });
        }
        function logout() {
            return $http.post(config.BASE_URL + config.CTRL_ACCOUNT_LOGOUT);
        }
        function upload(files, data, success, progress, error) {
            if (files && files.length) {
                for (var i = 0; i < files.length; i++) {
                    var file = files[i];
                    if (!file.$error) {
                        Upload.upload({
                            url: config.BASE_URL + config.CTRL_UPLOAD,
                            data: data,
                            file: file,
                            xsrfHeaderName: 'Authorization',
                            headers: {
                                'Authorization': "Bearer " + token()
                            }
                        })
                            .progress(progress)
                            .success(success)
                            .error(error);
                    }
                }
            }
        }
        function like(data) {
            return $http({
                method: 'POST',
                url: config.BASE_URL + config.CTRL_LIKE,
                data: $.param(data),
                xsrfHeaderName: 'Authorization',
                headers: {
                    'Authorization': "Bearer " + token(),
                    'Content-Type': 'application/x-www-form-urlencoded; charset=UTF-8'
                }
            });
        }
        function token(value) {
            if (arguments.length) {
                localStorage.setItem(config.AUTH_TOKEN, value);
            }
            return localStorage.getItem(config.AUTH_TOKEN);
        }
    }
})();