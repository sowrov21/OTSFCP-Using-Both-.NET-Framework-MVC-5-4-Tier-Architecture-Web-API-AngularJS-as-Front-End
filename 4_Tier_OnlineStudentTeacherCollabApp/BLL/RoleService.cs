using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using DAL;

namespace BLL
{
    public class RoleService
    {
        public static ICollection<RoleModel> GetRoles()
        {
            var Roles = RoleRepo.GetRoles();

            var data = AutoMapper.Mapper.Map<List<Role>, List<RoleModel>>(Roles);

            return data;
        }

        public static void AddRole(RoleModel pm)
        {
            var u = AutoMapper.Mapper.Map<RoleModel, Role>(pm);
            RoleRepo.AddRole(u);
        }

        public static void EditRole(RoleModel pm)
        {
            var u = AutoMapper.Mapper.Map<RoleModel, Role>(pm);
            RoleRepo.EditRole(u);
        }
        public static RoleModel GetRoleDetails(int id)
        {
            var data = RoleRepo.GetRoleDetails(id);
            var p = AutoMapper.Mapper.Map<Role, RoleModel>(data);

            return p;
        }


        public static void DeleteRole(int id)
        {
            RoleRepo.DeleteRole(id);
        }
    }
}
