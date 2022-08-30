using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication11.Models
{
    public partial class Message
    {
        public decimal Id { get; set; }
        public string Message1 { get; set; }
        public decimal? Userid { get; set; }

        public virtual User User { get; set; }
    }
}
