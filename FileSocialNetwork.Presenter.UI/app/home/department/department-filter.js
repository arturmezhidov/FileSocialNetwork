(function () {

	'use strict';

	angular
		.module('department')
		.filter('departmentFilter', departmentFilter);

	function departmentFilter() {

		return function (departments, idFaculty) {

			if (!departments || idFaculty <= 0) {
				return [];
			}

			return departments.filter(function (dep) {
				return dep.FacultyId === idFaculty;
			});
		}
	}

})();