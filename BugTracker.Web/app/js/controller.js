'use strict';
var controllersApp = angular.module('controllersApp', []);

controllersApp.controller('TicketsListCtrl', ['$scope', '$http', function ($scope, $http) {
    $http.get('/api/ticket').success(function(data){
        $scope.tickets = data;
    });
    $http.get('/api/status').success(function (data) {
        $scope.statuses = data;
    });
}]);

controllersApp.controller('TicketDetailCtrl', ['$scope', '$http','$routeParams', function ($scope, $http, $routeParams) {
    $http.get('/api/ticket/'+$routeParams.ticketId).success(function (data) {
        $scope.ticket = data;
    });    
}]);

controllersApp.controller('LoginCtrl', ['$scope', '$http', function ($scope, $http) {
    $http.get('').success(function (data) {
        $scope.isValue = data;
    });
}]);


