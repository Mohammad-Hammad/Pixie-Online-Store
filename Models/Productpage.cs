using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace WebApplication11.Models
{
    public partial class Productpage
    {
        public decimal Id { get; set; }
        public string Imagename { get; set; }
        public string Productname { get; set; }
        public decimal? Productprice { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
    }
}
