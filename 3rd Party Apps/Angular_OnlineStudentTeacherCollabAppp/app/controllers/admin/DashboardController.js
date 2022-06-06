app.controller("AdminDashboardController",function($scope,ajax,$location,$rootScope,$sessionStorage){


    //$scope.restoreType = angular.fromJson($sessionStorage.setType);
    $scope.Type = $sessionStorage.restoreType;
    $scope.UserName = $sessionStorage.username;

});