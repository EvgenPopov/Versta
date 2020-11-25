using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VerstaTestingApp.Models;

namespace VerstaTestingApp.Controllers
{
    public class AdminController : Controller
    {
        private IOrderRepository repository;

        public AdminController(IOrderRepository repository)
        {
            this.repository = repository;
        }


        public IActionResult List()
        {
            return View(repository.Orders());
        }
    }
}
