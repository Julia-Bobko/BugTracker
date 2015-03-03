angular.module('moduleApp').
factory('statusService', ['$http', function ($http) {
    return {
        getStatuses: getStatuses
    };

    function getStatuses() {
        return $http.get('/api/status');
    }
}]);