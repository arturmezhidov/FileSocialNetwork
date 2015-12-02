(function () {

	'use strict';

	angular
		.module('faculty')
		.factory('facultyFactory', facultyFactory);

	function facultyFactory() {

		var items = [];
		var service = {};

		service.add = function (faculty) {
			items.push(faculty);
		}
		service.addRange = function (faculties) {
			faculties.forEach(function (faculty) {
				items.push(faculty);
			});
		}
		service.update = function (faculties) {
			items.length = 0;
			service.addRange(faculties);
		}
		service.get = function() {
			return items;
		}
		service.selectInfo = {
			faculty: { }
		}

		return service;
	}
})();