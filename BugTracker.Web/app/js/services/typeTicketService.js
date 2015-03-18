angular.module('moduleApp').
factory('typeTicketService', ['$http', function ($http) {
    return {
        getTypeTickets: getTypeTickets
    };

    function getTypeTickets() {
        return $http.get('/api/typeTicket');
    }
}]);