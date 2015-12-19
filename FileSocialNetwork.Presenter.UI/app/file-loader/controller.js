(function () {
    //inject angular file upload directives and services.
    //var app = angular.module('fileUpload', );

    angular
		.module('file')
		.controller('fileLoadController', fileLoadController);

    fileLoadController.$inject = ['$scope', 'dataContext', 'fileLoadService', '$timeout'];

    function fileLoadController($scope, dataContext, fileLoadService, $timeout) {

        $scope.file = null;
        $scope.isValid = false;
        $scope.progress = '0%';
        $scope.progressing = false;
        $scope.error = null;

        dataContext.getFaculties(function (faculties) {
            $scope.faculties = faculties.items;
            if (faculties.items && faculties.items.length) {
                $scope.selectFaculty = faculties.items[0];
            }
            checkValid();
        });
        dataContext.getAllFileCategoryes(function (categories) {
            $scope.categories = categories;
            if (categories.length) {
                $scope.selectCategory = categories[0];
            }
            checkValid();
        });

        $scope.$watch('selectFaculty', function (newValue) {
            if (newValue && newValue.Departments && newValue.Departments.length) {
                $scope.selectDepartment = newValue.Departments[0];
            } else {
                $scope.selectDepartment = null;
            }
            checkValid();
        });
        $scope.$watch('selectDepartment', function (newValue) {
            if (newValue) {
                dataContext.getByDepartmentId(newValue.Id).success(function (data) {
                    $scope.subjects = data;
                    $scope.selectSubject = data[0];
                });
            } else {
                $scope.selectSubject = null;
            }
            checkValid();
        });
        $scope.$watch('selectSubject', function (newValue) {
            checkValid();
        });
        $scope.$watch('selectCategory', function (newValue) {
            checkValid();
        });
        $scope.$watch('file', function (newValue) {
            checkValid();
        });

        $scope.upload = function () {

            var data = {
                SubjectId: $scope.selectSubject ? $scope.selectSubject.SubjectId : -1,
                CategoryId: $scope.selectCategory ? $scope.selectCategory.Id : -1
            }

            $scope.progressing = true;
            $scope.error = null;

            fileLoadService.uploadFile($scope.file, data, function (data, status, headers, config) {
                $timeout(function () {
                    $scope.progress = '0%';
                    $scope.progressing = false;
                    $scope.file = null;
                }, 2000);
            }, function (evt) {
                $scope.progress = parseInt(100.0 * evt.loaded / evt.total) + '%';
            }, function () {
                $timeout(function (err) {
                    $scope.progress = '0%';
                    $scope.progressing = false;
                    $scope.error = err;
                }, 2000);
            });
        }

        function checkValid() {
            $scope.isValid = ($scope.selectFaculty && $scope.selectDepartment && $scope.selectSubject && $scope.selectCategory && $scope.file) != null;
        }
    }
})();