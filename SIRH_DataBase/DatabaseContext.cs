using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SIRH_DataBase.Entities;

namespace SIRH_DataBase
{
   public class DatabaseContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }

    }
}
