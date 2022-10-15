using Microsoft.EntityFrameworkCore;
using Pizzeria.Models;

namespace Pizzeria.data
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<PizzaOrder> PizzaOrders { get; set; }
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }
    }
}
