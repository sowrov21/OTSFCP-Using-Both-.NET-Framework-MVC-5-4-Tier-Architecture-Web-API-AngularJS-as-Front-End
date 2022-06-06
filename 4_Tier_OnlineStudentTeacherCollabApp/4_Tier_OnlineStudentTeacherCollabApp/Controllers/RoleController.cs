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
    public class RoleController : ApiController
    {
        [Route("api/Role/GetAll")]
        [HttpGet]
        public ICollection<RoleModel> GetAllRoles()
        {
            return RoleService.GetRoles();
        }

        [Route("api/Role/Add")]
        [HttpPost]
        public void Add(RoleModel pm)
        {
            RoleService.AddRole(pm);
        }

        [Route("api/Role/Edit")]
        [HttpPost]
        public void Edit(RoleModel pm)
        {
            RoleService.EditRole(pm);
        }

        [Route("api/Role/{id}/Details")]
        [HttpGet]
        public RoleModel GetRoleDetails(int id)
        {
            return RoleService.GetRoleDetails(id);
        }

        [Route("api/Role/{id}/Delete")]
        [HttpGet]
        public void DeleteRole(int id)
        {
            RoleService.DeleteRole(id);
        }
    }
}
