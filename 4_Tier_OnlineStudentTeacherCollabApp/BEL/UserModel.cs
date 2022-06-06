using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class UserModel
    {
        public int userId { get; set; }
        public string userName { get; set; }
        public string userEmail { get; set; }
        public string userPhone { get; set; }
        public System.DateTime userDOB { get; set; }
        public string userPassword { get; set; }
        public int roleId { get; set; }
        public string role_roleName { get; set; }
        public int isVerified { get; set; }
        public int isActive { get; set; }
    }
}
