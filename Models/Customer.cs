using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace WebApplication11.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Credits = new HashSet<Credit>();
            Customerproducts = new HashSet<Customerproduct>();
            Orders = new HashSet<Order>();
            Userlogins = new HashSet<Userlogin>();
        }

        public decimal CusId { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Imagename { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }

        public virtual ICollection<Credit> Credits { get; set; }
        public virtual ICollection<Customerproduct> Customerproducts { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Userlogin> Userlogins { get; set; }
    }
}
