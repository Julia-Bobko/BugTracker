angular.module('moduleApp').
factory('commentService', ['$http', '$q', function ($http, $q) {
    return {
        addComment: addComment
    };

    function addComment(comment, ticketId) {
        var deferred = $q.defer();
        var comments = {
            IdTicket: ticketId,
            Comments: comment
        };
        $http.post('/api/comment', comments).success(function (data) {
            deferred.resolve(data);
        });
        return deferred.promise;
    }
}]);