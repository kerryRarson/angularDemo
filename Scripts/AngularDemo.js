var AngularDemo = angular.module('AngularDemo', ['ngRoute']);

AngularDemo.controller('LandingPageController', LandingPageController);
AngularDemo.controller('LoginController', LoginController);
AngularDemo.controller('RegisterController', RegisterController);

AngularDemo.factory('AuthHttpResponseInterceptor', AuthHttpResponseInterceptor);
AngularDemo.factory('LoginFactory', LoginFactory);

var configFunction = function ($routeProvider, $httpProvider) {
    $routeProvider.
        when('/routeOne', {
            templateUrl: 'routesDemo/one'
        })
        .when('/routeTwo/:donuts', {
            templateUrl: function (params) { return '/routesDemo/two?donuts=' + params.donuts; }
        })
        .when('/routeThree', {
            templateUrl: 'routesDemo/three'
        })
        .when('/login', {
            templateUrl: '/Account/Login',
            controller: LoginController
        })
        .when('/register', {
            templateUrl: '/Account/Register',
            controller: RegisterController
        });
    $httpProvider.interceptors.push('AuthHttpResponseInterceptor');
}
configFunction.$inject = ['$routeProvider', '$httpProvider'];

AngularDemo.config(configFunction);