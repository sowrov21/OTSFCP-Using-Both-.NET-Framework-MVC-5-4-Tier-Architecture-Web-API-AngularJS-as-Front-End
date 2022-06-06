var app = angular.module("myApp", ["ngRoute","ngStorage"]);
var loggedUserInfo;


app.constant('type');


var API_ROOT = "https://localhost:44341/";

app.config([
	"$routeProvider",
	"$locationProvider",
	function ($routeProvider, $locationProvider) {
		$routeProvider
			.when("/", {
				templateUrl: "views/FrontEnd/home.html",
			})
			.when("/login", {
				templateUrl: "views/FrontEnd/login.html",
				controller: "LoginController",
			})
			.when("/logout", {
				templateUrl: "views/FrontEnd/login.html",
				controller: "LogoutController",
			})
			.when("/adminhome", {
				templateUrl: "views/BackEnd/admin/dashboard.html",
				controller:"AdminDashboardController",
			})
			.when("/allusers", {
				templateUrl: "views/BackEnd/admin/allusers.html",
				controller:"UserControllerAll",
			})
			.when("/adduser", {
				templateUrl: "views/BackEnd/admin/adduser.html",
				controller:"UserControllerAdd",
			})
			.when("/useredit/:id", {
				templateUrl: "views/BackEnd/admin/edituser.html",
				controller:"UserControllerEdit",
			})
			.when("/userdetails/:id", {
				templateUrl: "views/BackEnd/admin/userdetails.html",
				controller:"UserControllerDetails",
			})
			.when("/userdelete/:id", {
				templateUrl: "views/BackEnd/admin/allusers.html",
				controller:"UserControllerDelete",
			})
			.when("/changestatusof/:id/to/:status", {
				templateUrl: "views/BackEnd/admin/allusers.html",
				controller:"UserControllerChangeStatus",
			})
			.when("/changeverificationof/:id/to/:vf", {
				templateUrl: "views/BackEnd/admin/allusers.html",
				controller:"UserControllerChangeVerification",
			})
			.when("/allsubjects", {
				templateUrl: "views/BackEnd/admin/allsubjects.html",
				controller:"SubjectControllerAll",
			})
			.when("/addsubject", {
				templateUrl: "views/BackEnd/admin/addsubject.html",
				controller:"SubjectControllerAdd",
			})
			.when("/subjectedit/:id", {
				templateUrl: "views/BackEnd/admin/editsubject.html",
				controller:"SubjectControllerEdit",
			})
			.when("/subjectdetails/:id", {
				templateUrl: "views/BackEnd/admin/subjectdetails.html",
				controller:"SubjectControllerDetails",
			})
			.when("/subjectdelete/:id", {
				templateUrl: "views/BackEnd/admin/allsubjects.html",
				controller:"SubjectControllerDelete",
			})
			.when("/allposts", {
				templateUrl: "views/BackEnd/admin/allposts.html",
				controller:"PostControllerAll",
			})
			.when("/addpost", {
				templateUrl: "views/BackEnd/admin/addpost.html",
				controller:"PostControllerAdd",
			})
			.when("/postedit/:id", {
				templateUrl: "views/BackEnd/admin/editpost.html",
				controller:"PostControllerEdit",
			})
			.when("/postdetails/:id", {
				templateUrl: "views/BackEnd/admin/postdetails.html",
				controller:"PostControllerDetails",
			})
			.when("/postdelete/:id", {
				templateUrl: "views/BackEnd/admin/allposts.html",
				controller:"PostControllerDelete",
			})
			.when("/approveof/:id/to/:verify", {
				templateUrl: "views/BackEnd/admin/allposts.html",
				controller:"PostControllerChangeStatus",
			})
			.when("/teacherhome", {
				templateUrl: "views/BackEnd/teacher/dashboard.html",
				controller:"TeacherDashboardController",
			})
			.when("/studenthome", {
				templateUrl: "views/BackEnd/student/dashboard.html",
				controller:"StudentDashboardController",
			})
			.when("/registration", {
				templateUrl: "views/FrontEnd/register.html",
				controller:"UserControllerRegister",
			})
			.when("/courses", {
				templateUrl: "views/FrontEnd/courses.html",
			})
			.when("/blogs", {
				templateUrl: "views/FrontEnd/blog.html",
			})
			.when("/blogsdetails", {
				templateUrl: "views/FrontEnd/blog_details.html",
			})
			.when("/contact", {
				templateUrl: "views/FrontEnd/contact.html",
			})
			.when("/showpoststudent", {
				templateUrl: "views/BackEnd/student/showposts.html",
				controller:"PostControllerStudent",
			})
			.when("/showpostteacher", {
				templateUrl: "views/BackEnd/teacher/showposts.html",
				controller:"PostControllerTeacher",
			})
			.when("/addteacherpost", {
				templateUrl: "views/BackEnd/teacher/addpost.html",
				controller:"PostControllerAddTeacher",
			})
			.when("/addstudentpost", {
				templateUrl: "views/BackEnd/student/addpost.html",
				controller:"PostControllerAddStudent",
			})
			.otherwise({
				redirectTo: "/",
			});
		//$locationProvider.html5Mode(true);
		//$locationProvider.hashPrefix('');
		//if(window.history && window.history.pushState){
		//$locationProvider.html5Mode(true);
		//}
	},
]);


