using Microsoft.EntityFrameworkCore;

namespace TravelBlog.Models
{
    public class TravelBlogContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=TravelBlog;integrated security = True");
        }
    }
}
