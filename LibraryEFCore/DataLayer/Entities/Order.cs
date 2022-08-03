using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
    public class Order
    {
        private HashSet<LineItem> _lineitems;
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime DeliveryDate { get; set; }

        public bool WasDelivered { get; set; }

        public string CustomerName { get; set; }

        public IEnumerable<LineItem> LineItems => _lineitems.ToList();
        public string OrderNumber => $"ORD{Id:D6}";

        public Order()
        {

        }
        public static Order CreateOrder(string customerName,DateTime orderDate,DateTime deliveryDate) {


            var order = new Order()
            {

                CustomerName = customerName,
                OrderDate = orderDate,
                DeliveryDate = deliveryDate,
                WasDelivered = deliveryDate < DateTime.Now
            };
            return order
        }
    }
}
