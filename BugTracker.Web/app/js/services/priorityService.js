angular.module('moduleApp').
factory('priorityService', ['$http', function ($http) {
    return {
        getPriorities: getPriorities
    };

    function getPriorities() {
        return $http.get('/api/priority');
    }
}]);