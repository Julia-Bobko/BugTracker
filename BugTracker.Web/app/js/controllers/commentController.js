moduleApp.controller('CommentCtrl', ['$scope', '$stateParams', 'commentService', function ($scope, $stateParams, commentService) {
    $scope.addComment = function () {

        var comment = {
            idTicket: $stateParams.ticketId,
            comments: $scope.text
        };

        commentService.addComment(comment).then(function (res) {           
                $scope.comments.push(comment);
                $scope.text = "";
         
        });
    }

    commentService.getComments($stateParams.ticketId).then(function (res) {
        $scope.comments = res.data;
    });

}]);
