using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
   public class ReplyModel
    {
        public int replyId { get; set; }
        public int postId { get; set; }
        public System.DateTime replyTime { get; set; }
        public int userId { get; set; }
        public string replyText { get; set; }
    }
}
