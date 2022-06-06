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
    public class StatusController : ApiController
    {
        [Route("api/Status/GetAll")]
        [HttpGet]
        public ICollection<StatusModel> GetAllStatuses()
        {
            return StatusService.GetStatuses();
        }

        [Route("api/Status/Add")]
        [HttpPost]
        public void Add(StatusModel pm)
        {
            StatusService.AddStatus(pm);
        }

        [Route("api/Status/Edit")]
        [HttpPost]
        public void Edit(StatusModel pm)
        {
            StatusService.EditStatus(pm);
        }

        [Route("api/Status/{id}/Details")]
        [HttpGet]
        public StatusModel GetStatusDetails(int id)
        {
            return StatusService.GetStatusDetails(id);
        }

        [Route("api/Status/{id}/Delete")]
        [HttpGet]
        public void DeleteStatus(int id)
        {
            StatusService.DeleteStatus(id);
        }
    }
}
