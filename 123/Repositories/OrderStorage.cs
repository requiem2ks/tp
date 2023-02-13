using System.Collections.Generic;
using System.Data.SqlClient;

namespace MusicShop.Repositories
{
    public class OrderStorage
    {
        private Dictionary<int, Order> Orders { get; } = new Dictionary<int, Order>();

        public void Create(Order order)
        {
            Orders.Add(order.OrderId, order);
        }

        public Order Read(int OrderId)
        {
            return Orders[OrderId];
        }

        public Order Update(int OrderId, Order newOrder)
        {
            Orders[OrderId] = newOrder;
            return Orders[OrderId];
        }

        public bool Delete(int OrderId)
        {
            return Orders.Remove(OrderId);
        }
    }
}