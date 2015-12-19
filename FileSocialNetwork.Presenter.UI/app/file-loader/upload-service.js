(function () {

    'use strict';

    angular
		.module('file')
		.service('fileLoadService', fileLoadService);

    fileLoadService.$inject = ['$http', 'apiService'];

    function fileLoadService($http, apiService) {

        this.uploadFiles = uploadFiles;
        this.uploadFile = uploadFile;

        function uploadFiles(files, data, success, progress, error) {
            apiService.upload(files, data, success, progress, error);
        }
        function uploadFile(file, data, success, progress, error) {
            uploadFiles([file], data, success, progress, error);
        }
    }
})();