using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using DAL;

namespace BLL
{
    public class ReplyService
    {
        public static ICollection<ReplyModel> GetReplies()
        {
            var Replys = ReplyRepo.GetReplies();

            var data = AutoMapper.Mapper.Map<List<Reply>, List<ReplyModel>>(Replys);

            return data;
        }

        public static void AddReply(ReplyModel pm)
        {
            var u = AutoMapper.Mapper.Map<ReplyModel, Reply>(pm);
            ReplyRepo.AddReply(u);
        }

        public static void EditReply(ReplyModel pm)
        {
            var u = AutoMapper.Mapper.Map<ReplyModel, Reply>(pm);
            ReplyRepo.EditReply(u);
        }
        public static ReplyModel GetReplyDetails(int id)
        {
            var data = ReplyRepo.GetReplyDetails(id);
            var p = AutoMapper.Mapper.Map<Reply, ReplyModel>(data);

            return p;
        }


        public static void DeleteReply(int id)
        {
            ReplyRepo.DeleteReply(id);
        }
    }
}
