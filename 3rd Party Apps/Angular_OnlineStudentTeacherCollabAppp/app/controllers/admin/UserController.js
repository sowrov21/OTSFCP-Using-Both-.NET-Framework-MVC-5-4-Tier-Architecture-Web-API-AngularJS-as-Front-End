

app.controller("UserControllerAll",function($scope,ajax,$location){

    ajax.get(API_ROOT+"api/User/GetAll",success,error);
    function success(response){
      $scope.users=response.data;
    }
    function error(error){

    }

     
 

});



app.controller("UserControllerAdd",function($scope,ajax,$location){

  
  ajax.get(API_ROOT+"api/Role/GetAll",
  
  function (response){
    $scope.roles=response.data;
    console.log(response.data);
  },
  function (error){

  }
  );


   // Perform Add
   $scope.adduser = function (){

    ajax.post(API_ROOT+"api/User/Add",$scope.user,
      
    function (response){
      $location.path("/allusers");
    },
    function (error){

    });

   }
 

});

app.controller("UserControllerEdit",function($scope,ajax,$location,$routeParams){

//Get The specific data
var id= $routeParams.id;
  ajax.get(API_ROOT+"api/User/"+id+"/Details",
    
  function (response){
    $scope.user=response.data;
    console.log(response.data);
  },
  function (error){

  }
  );
  
  ajax.get(API_ROOT+"api/Role/GetAll",
  
  function (response){
    $scope.roles=response.data;
    console.log(response.data);
  },
  function (error){

  }
  );


   // Perform Edit 
   $scope.updateuser = function (){

    ajax.post(API_ROOT+"api/User/Edit",$scope.user,
      
    function (response){
      $location.path("/allusers");
    },
    function (error){

    });

   }
 

});


app.controller("UserControllerDetails",function($scope,ajax,$location,$routeParams){

    //Get The specific data
    var id= $routeParams.id;
      ajax.get(API_ROOT+"api/User/"+id+"/Details",
        
      function (response){
        $scope.user=response.data;
        console.log(response.data);
      },
      function (error){
    
      }
      );
    
    
    });

 app.controller("UserControllerDelete",function($scope,ajax,$location,$routeParams){

        //Get The specific data
        var id= $routeParams.id;
          ajax.get(API_ROOT+"api/User/"+id+"/Delete",
            
          function (response){
            $scope.user=response.data;
            console.log(response.data);
            $location.path("/allusers");
          },
          function (error){
        
          }
          );
        
        
     });

     app.controller("UserControllerChangeStatus",function($scope,ajax,$location,$routeParams){

      //Get The specific data  api/Change/Statusof/{id}/to/{status}"
      var id= $routeParams.id;
      var status= $routeParams.status;
      ajax.get(API_ROOT+"api/Change/Statusof/"+id+"/to/"+status,
        
      function (response){
        $scope.user=response.data;
        console.log(response.data);
        $location.path("/allusers");
      },
      function (error){
    
      }
      );
    
       
      
      });


      app.controller("UserControllerChangeVerification",function($scope,ajax,$location,$routeParams){

        //Get The specific data  api/Change/Verificationof/{id}/to/{vf}
        var id= $routeParams.id;
        var vf= $routeParams.vf;
        ajax.get(API_ROOT+"api/Change/Verificationof/"+id+"/to/"+vf,
          
        function (response){
          $scope.user=response.data;
          console.log(response.data);
          $location.path("/allusers");
        },
        function (error){
      
        }
        );
      
         
        
        });


        
app.controller("UserControllerRegister",function($scope,ajax,$location){

  
  ajax.get(API_ROOT+"api/Role/GetAll",
  
  function (response){
    $scope.roles=response.data;
    console.log(response.data);
  },
  function (error){

  }
  );


   // Perform Add
   $scope.adduser = function (){

    ajax.post(API_ROOT+"api/User/Add",$scope.user,
      
    function (response){
      $location.path("/login");
    },
    function (error){

    });

   }
 

});
