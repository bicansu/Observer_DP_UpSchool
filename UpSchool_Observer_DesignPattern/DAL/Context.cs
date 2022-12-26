using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace UpSchool_Observer_DesignPattern.DAL
{
    public class Context:IdentityDbContext<AppUser, AppRole, int> 
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=RAMAZANSURUCU; initial catalog=UpSchoolObserve; integrated security=true");
        }

        public DbSet<Discount> Discounts { get; set; }
    }
}
