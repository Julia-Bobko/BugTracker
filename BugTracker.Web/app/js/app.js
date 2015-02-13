
var moduleApp = angular.module('moduleApp', ['ngRoute', 'controllersApp']);

moduleApp.config(['$routeProvider',
  function ($routeProvider) {
      $routeProvider.
          when('/login', {
              templateUrl: 'app/partials/login.html',
              controller: 'LoginCtrl'
          }).
          when('/tickets', {
              templateUrl: 'app/partials/ticketsList.html',
              controller: 'TicketsListCtrl'
          }).
           when('/tickets/:ticketId', {
               templateUrl: 'app/partials/ticketDetail.html',
               controller: 'TicketDetailCtrl'
           }).
          otherwise({
              redirectTo: '/tickets'
          });
  }]);