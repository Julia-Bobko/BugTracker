moduleApp.controller('TicketCtrl', ['$scope', 'ticketService', '$stateParams', '$location', '$anchorScroll', function ($scope, ticketService, $stateParams, $location, $anchorScroll) {
    $scope.isShowCommentEditor = false;

    $scope.clickComment = function () {
        toogleCommentEditor();
        gotoTextComment();
    }
    var toogleCommentEditor = function () {
        $scope.isShowCommentEditor = !$scope.isShowCommentEditor;             
    }

    var gotoTextComment = function () {
        if ($scope.isShowCommentEditor) {
            $location.hash('textComment');
        }
        else $location.hash('');
        $anchorScroll();
    }

    ticketService.getTicket($stateParams.ticketId).then(function (res) {
        $scope.ticket = res.data;
    });

}]);
