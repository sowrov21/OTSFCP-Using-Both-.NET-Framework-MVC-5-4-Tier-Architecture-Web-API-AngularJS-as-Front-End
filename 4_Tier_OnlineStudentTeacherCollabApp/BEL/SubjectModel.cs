using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
   public class SubjectModel
    {
        public int subjectId { get; set; }
        public string subjectName { get; set; }
        public int InstructorId { get; set; }
        public string user_userName { get; set; }
        public int subjectPrice { get; set; }
        public System.DateTime subjectCreationTime { get; set; }
        public int statusId { get; set; }
        public string status_statusName { get; set; }
    }
}
