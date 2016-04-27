(function () {
    'use strict';

    var app = angular.module('app', [
        'ngRoute']);

    });

    app.config(['$routeProvider',
    function($routeProvider) {
      $routeProvider.
        when('/trips', {
            templateUrl: '/'
        })
    }]);