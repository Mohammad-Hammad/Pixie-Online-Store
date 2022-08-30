using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication11.Models
{
    public partial class ContactU
    {
        public decimal Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
    }
}
