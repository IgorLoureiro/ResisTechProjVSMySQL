using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using ResisTechHamb.Entities;

namespace ResisTechHamb.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) 
        {
            
        }

        public DbSet<clientes> Clientes { get; set; }
    }
}
