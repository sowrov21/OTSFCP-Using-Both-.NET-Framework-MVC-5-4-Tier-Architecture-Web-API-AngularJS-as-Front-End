using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LoginRepo
    {
        static TeacherStudentForumEntities context;
        static LoginRepo()
        {

            context = new TeacherStudentForumEntities();
        }

        public static  User CheckAuthentication(string email, string password)
        {
            var data = context.Users.Where(x => x.userEmail == email && x.userPassword==password).FirstOrDefault();
            /*var data = from u in context.Users
                       where u.userEmail== email && u.userPassword == password
                       select u;*/
            return data;
        }


    }
}
