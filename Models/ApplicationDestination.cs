using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelBlog.Models
{
    [Table("Destinations")]
    public class ApplicationDestination
    {
        [Key]
        public int Id { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public virtual ApplicationUser User { get; set; }

        public ApplicationDestination(string city, string country, ApplicationUser user, int id = 0)
        {
            City = city;
            Country = country;
            User = user;
            Id = id;
        }

        public ApplicationDestination() { }
    }
}
