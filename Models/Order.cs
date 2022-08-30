using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication11.Models
{
    public partial class Order
    {
        public Order()
        {
            Orderproducts = new HashSet<Orderproduct>();
        }

        public decimal OrdId { get; set; }
        public decimal? Totalprice { get; set; }
        public DateTime? OrderAt { get; set; }
        public decimal? Customerid { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual ICollection<Orderproduct> Orderproducts { get; set; }
    }
}
