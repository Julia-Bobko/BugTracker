controllersApp.controller('TicketCtrl', ['$scope', 'ticketService', '$stateParams',
    function ($scope, ticketService, $stateParams) {
    ticketService.getTickets().then(function (value) { $scope.tickets = value; });
    ticketService.getTicket($stateParams.ticketId).then(function (value) { $scope.ticket = value; });
}]);

