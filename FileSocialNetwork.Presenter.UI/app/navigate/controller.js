(function () {

	'use strict';

	angular
		.module('navigate')
		.controller('navigateController', navigateController);

	navigateController.$inject = ['$rootScope', '$document', '$location'];

	function navigateController($rootScope, $document, $location) {

	    $rootScope.toTheTop = function () {
	        $location.path('/');
			$document.scrollTopAnimated(0, 2000).then(function () {
			});
		}

		var faculty;
		$rootScope.toFaculty = function () {
		    $location.path('/');
			if (!faculty) {
				faculty = angular.element(document.getElementById('faculty'));
			}
			$document.scrollToElementAnimated(faculty, 50, 1000);
		}

		var department;
		$rootScope.toDepartment = function () {
		    $location.path('/');
			if (!department) {
				department = angular.element(document.getElementById('department'));
			}
			$document.scrollToElementAnimated(department, 50, 1000);
		}

		var subject;
		$rootScope.toSubject = function () {
		    $location.path('/');
			if (!subject) {
				subject = angular.element(document.getElementById('subject'));
			}
			$document.scrollToElementAnimated(subject, 50, 1000);
		}

		$rootScope.toUpload = function () {
		    $location.path('/upload');
		}
	}

})();