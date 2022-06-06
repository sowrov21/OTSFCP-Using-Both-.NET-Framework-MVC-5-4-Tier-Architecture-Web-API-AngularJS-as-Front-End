using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class OrderRepo
    {
        static TeacherStudentForumEntities context;
        static OrderRepo()
        {

            context = new TeacherStudentForumEntities();
        }

        public static List<Order> GetOrders()
        {
            return context.Orders.ToList();
        }

        public static void AddOrder(Order odr)
        {
            context.Orders.Add(odr);
            context.SaveChanges();
        }

        public static Order GetOrderDetails(int id)
        {
            var data = context.Orders.FirstOrDefault(x => x.orderId == id);
            return data;
        }

        public static Order GetIndividualOrderWithSubjectDetails(int id)
        {
            var data = context.Orders.FirstOrDefault(x => x.orderId == id);
            return data;
        }

        public static void EditOrder(Order o)
        {
            var old_o = context.Orders.FirstOrDefault(pr => pr.orderId == o.orderId);
            context.Entry(old_o).CurrentValues.SetValues(o);
            context.SaveChanges();
        }

        public static void DeleteOrder(int id)
        {
            var data = context.Orders.FirstOrDefault(x => x.orderId == id);
            context.Orders.Remove(data);
            context.SaveChanges();
        }
    }
}
