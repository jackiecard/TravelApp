var app = angular.module('myApp', []);

app.controller('numbers', function ($scope) {
    $scope.list = [35, 76, 12, 90, 66, 81, 55];
})