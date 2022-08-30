using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace WebApplication11.Models
{
    public partial class Product
    {
        public Product()
        {
            Customerproducts = new HashSet<Customerproduct>();
            Orderproducts = new HashSet<Orderproduct>();
        }

        public decimal ProId { get; set; }
        public string Name { get; set; }
        public decimal? Sale { get; set; }
        public decimal? Price { get; set; }
        public string Imagename { get; set; }
        public decimal? Categoryid { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<Customerproduct> Customerproducts { get; set; }
        public virtual ICollection<Orderproduct> Orderproducts { get; set; }
    }
}
