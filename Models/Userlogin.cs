using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication11.Models
{
    public partial class Userlogin
    {
        public decimal Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public decimal? Roleid { get; set; }
        public decimal? Customerid { get; set; }
        public decimal? Userid { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual User User { get; set; }
    }
}
