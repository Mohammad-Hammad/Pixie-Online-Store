using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication11.Models
{
    public partial class User
    {
        public User()
        {
            Messages = new HashSet<Message>();
            Testimonials = new HashSet<Testimonial>();
            Userlogins = new HashSet<Userlogin>();
        }

        public decimal UserId { get; set; }
        public string Fullname { get; set; }
        public decimal? Salary { get; set; }
        public string Position { get; set; }

        public virtual ICollection<Message> Messages { get; set; }
        public virtual ICollection<Testimonial> Testimonials { get; set; }
        public virtual ICollection<Userlogin> Userlogins { get; set; }
    }
}
