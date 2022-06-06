using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PostRepo
    {
        static TeacherStudentForumEntities context;
        static PostRepo()
        {

            context = new TeacherStudentForumEntities();
        }

        public static List<Post> GetPosts()
        {
            return context.Posts.ToList();
        }

        public static void AddPost(Post odr)
        {
            context.Posts.Add(odr);
            context.SaveChanges();
        }

        public static Post GetPostDetails(int id)
        {
            var data = context.Posts.FirstOrDefault(x => x.postId == id);
            return data;
        }

        public static List<Post>  GetUserPostDetails(int id)
        {
            var data = context.Posts.Where(x => x.userId == id).ToList();
            return data;
        }

        /*        public static Post GetIndividualPostWithSubjectDetails(int id)
                {
                    var data = context.Posts.FirstOrDefault(x => x.postId == id);
                    return data;
                }*/

        public static void EditPost(Post p)
        {
            var old_p = context.Posts.FirstOrDefault(pr => pr.postId == p.postId);
            context.Entry(old_p).CurrentValues.SetValues(p);
            context.SaveChanges();
        }

        public static void DeletePost(int id)
        {
            var data = context.Posts.FirstOrDefault(x => x.postId == id);
            context.Posts.Remove(data);
            context.SaveChanges();
        }

        public static void PostVerificationManage(int id, int vf)
        {
            var p = context.Posts.Where(x => x.postId == id);

            foreach (var u in p)
            {
                u.statusId = vf;
            }
            context.SaveChanges();
        }
    }
}
