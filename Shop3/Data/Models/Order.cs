using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop3.Data.Models
{
    public class Order
    {
        
        public int id { get; set; }

        [Display(Name ="Имя")]
        [StringLength(20)]
        [Required(ErrorMessage ="Введите имя")]
        public string name { get; set; }

        [Display(Name = "Фамилия")]
        [StringLength(20)]
        [Required(ErrorMessage = "Введите фамилию")]
        public string surname { get; set; }

        [Display(Name = "Адрес проживания")]
        [StringLength(20)]
        [Required(ErrorMessage = "Введите адрес проживания")]
        public string adress { get; set; }

        [Display(Name = "Номер телефона")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(20)]
        [Required(ErrorMessage = "Введите номер телефона")]
        public string phone { get; set; }

        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [StringLength(40)]
        [Required(ErrorMessage = "Введите Email")]
        public string email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime orderTime { get; set; }
        public List<OrderDetail> orderDetails { get; set; }
    }
}
