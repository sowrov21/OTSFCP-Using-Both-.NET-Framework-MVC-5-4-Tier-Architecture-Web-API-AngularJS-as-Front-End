using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using DAL;

namespace BLL
{
    public class StatusService
    {
        public static ICollection<StatusModel> GetStatuses()
        {
            var Statuss = StatusRepo.GetStatuses();

            var data = AutoMapper.Mapper.Map<List<Status>, List<StatusModel>>(Statuss);

            return data;
        }

        public static void AddStatus(StatusModel pm)
        {
            var u = AutoMapper.Mapper.Map<StatusModel, Status>(pm);
            StatusRepo.AddStatus(u);
        }

        public static void EditStatus(StatusModel pm)
        {
            var u = AutoMapper.Mapper.Map<StatusModel, Status>(pm);
            StatusRepo.EditStatus(u);
        }
        public static StatusModel GetStatusDetails(int id)
        {
            var data = StatusRepo.GetStatusDetails(id);
            var p = AutoMapper.Mapper.Map<Status, StatusModel>(data);

            return p;
        }


        public static void DeleteStatus(int id)
        {
            StatusRepo.DeleteStatus(id);
        }
    }
}
