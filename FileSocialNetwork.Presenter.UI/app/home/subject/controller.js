(function () {

	'use strict';

	angular
		.module('subject')
		.controller('subjectController', subjectController);

	subjectController.$inject = ['$scope', 'dataContext', 'accountService'];

	function subjectController($scope, dataContext, accountService) {

		dataContext.getFaculties(function (faculties) {
			$scope.faculties = faculties;
		});

		$scope.departments = dataContext.getDepartments();

		$scope.like = function (file) {

		    if (!accountService.check('/')) {
		        return;
		    }
		    
		    if (file && file.Id) {
		        dataContext.like(file.Id).success(function(response){
		            if (response && response.Success) {
		                file.Liked = response.Liked;
		                file.Likes = response.LikesCount;
		            }
		        });
		    }
		}

		$scope.$watch('departments.select', function (newValue) {
		    if (newValue && newValue.Id) {
				dataContext.getByDepartmentId(newValue.Id).success(function (data) {
					$scope.subjects = data;
				});
			}
		});
	}
})();