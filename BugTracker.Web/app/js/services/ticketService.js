angular.module('moduleApp').
factory('ticketService', ['$http', '$q', function ($http, $q) {
    return {
        getTickets: getTickets,
        getTicket: getTicket
    };

    function getTickets() {
        var deferred = $q.defer();
        $http.get('/api/ticket').success(function (data) {
            deferred.resolve(data);
        });
        return deferred.promise;
    }

    function getTicket(ticketid) {
        var deferred = $q.defer();
        $http.get('/api/ticket/' + ticketid).success(function (data) {
            deferred.resolve(data);
        });
        return deferred.promise;
    }
}]);