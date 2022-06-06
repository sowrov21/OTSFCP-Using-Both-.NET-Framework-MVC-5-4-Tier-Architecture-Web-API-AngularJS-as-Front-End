using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BEL;
using BLL;

namespace _4_Tier_OnlineStudentTeacherCollabApp.Controllers
{
    public class PostController : ApiController
    {
        [Route("api/Post/GetAll")]
        [HttpGet]
        public ICollection<PostModel> GetAllPosts()
        {
            return PostService.GetPosts();
        }

        [Route("api/Post/Add")]
        [HttpPost]
        public void Add(PostModel pm)
        {
            PostService.AddPost(pm);
        }

        [Route("api/Post/Edit")]
        [HttpPost]
        public void Edit(PostModel pm)
        {
            PostService.EditPost(pm);
        }

        [Route("api/Post/{id}/Details")]
        [HttpGet]
        public PostModel GetPostDetails(int id)
        {
            return PostService.GetPostDetails(id);
        }
        [Route("api/User/Post/{id}/Details")]
        [HttpGet]
        public ICollection<PostModel> GetUserPostDetails(int id)
        {
            return PostService.GetUserPostDetails(id);
        }

        [Route("api/Post/{id}/Delete")]
        [HttpGet]
        public void DeletePost(int id)
        {
            PostService.DeletePost(id);
        }

        [Route("api/Change/postStatus/{id}/to/{verify}")]
        [HttpGet]
        public void PostVerificationManage(int id, int verify)
        {
            PostService.PostVerificationManage(id, verify);
        }
    }
}
