(function () {

	'use strict';

	angular
		.module('department')
		.factory('departmentFactory', departmentFactory);

	function departmentFactory() {

		var items = [];
		var service = {};

		service.add = function (department) {
			items.push(department);
		}
		service.addRange = function (departments) {
			departments.forEach(function (department) {
				items.push(department);
			});
		}
		service.update = function (departments) {
			items.length = 0;
			service.addRange(departments);
		}
		service.get = function() {
			return items;
		}
		service.selectInfo = {
			department: {}
		}

		return service;
	}
})();