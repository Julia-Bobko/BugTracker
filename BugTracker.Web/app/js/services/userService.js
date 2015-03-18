angular.module('moduleApp').
factory('userService', ['$http', function ($http) {
    return {
        getUsers: getUsers
    };

    function getUsers() {
        return $http.get('/api/user');
    }
}]);