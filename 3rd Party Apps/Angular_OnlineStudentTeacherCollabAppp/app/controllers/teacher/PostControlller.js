app.controller("PostControllerTeacher",function($scope,ajax,$location,$sessionStorage){

    //Get The specific data
    var id=  $sessionStorage.userid;
    console.log(id);
      ajax.get(API_ROOT+"api/User/Post/"+id+"/Details", //api/User/Post/{id}/Details
        
      function (response){
        $scope.Post=response.data;
        console.log(response.data);
      },
      function (error){
    
      }
      );
    
    
    });


    app.controller("PostControllerAddTeacher",function($scope,ajax,$location,$sessionStorage){

  

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
          $location.path("/showpostteacher");
        },
        function (error){
    
        });
    
       }
     
    
    });
    