moduleApp.controller('StatusCtrl', ['$scope', 'statusService', function ($scope, statusService) {
    statusService.getStatuses().then(function (res) {
        $scope.statuses = res.data;
    });
}]);