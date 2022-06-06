using BLL.MapperConfig;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace _4_Tier_OnlineStudentTeacherCollabApp
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            AutoMapper.Mapper.Initialize(con => con.AddProfile<AutoMapperSettings>());
        }
    }
}
