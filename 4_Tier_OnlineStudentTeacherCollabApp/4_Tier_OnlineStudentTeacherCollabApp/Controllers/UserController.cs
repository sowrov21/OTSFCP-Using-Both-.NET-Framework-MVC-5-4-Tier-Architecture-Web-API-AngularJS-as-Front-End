using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BEL;
using BLL;

namespace _4_Tier_OnlineStudentTeacherCollabApp.Controllers
{
    public class UserController : ApiController
    {
        [Route("api/User/GetAll")]
        [HttpGet]
        public ICollection<UserModel> GetAllUsers()
        {
            return UserService.GetUsers();
        }

        [Route("api/User/Add")]
        [HttpPost]
        public void Add(UserModel pm)
        {
            UserService.AddUser(pm);
        }

        [Route("api/User/Edit")]
        [HttpPost]
        public void Edit(UserModel pm)
        {
            UserService.EditUser(pm);
        }

        [Route("api/User/{id}/Details")]
        [HttpGet]
        public UserModel GetUserDetails(int id)
        {
            return UserService.GetUserDetails(id);
        }

        [Route("api/User/{id}/Delete")]
        [HttpGet]
        public void DeleteUser(int id)
        {
            UserService.DeleteUser(id);
        } 
        [Route("api/Change/Statusof/{id}/to/{status}")]
        [HttpGet]
        public void UserSatusManage(int id, int status)
        {
            UserService.UserSatusManage(id,status);
        }
        
        [Route("api/Change/Verificationof/{id}/to/{vf}")]
        [HttpGet]
        public void UserVerificationManage(int id, int vf)
        {
            UserService.UserVerificationManage(id,vf);
        }


    }
}
