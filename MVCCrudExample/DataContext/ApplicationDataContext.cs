using Microsoft.EntityFrameworkCore;
using MVCCrudExample.Models;

namespace MVCCrudExample.DataContext
{
    public class ApplicationDataContext : DbContext
    {
        public ApplicationDataContext(DbContextOptions<ApplicationDataContext> options): base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
    }
}
