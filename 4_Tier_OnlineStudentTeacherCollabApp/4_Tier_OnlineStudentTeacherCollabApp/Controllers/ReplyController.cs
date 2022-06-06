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
    public class ReplyController : ApiController
    {
        [Route("api/Reply/GetAll")]
        [HttpGet]
        public ICollection<ReplyModel> GetReplies()
        {
            return ReplyService.GetReplies();
        }

        [Route("api/Reply/Add")]
        [HttpPost]
        public void Add(ReplyModel pm)
        {
            ReplyService.AddReply(pm);
        }

        [Route("api/Reply/Edit")]
        [HttpPost]
        public void Edit(ReplyModel pm)
        {
            ReplyService.EditReply(pm);
        }

        [Route("api/Reply/{id}/Details")]
        [HttpGet]
        public ReplyModel GetReplyDetails(int id)
        {
            return ReplyService.GetReplyDetails(id);
        }

        [Route("api/Reply/{id}/Delete")]
        [HttpGet]
        public void DeleteReply(int id)
        {
            ReplyService.DeleteReply(id);
        }
    }
}
