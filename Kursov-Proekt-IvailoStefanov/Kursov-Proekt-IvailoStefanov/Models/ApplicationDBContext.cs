using Microsoft.EntityFrameworkCore;
using Kursov_Proekt_IvailoStefanov.Models;

namespace Kursov_Proekt_IvailoStefanov.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }
        public DbSet<Category> Categories {get; set;}
    }
}
