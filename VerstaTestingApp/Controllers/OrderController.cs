using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VerstaTestingApp.Models;

namespace VerstaTestingApp.Controllers
{
    public class OrderController : Controller
    {
        private IOrderRepository repository;

        public OrderController(IOrderRepository repository)
        {
            this.repository = repository;
        }


        [HttpPost]
        public IActionResult AddOrder(Order order)
        {
            if (ModelState.IsValid)
            {
                repository.SaveOrder(order);
                return View("Completed");
            }
            else
                return View();
        }


        [HttpGet]
        public IActionResult AddOrder()
        {
            return View();

        }

       
    }
}
