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
    }
}
