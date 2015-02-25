controllersApp.controller('CommentCtrl', ['$scope', '$stateParams', 'commentService', 'ticketService', function ($scope, $stateParams, commentService, ticketService) {
    $scope.addComment = function () {
        commentService.addComment($scope.comment, $stateParams.ticketId).then(function (value) {
            $scope.comment = "";          
        });
    }
}]);