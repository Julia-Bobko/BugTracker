angular.module('moduleApp').
factory('commentService', ['$http', function ($http) {
    return {
        addComment: addComment,      
        getComments: getComments
    };

    function addComment(comment) {
        return $http.post('/api/comment', comment);
    }

    function getComments(idTicket) {
        return $http.get('/api/comment/GetComments/' + idTicket);
    }

    //function getComments() {
    //    return $http.get('/api/comment');
    //}
}]);