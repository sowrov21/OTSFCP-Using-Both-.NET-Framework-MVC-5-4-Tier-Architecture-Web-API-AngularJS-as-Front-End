

app.controller("SubjectControllerAll",function($scope,ajax,$location){

    ajax.get(API_ROOT+"api/Subject/GetAll",success,error);
    function success(response){
      $scope.subjects=response.data;
    }
    function error(error){

    }

     
 

});



app.controller("SubjectControllerAdd",function($scope,ajax,$location){

  

    ajax.get(API_ROOT+"api/User/GetAll",success,error);
    function success(response){
      $scope.users=response.data;
    }
    function error(error){

    }
    $scope.date = new Date()

   // Perform Add
   $scope.addsubject = function (){

    ajax.post(API_ROOT+"api/Subject/Add",$scope.c,
      
    function (response){
      $location.path("/allsubjects");
    },
    function (error){

    });

   }
 

});

app.controller("SubjectControllerEdit",function($scope,ajax,$location,$routeParams){

//Get The specific data
var id= $routeParams.id;
  ajax.get(API_ROOT+"api/Subject/"+id+"/Details",
    
  function (response){
    $scope.c=response.data;
    console.log(response.data);
  },
  function (error){

  }
  );
  
  ajax.get(API_ROOT+"api/User/GetAll",success,error);
  function success(response){
    $scope.users=response.data;
  }
  function error(error){

  }


   // Perform Edit 
   $scope.updateSubject = function (){

    ajax.post(API_ROOT+"api/Subject/Edit",$scope.c,
      
    function (response){
      $location.path("/allSubjects");
    },
    function (error){

    });

   }
 

});


app.controller("SubjectControllerDetails",function($scope,ajax,$location,$routeParams){

    //Get The specific data
    var id= $routeParams.id;
      ajax.get(API_ROOT+"api/Subject/"+id+"/Details",
        
      function (response){
        $scope.subject=response.data;
        console.log(response.data);
      },
      function (error){
    
      }
      );
    
    
    });

 app.controller("SubjectControllerDelete",function($scope,ajax,$location,$routeParams){

        //Get The specific data
        var id= $routeParams.id;
          ajax.get(API_ROOT+"api/Subject/"+id+"/Delete",
            
          function (response){
            $scope.subject=response.data;
            console.log(response.data);
            $location.path("/allsubjects");
          },
          function (error){
        
          }
          );
        
        
     });