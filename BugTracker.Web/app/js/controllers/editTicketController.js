moduleApp.controller('EditTicketCtrl', ['$scope', '$modalInstance', 'ticket', 'ticketService', 'typeTicketService', 'priorityService', 'userService', '$http', function ($scope, $modalInstance, ticket, ticketService, typeTicketService, priorityService, userService, $http) {
    $scope.ticket = angular.copy(ticket);

    typeTicketService.getTypeTickets().then(function (res) {
        $scope.types = res.data;
    });

    priorityService.getPriorities().then(function (res) {
        $scope.priorities = res.data;
    });
    
    userService.getUsers().then(function (res) {
        $scope.users = res.data;
    });

    $scope.update = function (ticketEdit) {
        ticketService.updateTicket(ticketEdit).then(function (res) {
            angular.copy($scope.ticket, ticket);
        });
        $modalInstance.close($scope.ticket);
    };

    $scope.cancel = function () {
        $modalInstance.dismiss('cancel');
    };

}]);

