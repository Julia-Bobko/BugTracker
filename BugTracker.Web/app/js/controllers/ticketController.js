controllersApp.controller('TicketCtrl', ['$scope', 'ticketService', '$stateParams',
    function ($scope, ticketService, $stateParams) {
    ticketService.getTickets().then(function (value) { $scope.tickets = value; });
    ticketService.getTicket($stateParams.ticketId).then(function (value) { $scope.ticket = value; });
    $scope.hideComment = function () { $scope.isComment = false; }
    $scope.showComment = function () { $scope.isComment = true; }
    $scope.url = "/" + $stateParams.ticket + "/" + $stateParams.ticketId + "#textComment";
}]);

