(function () {

    'use strict';

    angular
        .module('faculty')
        .controller('facultyController', facultyController);

    facultyController.$inject = ['$scope', 'httpService'];

    function facultyController($scope, httpService) {

        $scope.faculties = [];

        httpService.getAll().success(function(data) {
            $scope.faculties = data;
        });
    }

})();