

app.controller("PostControllerAll",function($scope,ajax,$location){

    ajax.get(API_ROOT+"api/Post/GetAll",success,error);
    function success(response){
      $scope.Posts=response.data;
    }
    function error(error){

    }

     
 

});



app.controller("PostControllerAdd",function($scope,ajax,$location,$sessionStorage){

  

    $scope.CurrentUId= $sessionStorage.userid;
  
    ajax.get(API_ROOT+"api/Subject/GetAll",success,error);
    function success(response){
      $scope.subjects=response.data;
    }
    function error(error){
  
    }
   
    $scope.date = new Date()

   // Perform Add
   $scope.addPost = function (){

    ajax.post(API_ROOT+"api/Post/Add",$scope.post,
      
    function (response){
      $location.path("/allposts");
    },
    function (error){

    });

   }
 

});

app.controller("PostControllerEdit",function($scope,ajax,$location,$routeParams,$sessionStorage){

//Get The specific data
var id= $routeParams.id;
  ajax.get(API_ROOT+"api/Post/"+id+"/Details",
    
  function (response){
    $scope.post=response.data;
    console.log(response.data);
  },
  function (error){

  }
  );

  
  ajax.get(API_ROOT+"api/Subject/GetAll",success,error);
  function success(response){
    $scope.subjects=response.data;
  }
  function error(error){

  }
 


   // Perform Edit 
   $scope.updatePost = function (){

    ajax.post(API_ROOT+"api/Post/Edit",$scope.post,
      
    function (response){
      $location.path("/allposts");
    },
    function (error){

    });

   }
 

});


app.controller("PostControllerDetails",function($scope,ajax,$location,$routeParams){

    //Get The specific data
    var id= $routeParams.id;
      ajax.get(API_ROOT+"api/Post/"+id+"/Details",
        
      function (response){
        $scope.Post=response.data;
        console.log(response.data);
      },
      function (error){
    
      }
      );
    
    
    });

 app.controller("PostControllerDelete",function($scope,ajax,$location,$routeParams){

        //Get The specific data
        var id= $routeParams.id;
          ajax.get(API_ROOT+"api/Post/"+id+"/Delete",
            
          function (response){
            $scope.Post=response.data;
            console.log(response.data);
            $location.path("/allposts");
          },
          function (error){
        
          }
          );
        
        
     });

     app.controller("PostControllerChangeStatus",function($scope,ajax,$location,$routeParams){

      //Get The specific data api/Change/postStatus/{id}/to/{vf}
      var id= $routeParams.id;
      var verify= $routeParams.verify;
      ajax.get(API_ROOT+"api/Change/postStatus/"+id+"/to/"+verify,
        
      function (response){
        $location.path("/allposts");
      },
      function (error){
    
      }
      );
    
       
      
      });


