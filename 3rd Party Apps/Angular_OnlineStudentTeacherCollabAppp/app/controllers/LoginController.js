app.controller("LoginController",function($scope,ajax,$location,$sessionStorage){
    

    $scope.CheckAuth = function()
    {
        var email= $scope.email;
        var password= $scope.password;

        delete $sessionStorage.restoreType;
    
        ajax.get(API_ROOT+"api/CheckAuth/By/"+email+"/and/"+password+"",success,error);
          function success(response){
            loggedUserInfo=response.data;
            if(loggedUserInfo.userEmail==email && loggedUserInfo.userPassword==password)
            {
                setType=loggedUserInfo.roleId;

                
                if(loggedUserInfo.roleId==1)
                {
                    $location.path("/adminhome");
                   // $sessionStorage.setType = angular.toJson(restoreType);
                    $sessionStorage.restoreType = setType;
                   // $localStorage.key = value
                   $sessionStorage.username=loggedUserInfo.userName;//30 days to expire
                   $sessionStorage.userid=loggedUserInfo.userId;//30 days to expire


                }
                else if(loggedUserInfo.roleId==2)
                {
                    $location.path("/teacherhome");
                    $sessionStorage.restoreType = setType;
                    $sessionStorage.username=loggedUserInfo.userName;
                    $sessionStorage.userid=loggedUserInfo.userId;//30 days to expire
                }

                else if(loggedUserInfo.roleId==3)
                {
                    $location.path("/studenthome");
                    $sessionStorage.restoreType = setType;
                    $sessionStorage.username=loggedUserInfo.userName;
                    $sessionStorage.userid=loggedUserInfo.userId;//30 days to expire
                }
            }

          }
          function error(error){
      
            delete $sessionStorage.restoreType;
            $location.path("/login");
          }
    }
   
  
  });

  app.controller("LogoutController",function($scope,ajax,$location,$sessionStorage){
    
    $sessionStorage.restoreType ="";
    // $localStorage.key = value
    $sessionStorage.username="";//30 days to expire
    $sessionStorage.userid="";//30 days to expire
    $location.path("/login");
    
  
  });
  
  