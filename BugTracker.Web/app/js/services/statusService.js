angular.module('moduleApp').
factory('statusService', ['$http', '$q', function ($http, $q) {
    return {
        getStatuses: getStatuses
    };

    function getStatuses() {
        var deferred = $q.defer();
        $http.get('/api/status').success(function (data) {
            deferred.resolve(data);
        });
        return deferred.promise;
    }
}]);