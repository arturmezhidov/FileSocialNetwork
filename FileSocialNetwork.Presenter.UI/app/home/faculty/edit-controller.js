(function () {

    'use strict';

    angular
		.module('faculty')
		.controller('facultyEditController', facultyEditController);

    facultyEditController.$inject = ['$scope', 'dataContext'];

    function facultyEditController($scope, dataContext) {

        dataContext.getFaculties(function (faculties) {
            $scope.faculties = faculties.items;
        });

        $scope.remove = function (faculty) {
            for (var i = 0; i < $scope.faculties.length; i++) {
                if ($scope.faculties[i].Id == faculty.Id) {
                    $scope.faculties.splice(i, 1);
                    return;
                }
            }
        }

        $scope.add = function () {
            $scope.faculties.push({});
        }

        $scope.save = function () {
            if (check()) {
                dataContext.saveFaculty($scope.faculties);
            }
        }

        function check() {
            for (var i = 0; i < $scope.faculties.length; i++) {
                if (!$scope.faculties[i].Title) {
                    $scope.error = true;
                    $scope.errorMessage = 'Заполните  все поля';
                    return false;
                }
            }
            $scope.error = false;
            return true;
        }
    }
})();