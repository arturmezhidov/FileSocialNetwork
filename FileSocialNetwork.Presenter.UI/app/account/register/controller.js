(function () {

    'use strict';

    angular
		.module('account')
		.controller('registerController', registerController);

    registerController.$inject = ['$scope', '$location', 'accountService', 'dataContext'];

    function registerController($scope, $location, accountService, dataContext) {

        dataContext.getFaculties(function (faculties) {
            $scope.faculties = faculties;
        });

        $scope.$watch('faculties', function (newFaculties) {
            if (newFaculties && newFaculties.items.length > 0) {
                $scope.selectFaculty = newFaculties.items[0];
            }
        });

        $scope.$watch('selectFaculty', function (faculty) {
            if (faculty && faculty.Departments.length > 0) {
                $scope.selectDepartment = faculty.Departments[0];
            }
        });

        $scope.$watch('selectDepartment', function (department) {
            if (department && department.Specialities.length > 0) {
                $scope.selectSpeciality = department.Specialities[0];
            }
        });

        $scope.$watch('selectSpeciality', function (speciality) {
            if (speciality && speciality.Id) {
                dataContext.getGroupsBySpecialityId(speciality.Id, function (groups) {
                    $scope.groups = groups;
                });
            }
        });

        $scope.$watch('groups', function (groups) {
            if (groups && groups.length > 0) {
                $scope.selectGroup = groups[0];
            }
        });

        $scope.register = function () {

            var regVM = new RegisterViewModel(
				$scope.firstName,
				$scope.lastName,
				$scope.login,
				$scope.pass,
				$scope.pass2,
				$scope.email,
				$scope.phone,
				$scope.selectGroup.Id
			);

            accountService
				.register(regVM, function (response) {
				    $scope.errorMessage = '';
				    accountService.login($scope.login, $scope.pass, function () {
				        $scope.error = false;
				        $location.path('/');
				    }, function (err) {
				        $scope.error = true;
				        $scope.errorMessage = err;
				    });
				}, function (err) {
				    $scope.error = true;
				    $scope.errorMessage = '';

				    if (err.ModelState && err.ModelState['']) {
				        for (var i = 0; i < err.ModelState[''].length; i++) {
				            $scope.errorMessage += err.ModelState[''][i] + '\n';
				        }
				    } else {
				        $scope.errorMessage = err.error_description
                            ? err.error_description
                            : err.Message;
				    }
				});
        }
    }

})();