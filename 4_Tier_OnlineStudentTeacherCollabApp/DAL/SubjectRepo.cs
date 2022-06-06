using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SubjectRepo
    {
        static TeacherStudentForumEntities context;
        static SubjectRepo()
        {

            context = new TeacherStudentForumEntities();
        }

        public static List<Subject> GetSubjects()
        {
            return context.Subjects.ToList();
        }

        public static void AddSubject(Subject odr)
        {
            context.Subjects.Add(odr);
            context.SaveChanges();
        }

        public static Subject GetSubjectDetails(int id)
        {
            var data = context.Subjects.FirstOrDefault(x => x.subjectId == id);
            return data;
        }

        /*        public static Subject GetIndividualSubjectWithSubjectDetails(int id)
                {
                    var data = context.Subjects.FirstOrDefault(x => x.SubjectId == id);
                    return data;
                }*/

        public static void EditSubject(Subject p)
        {
            var old_p = context.Subjects.FirstOrDefault(pr => pr.subjectId == p.subjectId);
            context.Entry(old_p).CurrentValues.SetValues(p);
            context.SaveChanges();
        }

        public static void DeleteSubject(int id)
        {
            var data = context.Subjects.FirstOrDefault(x => x.subjectId == id);
            context.Subjects.Remove(data);
            context.SaveChanges();
        }
    }
}
