using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VerstaTestingApp.Models
{
    public class Order
    {
        [BindNever]
        public int Id { get; set; }

        [Required(ErrorMessage = "Пожалуйста,введите название города")]
        public string SenderCity { get; set; }

        [Required(ErrorMessage = "Пожалуйста,введите адресс")]
        public string SenderAdress { get; set; }

        [Required(ErrorMessage = "Пожалуйста,введите город")]
        public string RecipientCity { get; set; }

        [Required(ErrorMessage = "Пожалуйста,введите адресс")]
        public string RecipientAdress { get; set; }

        
        [Required(ErrorMessage ="Введите вес груза")]
        public int? CargoWeight { get; set; }


        [UIHint("Date")]
        [Required(ErrorMessage = "Введите дату")]
        public DateTime? PickUpDate { get; set; }


        [BindNever]
        public Guid OrderNumber { get; set; }

        public Order()
        {
            OrderNumber = Guid.NewGuid();
        }
    }
}
