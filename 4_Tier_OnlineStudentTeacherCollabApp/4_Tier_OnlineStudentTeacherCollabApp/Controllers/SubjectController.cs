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
    public class SubjectController : ApiController
    {
        [Route("api/Subject/GetAll")]
        [HttpGet]
        public ICollection<SubjectModel> GetAllSubjects()
        {
            return SubjectService.GetSubjects();
        }

        [Route("api/Subject/Add")]
        [HttpPost]
        public void Add(SubjectModel pm)
        {
            SubjectService.AddSubject(pm);
        }

        [Route("api/Subject/Edit")]
        [HttpPost]
        public void Edit(SubjectModel pm)
        {
            SubjectService.EditSubject(pm);
        }

        [Route("api/Subject/{id}/Details")]
        [HttpGet]
        public SubjectModel GetSubjectDetails(int id)
        {
            return SubjectService.GetSubjectDetails(id);
        }

        [Route("api/Subject/{id}/Delete")]
        [HttpGet]
        public void DeleteSubject(int id)
        {
            SubjectService.DeleteSubject(id);
        }
    }
}
