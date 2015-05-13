moduleApp.controller('TicketListCtrl', ['$scope', 'ticketService', '$stateParams', function ($scope, ticketService, $stateParams) {
    ticketService.getTickets().then(function (res) {
        $scope.tickets = res.data
    });

    $scope.onDropComplete = function (evt, status) {
        status = JSON.parse(status);
        if (evt.data.status.title != status.title) {
            if (status.title == "Done") {
                evt.element[0].children[1].children[1].children[0].classList.add('done');
            }
            var ticket = {
                idTicket: evt.data.idTicket,
                Status: status
            };
            evt.data.status.title = status.title;
            evt.data.status.id = status.id;
            ticketService.updateTicket(ticket).then(function (data) {
            });
        }
    }

    $scope.onDragSuccess = function (evt) {
        if (evt.element[0].parentElement.id == "Done") {
            evt.element[0].children[1].children[1].children[0].classList.remove('done');
        }
    }
}]);