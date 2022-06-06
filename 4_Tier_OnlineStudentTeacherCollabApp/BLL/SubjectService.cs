using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using DAL;

namespace BLL
{
    public class SubjectService
    {
        public static ICollection<SubjectModel> GetSubjects()
        {
            var Subjects = SubjectRepo.GetSubjects();

            var data = AutoMapper.Mapper.Map<List<Subject>, List<SubjectModel>>(Subjects);

            return data;
        }

        public static void AddSubject(SubjectModel pm)
        {
            var u = AutoMapper.Mapper.Map<SubjectModel, Subject>(pm);
            SubjectRepo.AddSubject(u);
        }

        public static void EditSubject(SubjectModel pm)
        {
            var u = AutoMapper.Mapper.Map<SubjectModel, Subject>(pm);
            SubjectRepo.EditSubject(u);
        }
        public static SubjectModel GetSubjectDetails(int id)
        {
            var data = SubjectRepo.GetSubjectDetails(id);
            var p = AutoMapper.Mapper.Map<Subject, SubjectModel>(data);

            return p;
        }


        public static void DeleteSubject(int id)
        {
            SubjectRepo.DeleteSubject(id);
        }
    }
}
