using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ReplyRepo
    {
        static TeacherStudentForumEntities context;
        static ReplyRepo()
        {

            context = new TeacherStudentForumEntities();
        }

        public static List<Reply> GetReplies()
        {
            return context.Replies.ToList();
        }

        public static void AddReply(Reply odr)
        {
            context.Replies.Add(odr);
            context.SaveChanges();
        }

        public static Reply GetReplyDetails(int id)
        {
            var data = context.Replies.FirstOrDefault(x => x.replyId == id);
            return data;
        }


        public static void EditReply(Reply p)
        {
            var old_p = context.Replies.FirstOrDefault(pr => pr.replyId == p.replyId);
            context.Entry(old_p).CurrentValues.SetValues(p);
            context.SaveChanges();
        }

        public static void DeleteReply(int id)
        {
            var data = context.Replies.FirstOrDefault(x => x.replyId == id);
            context.Replies.Remove(data);
            context.SaveChanges();
        }
    }
}
