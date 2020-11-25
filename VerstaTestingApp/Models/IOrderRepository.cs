using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VerstaTestingApp.Models
{
   public interface IOrderRepository
    {
        IEnumerable<Order> Orders();

        public void SaveOrder(Order order);
    }
}
