using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using DAL;
namespace BLL
{
    public class OrderService
    {
        public static ICollection<OrderModel> GetOrders()
        {
            var Orders = OrderRepo.GetOrders();

            var data = AutoMapper.Mapper.Map<List<Order>, List<OrderModel>>(Orders);

            return data;
        }

        public static void AddOrder(OrderModel pm)
        {
            var o = AutoMapper.Mapper.Map<OrderModel, Order>(pm);
            OrderRepo.AddOrder(o);
        }

        public static void EditOrder(OrderModel pm)
        {
            var o = AutoMapper.Mapper.Map<OrderModel, Order>(pm);
            OrderRepo.EditOrder(o);
        }
        public static OrderModel GetOrderDetails(int id)
        {
            var data = OrderRepo.GetOrderDetails(id);
            var o = AutoMapper.Mapper.Map<Order, OrderModel>(data);

            return o;
        }


        public static void DeleteOrder(int id)
        {
            OrderRepo.DeleteOrder(id);
        }
    }
}
