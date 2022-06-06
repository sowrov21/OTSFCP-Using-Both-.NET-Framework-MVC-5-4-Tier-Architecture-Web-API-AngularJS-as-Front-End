using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using DAL;

namespace BLL
{
    public class UserService
    {
        public static ICollection<UserModel> GetUsers()
        {
            var Users = UserRepo.GetUsers();

            var data = AutoMapper.Mapper.Map<List<User>, List<UserModel>>(Users);

            return data;
        }

        public static void AddUser(UserModel pm)
        {
            var u = AutoMapper.Mapper.Map<UserModel, User>(pm);
            UserRepo.AddUser(u);
        }

        public static void EditUser(UserModel pm)
        {
            var u = AutoMapper.Mapper.Map<UserModel, User>(pm);
            UserRepo.EditUser(u);
        }
        public static UserModel GetUserDetails(int id)
        {
            var data = UserRepo.GetUserDetails(id);
            var p = AutoMapper.Mapper.Map<User, UserModel>(data);

            return p;
        }


        public static void DeleteUser(int id)
        {
            UserRepo.DeleteUser(id);
        }


        public static void UserSatusManage(int id, int status)
        {
            UserRepo.UserSatusManage(id,status);
        }
        public static void UserVerificationManage(int id, int vf)
        {
            UserRepo.UserVerificationManage(id,vf);
        }



    }
}
