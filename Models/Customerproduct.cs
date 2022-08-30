using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication11.Models
{
    public partial class Customerproduct
    {
        public decimal CpId { get; set; }
        public decimal? Productid { get; set; }
        public decimal? Customerid { get; set; }
        public decimal? Quantity { get; set; }
        public DateTime? Datefrom { get; set; }
        public DateTime? Dateto { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Product Product { get; set; }
    }
}
