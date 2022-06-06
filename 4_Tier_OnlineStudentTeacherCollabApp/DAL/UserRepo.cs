using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UserRepo
    {
        static TeacherStudentForumEntities context;
        static UserRepo()
        {

            context = new TeacherStudentForumEntities();
        }

        public static List<User> GetUsers()
        {
            return context.Users.ToList();
        }

        public static void AddUser(User odr)
        {
            context.Users.Add(odr);
            context.SaveChanges();
        }

        public static User GetUserDetails(int id)
        {
            var data = context.Users.FirstOrDefault(x => x.userId == id);
            return data;
        }



        public static void EditUser(User p)
        {
            var old_p = context.Users.FirstOrDefault(pr => pr.userId == p.userId);
            context.Entry(old_p).CurrentValues.SetValues(p);
            context.SaveChanges();
        }

        public static void DeleteUser(int id)
        {
            var data = context.Users.FirstOrDefault(x => x.userId == id);
            context.Users.Remove(data);
            context.SaveChanges();
        }


        public static void UserSatusManage(int id,int status)
        {
            var p = context.Users.Where(x => x.userId == id);

            foreach(var u in p)
            {
                u.isActive = status;
            }
            context.SaveChanges();
        }

        public static void UserVerificationManage(int id, int vf)
        {
            var p = context.Users.Where(x => x.userId == id);

            foreach (var u in p)
            {
                u.isVerified = vf;
            }
            context.SaveChanges();
        }

    }
}
