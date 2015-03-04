moduleApp.controller('CommentCtrl', ['$scope', '$stateParams', 'commentService', function ($scope, $stateParams, commentService) {
     $scope.addComment = function () {
        var comment = {
            IdTicket: $stateParams.ticketId,
            Comments: $scope.text
        };
        commentService.addComment(comment).then(function (res) {
            $scope.ticket.comments.push(comment);
            $scope.text = "";
        });
    }    
}]);
