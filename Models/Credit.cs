using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication11.Models
{
    public partial class Credit
    {
        public decimal Cardid { get; set; }
        public string Cardname { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Cardnumber { get; set; }
        public decimal? Customerid { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
