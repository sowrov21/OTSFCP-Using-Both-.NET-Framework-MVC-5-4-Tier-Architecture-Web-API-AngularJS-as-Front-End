using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class StatusRepo
    {
        static TeacherStudentForumEntities context;
        static StatusRepo()
        {

            context = new TeacherStudentForumEntities();
        }

        public static List<Status> GetStatuses()
        {
            return context.Statuses.ToList();
        }

        public static void AddStatus(Status odr)
        {
            context.Statuses.Add(odr);
            context.SaveChanges();
        }

        public static Status GetStatusDetails(int id)
        {
            var data = context.Statuses.FirstOrDefault(x => x.statusId == id);
            return data;
        }

        /*        public static Status GetIndividualStatusWithSubjectDetails(int id)
                {
                    var data = context.Statuss.FirstOrDefault(x => x.StatusId == id);
                    return data;
                }*/

        public static void EditStatus(Status p)
        {
            var old_p = context.Statuses.FirstOrDefault(pr => pr.statusId == p.statusId);
            context.Entry(old_p).CurrentValues.SetValues(p);
            context.SaveChanges();
        }

        public static void DeleteStatus(int id)
        {
            var data = context.Statuses.FirstOrDefault(x => x.statusId == id);
            context.Statuses.Remove(data);
            context.SaveChanges();
        }
    }
}
