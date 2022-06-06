using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
   public class PostModel
    {
        public int postId { get; set; }
        public int userId { get; set; }
        public string user_userName { get; set; }
        public System.DateTime postTime { get; set; }
        public int courseId { get; set; }
        public string subject_subjectName { get; set; }
        public string postText { get; set; }
        public string postTitle { get; set; }
        public int statusId { get; set; }
        public string status_statusName { get; set; }

    }
}
