moduleApp.controller('TicketCtrl', ['$scope', 'ticketService', '$stateParams', function ($scope, ticketService, $stateParams) {
    $scope.isShowCommentEditor = false;

    $scope.toogleCommentEditor = function () {
        $scope.isShowCommentEditor = !$scope.isShowCommentEditor;
    }

    ticketService.getTicket($stateParams.ticketId).then(function (res) {
        $scope.ticket = res.data;
    });

}]);
