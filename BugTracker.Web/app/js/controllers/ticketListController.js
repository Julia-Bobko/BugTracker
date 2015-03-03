moduleApp.controller('TicketListCtrl', ['$scope', 'ticketService', '$stateParams', function ($scope, ticketService, $stateParams) {
    ticketService.getTickets().then(function (res) {
        $scope.tickets = res.data
    });

    $scope.onDropComplete = function (evt, idDropElement) {
        if (idDropElement == "Done") {
            evt.element[0].children[1].children[1].children[0].classList.add('done');
        }
        var dropElement = document.getElementById(idDropElement);
        var ticket = {
            idTicket: evt.data.idTicket,
            Status: { "title": idDropElement }
        };
        dropElement.appendChild(evt.element[0]);
        ticketService.updateTicket(ticket).then(function (data) {
        });
    }

    $scope.onDragSuccess = function (evt) {
        var a = evt.element[0].parentElement.id;
        if (evt.element[0].parentElement.id == "Done") {
            evt.element[0].children[1].children[1].children[0].classList.remove('done');
        }
    }
}]);