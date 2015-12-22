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

        $scope.save = function () {
            alert($scope.faculties);
        }
    }
})();