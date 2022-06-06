using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
   public class OrderModel
    {
        public int orderId { get; set; }
        public int userId { get; set; }
        public System.DateTime orderTime { get; set; }
        public string billingAddress { get; set; }
        public string transactionType { get; set; }
        public int courseId { get; set; }

    }
}
