angular.module('moduleApp').
factory('resolutionService', ['$http', function ($http) {
    return {
        getPesolutions: getPesolutions
    };

    function getPesolutions() {
        return $http.get('/api/resolution');
    }
}]);