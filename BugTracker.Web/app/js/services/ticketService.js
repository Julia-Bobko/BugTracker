angular.module('moduleApp').
factory('ticketService', ['$http', function ($http) {
    return {
        getTickets: getTickets,
        getTicket: getTicket,
        updateTicket: updateTicket
    };

    function getTickets() {
        return $http.get('/api/ticket');
    }

    function getTicket(ticketid) {
        return $http.get('/api/ticket/' + ticketid);
    }

    function updateTicket(ticket) {
        return $http.put('/api/ticket/', ticket);
    }
}]);