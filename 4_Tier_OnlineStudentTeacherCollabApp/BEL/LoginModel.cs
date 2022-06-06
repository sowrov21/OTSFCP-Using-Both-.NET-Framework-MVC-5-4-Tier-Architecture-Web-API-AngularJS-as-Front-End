using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class LoginModel
    {
        public int userId { get; set; }
        public string userName { get; set; }
        public string userEmail { get; set; }
        public string userPhone { get; set; }
        public DateTime userDOB { get; set; }
        public string userPassword { get; set; }
        public int roleId { get; set; }
        public int isVerified { get; set; }
        public int isActive { get; set; }
    }
}
