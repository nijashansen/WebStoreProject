using Core.Entity;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.SQLList
{
    public class Context: DbContext
    {
        public Context(DbContextOptions opt) : base(opt)
        {

        }
        
        public DbSet<Clothing> Clothes { get; set; }
    }
}