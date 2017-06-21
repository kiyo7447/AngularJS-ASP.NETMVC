'use strict';

// Google Analytics Collection APIs Reference:
// https://developers.google.com/analytics/devguides/collection/analyticsjs/

console.log('load app.controllers');

var app = angular.module('app.controllers', []);
	app
	// Path: /
    .controller('HomeCtrl', ['$scope', '$location', '$window', function ($scope, $location, $window) {
        $scope.$root.title = 'Home Title';
        $scope.message = 'Hello Home Page';
        $scope.$on('$viewContentLoaded', function () {
        	console.log('viewContentLoaded Home Controller');
            $window.ga('send', 'pageview', { 'page': $location.path(), 'title': $scope.$root.title });
        });
    }])

    // Path: /about
    //.controller('AboutCtrl', ['$scope', '$location', '$window', function ($scope, $location, $window) {
    //    $scope.$root.title = '2AngularJS SPA | About';
    //    $scope.ok = 'hogehoge';
    //    $scope.$on('$viewContentLoaded', function () {
    //    	console.log('viewContentLoaded About');
    //    	$window.ga('send', 'pageview', { 'page': $location.path(), 'title': $scope.$root.title });
    //    });
    //}])

    // Path: /contacts
    .controller('ContactsCtrl', ['$scope', '$location', '$window', function ($scope, $location, $window) {
        $scope.$root.title = 'Contacts Title';
        $scope.message = 'Hello Contacts Page!';
        $scope.$on('$viewContentLoaded', function () {
        	console.log('viewContentLoaded Contacts');
        	$window.ga('send', 'pageview', { 'page': $location.path(), 'title': $scope.$root.title });
        });
    }])

    // Path: /login
    .controller('LoginCtrl', ['$scope', '$location', '$window', function ($scope, $location, $window) {
        $scope.$root.title = 'AngularJS SPA | Sign In';
        // TODO: Authorize a user
        $scope.login = function () {
            $location.path('/');
            return false;
        };
        $scope.$on('$viewContentLoaded', function () {
            $window.ga('send', 'pageview', { 'page': $location.path(), 'title': $scope.$root.title });
        });
    }])

    // Path: /error/404
    .controller('Error404Ctrl', ['$scope', '$location', '$window', function ($scope, $location, $window) {
        $scope.$root.title = 'Error 404: Page Not Found';
        $scope.$on('$viewContentLoaded', function () {
            $window.ga('send', 'pageview', { 'page': $location.path(), 'title': $scope.$root.title });
        });
    }]);

	var app = angular.module('app.controllers');

	app.config(['$controllerProvider', function ($controllerProvider) {
		app.$controllerProvider = $controllerProvider;

		//app.con.register('AboutCtrl', ['$scope', '$location', '$window', function ($scope, $location, $window) {
		//	$scope.$root.title = '22AngularJS SPA | About';
		//	$scope.ok = '22hogehoge';
		//	$scope.$on('$viewContentLoaded', function () {
		//		console.log('22viewContentLoaded About');
		//		$window.ga('send', 'pageview', { 'page': $location.path(), 'title': $scope.$root.title });
		//	})
		//}]);
	}]);


//	var app = angular.module('app.controllers');
//app.con.register('AboutCtrl', ['$scope', '$location', '$window', function ($scope, $location, $window) {
//	$scope.$root.title = '22AngularJS SPA | About';
//	$scope.ok = '22hogehoge';
//	$scope.$on('$viewContentLoaded', function () {
//		console.log('22viewContentLoaded About');
//		$window.ga('send', 'pageview', { 'page': $location.path(), 'title': $scope.$root.title });
//	})
//}]);

