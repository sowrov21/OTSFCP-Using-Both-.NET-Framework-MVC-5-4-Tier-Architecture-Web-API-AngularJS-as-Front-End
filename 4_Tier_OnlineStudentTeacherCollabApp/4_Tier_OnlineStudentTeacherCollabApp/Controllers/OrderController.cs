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
    public class OrderController : ApiController
    {
        [Route("api/Order/GetAll")]
        [HttpGet]
        public ICollection<OrderModel> GetAllOrders()
        {
            return OrderService.GetOrders();
        }

        [Route("api/Order/Add")]
        [HttpPost]
        public void Add(OrderModel pm)
        {
            OrderService.AddOrder(pm);
        }

        [Route("api/Order/Edit")]
        [HttpPost]
        public void Edit(OrderModel pm)
        {
            OrderService.EditOrder(pm);
        }

        [Route("api/Order/{id}/Details")]
        [HttpGet]
        public OrderModel GetOrderDetails(int id)
        {
            return OrderService.GetOrderDetails(id);
        }

        [Route("api/Order/{id}/Delete")]
        [HttpGet]
        public void DeleteOrder(int id)
        {
            OrderService.DeleteOrder(id);
        }
    }
}
