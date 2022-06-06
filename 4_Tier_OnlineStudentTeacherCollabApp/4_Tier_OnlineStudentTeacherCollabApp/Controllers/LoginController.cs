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
    public class LoginController : ApiController
    {
        [Route("api/CheckAuth/By/{email}/and/{password}")]
        [HttpGet]
        public LoginModel GetPostDetails(string email, string password)
        {
            return LoginService.CheckAuthentication(email,password);
        }
    }
}
