(function () {
    'use strict';

    angular
        .module('app')
        .controller('tripsController', controller);

    controller.$inject = ['$scope', 'TripsService', '$routerParams']; 

    function controller($scope, TripsService, $routerParams) {
        $scope.title = 'controller';

        var id = $routerParams.ID;
        $scope.trip = TripsService.getTripById(id);
        
        $scope.save = function () {
            TripsService.insert($scope.trip).success(function (data) {
                alert("Trip edited!");
            });
        }

        activate();

        function activate() { }
    }
})();
