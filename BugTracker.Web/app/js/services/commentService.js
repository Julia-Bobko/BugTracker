angular.module('moduleApp').
factory('commentService', ['$http', function ($http) {
    return {
        addComment: addComment
    };

    function addComment(comment) {
        return $http.post('/api/comment', comment);
    }
}]);