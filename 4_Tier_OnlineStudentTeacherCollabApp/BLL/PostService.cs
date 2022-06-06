using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using DAL;

namespace BLL
{
    public class PostService
    {
            public static ICollection<PostModel> GetPosts()
            {
                var Posts = PostRepo.GetPosts();

                var data = AutoMapper.Mapper.Map<List<Post>, List<PostModel>>(Posts);

                return data;
            }

            public static void AddPost(PostModel pm)
            {
                var p = AutoMapper.Mapper.Map<PostModel, Post>(pm);
                PostRepo.AddPost(p);
            }

            public static void EditPost(PostModel pm)
            {
                var p = AutoMapper.Mapper.Map<PostModel, Post>(pm);
                PostRepo.EditPost(p);
            }
            public static PostModel GetPostDetails(int id)
            {
                var data = PostRepo.GetPostDetails(id);
                var p = AutoMapper.Mapper.Map<Post, PostModel>(data);

                return p;
            }  
            public static ICollection<PostModel> GetUserPostDetails(int id)
            {
                var data = PostRepo.GetUserPostDetails(id);
                var p = AutoMapper.Mapper.Map<List<Post>, List<PostModel>>(data);

                return p;
            }


            public static void DeletePost(int id)
            {
                PostRepo.DeletePost(id);
            }

        public static void PostVerificationManage(int id, int vf)
        {
            PostRepo.PostVerificationManage(id, vf);
        }
    }
}
