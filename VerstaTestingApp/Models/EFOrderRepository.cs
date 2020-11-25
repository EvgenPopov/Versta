using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VerstaTestingApp.Models
{
    public class EFOrderRepository : IOrderRepository
    {
        private ApplicationDbContext context;

        public EFOrderRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<Order> Orders()
        {
            return context.Orders;
        }

        public void SaveOrder(Order order)
        {
            context.Orders.Add(order);
            context.SaveChanges();
        }
    }
}
