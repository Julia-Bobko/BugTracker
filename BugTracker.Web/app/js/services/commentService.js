angular.module('moduleApp').
factory('commentService', ['$http', function ($http) {
    return {
        addComment: addComment,
        getTicketComments: getTicketComments
    };

    function addComment(comment) {
        return $http.post('/api/comment', comment);
    }

    function getTicketComments(idTicket) {
        return $http.get('/api/comment/' + idTicket);
    }
}]);