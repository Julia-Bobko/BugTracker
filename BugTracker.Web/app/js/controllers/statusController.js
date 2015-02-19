controllersApp.controller('StatusCtrl', ['$scope', 'statusService', function ($scope, statusService) {
    statusService.getStatuses().then(function (value) { $scope.statuses = value; });
}]);