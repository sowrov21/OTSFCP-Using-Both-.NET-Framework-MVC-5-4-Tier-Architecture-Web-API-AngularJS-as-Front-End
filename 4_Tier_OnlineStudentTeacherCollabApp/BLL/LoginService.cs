using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using DAL;

namespace BLL
{
   public class LoginService
    {
        public static LoginModel CheckAuthentication(string email,string password)
        {
            var data = LoginRepo.CheckAuthentication(email, password);
            var d = AutoMapper.Mapper.Map<User, LoginModel>(data);

            return d;
        }
    }
}
