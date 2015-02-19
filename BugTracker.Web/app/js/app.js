var moduleApp = angular.module('moduleApp', ['ui.router', 'controllersApp', 'dragDrop']);
moduleApp.config(function ($stateProvider, $urlRouterProvider) {
    $urlRouterProvider.otherwise('/tickets');
    $stateProvider
        .state('tickets', {
            url: '/tickets',
            templateUrl: 'app/partials/ticketsList.html',
            controller: 'TicketCtrl'
        })
        .state('ticket', {
            url: '/tickets/:ticketId',
            templateUrl: 'app/partials/ticketDetail.html',
            controller: 'TicketCtrl'
        })     
        .state('about', {           
        });
});