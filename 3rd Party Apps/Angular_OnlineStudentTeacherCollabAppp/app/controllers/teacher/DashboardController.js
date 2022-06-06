app.controller("TeacherDashboardController",function($scope,ajax,$location,$rootScope,$sessionStorage){

    $scope.Type = $sessionStorage.restoreType;
    $scope.UserName = $sessionStorage.username;

});