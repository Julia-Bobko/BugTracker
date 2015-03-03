moduleApp.controller('CommentCtrl', ['$scope', '$stateParams', 'commentService', 'ticketService', function ($scope, $stateParams, commentService, ticketService) {
    $scope.addComment = function () {
        var comment = {
            IdTicket: $stateParams.ticketId,
            Comments: $scope.textComment
        };
        commentService.addComment(comment).then(function (value) {
            $scope.textComment = "";
        });
    }
}]);