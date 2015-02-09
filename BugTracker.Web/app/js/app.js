
var moduleApp = angular.module('moduleApp', ['ngRoute', 'controllersApp']);

moduleApp.config(['$routeProvider',
  function ($routeProvider) {
      $routeProvider.
          when('/login', {
              templateUrl: 'app/partialsViews/login.html',
              controller: 'LoginCtrl'
          }).
          when('/tickets', {
              templateUrl: 'app/partialsViews/ticketsList.html',
              controller: 'TicketsListCtrl'
          }).
           when('/tickets/:ticketId', {
               templateUrl: 'app/partialsViews/ticketDetail.html',
               controller: 'TicketDetailCtrl'
           }).
          otherwise({
              redirectTo: '/tickets'
          });
  }]);