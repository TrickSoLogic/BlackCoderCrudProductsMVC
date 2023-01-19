using Microsoft.EntityFrameworkCore;

namespace CrudProductsMvc.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        public DbSet<Product> Product { get; set; }
    }
}
