using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication11.Models
{
    public partial class Orderproduct
    {
        public decimal OrderproductId { get; set; }
        public decimal? Orderid { get; set; }
        public decimal? Productid { get; set; }

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
