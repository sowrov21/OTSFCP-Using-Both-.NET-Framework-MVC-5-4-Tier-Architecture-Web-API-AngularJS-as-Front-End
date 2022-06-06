using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RoleRepo
    {
        static TeacherStudentForumEntities context;
        static RoleRepo()
        {

            context = new TeacherStudentForumEntities();
        }

        public static List<Role> GetRoles()
        {
            return context.Roles.ToList();
        }

        public static void AddRole(Role odr)
        {
            context.Roles.Add(odr);
            context.SaveChanges();
        }

        public static Role GetRoleDetails(int id)
        {
            var data = context.Roles.FirstOrDefault(x => x.roleId == id);
            return data;
        }

        /*        public static Role GetIndividualRoleWithSubjectDetails(int id)
                {
                    var data = context.Roles.FirstOrDefault(x => x.RoleId == id);
                    return data;
                }*/

        public static void EditRole(Role p)
        {
            var old_p = context.Roles.FirstOrDefault(pr => pr.roleId == p.roleId);
            context.Entry(old_p).CurrentValues.SetValues(p);
            context.SaveChanges();
        }

        public static void DeleteRole(int id)
        {
            var data = context.Roles.FirstOrDefault(x => x.roleId == id);
            context.Roles.Remove(data);
            context.SaveChanges();
        }
    }
}
