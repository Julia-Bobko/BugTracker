moduleApp.controller('TicketCtrl', ['$scope', 'ticketService', '$stateParams', '$location', '$anchorScroll', '$modal', function ($scope, ticketService, $stateParams, $location, $anchorScroll, $modal) {
    $scope.isShowCommentEditor = false;

    $scope.clickComment = function () {
        toogleCommentEditor();
        gotoTextComment();
    }

    $scope.ticketModalUpdate = function (size, ticket) {
        $modal.open({
            templateUrl: 'app/partials/ticketEdit.html',
            controller: 'EditTicketCtrl',
            size: size,
            resolve: {
                ticket: function () {
                    return ticket;
                }
            }
        });
    };


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
