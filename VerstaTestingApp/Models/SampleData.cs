using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VerstaTestingApp.Models
{
    public static class SampleData
    {
       public static void Initialize(ApplicationDbContext context)
        {
            if(!context.Orders.Any())
            {
                context.Orders.Add(new Order
                {
                    PickUpDate = new DateTime(2020, 10, 23),
                    CargoWeight = 25,
                    OrderNumber = new Guid(),
                    RecipientAdress = "Улица куликова",
                    RecipientCity = "Астрахань",
                    SenderAdress = "Метро полежаевская",
                    SenderCity = "Москва"
                });

                context.SaveChanges();
            }
        }

    }
}
