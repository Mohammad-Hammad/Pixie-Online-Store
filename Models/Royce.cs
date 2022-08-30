using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace WebApplication11.Models
{
    public partial class Royce
    {
        public decimal? Id { get; set; }
        public string Name { get; set; }
        [NotMapped]
        public IFormFile File { get; set; }
    }
}
