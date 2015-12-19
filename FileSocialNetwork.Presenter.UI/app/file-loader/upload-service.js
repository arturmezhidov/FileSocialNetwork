(function () {

    'use strict';

    angular
		.module('file')
		.service('fileLoadService', fileLoadService);

    fileLoadService.$inject = ['$http', 'Upload'];

    function fileLoadService($http, Upload) {

        this.uploadFiles = uploadFiles;
        this.uploadFile = uploadFile;

        function uploadFiles(files, data, success, progress, error) {
            if (files && files.length) {
                for (var i = 0; i < files.length; i++) {
                    var file = files[i];
                    if (!file.$error) {
                        Upload.upload({
                            url: 'http://localhost:21598/api/File',
                            data: data,
                            file: file
                        })
                            .progress(progress)
                            .success(success)
                            .error(error);
                    }
                }
            }
        }
        function uploadFile(file, data, success, progress, error) {
            uploadFiles([file], data, success, progress, error);
        }
    }
})();