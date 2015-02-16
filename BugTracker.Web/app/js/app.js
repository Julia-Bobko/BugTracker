var moduleApp = angular.module('moduleApp', ['ui.router', 'controllersApp', 'dragDrop']);
moduleApp.config(function ($stateProvider, $urlRouterProvider) {
    $urlRouterProvider.otherwise('/tickets');
    $stateProvider
        .state('/login', {
            templateUrl: 'app/partials/login.html',
            controller: 'LoginCtrl'
        }
        )
        .state('/tickets', {
            templateUrl: 'app/partials/ticketsList.html',
            controller: 'TicketsListCtrl'
        })
           .state('/tickets/:ticketId', {
               templateUrl: 'app/partials/ticketDetail.html',
               controller: 'TicketDetailCtrl'
           });
});

