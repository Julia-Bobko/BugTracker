var moduleApp = angular.module('moduleApp', ['ui.router', 'ngDraggable']);
moduleApp.config(function ($stateProvider, $urlRouterProvider) {
    $urlRouterProvider.otherwise('/menu/tickets');
    $stateProvider
        .state('menu.tickets', {
            url: '/tickets',
            templateUrl: 'app/partials/ticketList.html',
            controller: 'TicketListCtrl'
        })
        .state('menu', {
            url: '/menu',
            templateUrl: 'app/partials/menu.html'
        })
        .state('ticket', {
            url: '/menu/tickets/:ticketId',
            templateUrl: 'app/partials/ticket.html',
            controller: 'TicketCtrl'
        })
        .state('menu.path4', {
            url: '/path4'
        })
        .state('menu.path1', {
            url: '/path1'
        })
        .state('menu.path2', {
            url: '/path2'
        })
        .state('menu.path3', {
            url: '/path3'
        });
});