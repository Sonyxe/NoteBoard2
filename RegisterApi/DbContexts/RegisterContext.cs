using Microsoft.EntityFrameworkCore;
using RegisterApi.Entities;

namespace RegisterApi.DbContexts
{
    public class RegisterContext: DbContext
    {
        public DbSet<Register> Registers { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Server=localhost;Database=Register;Trusted_Connection=true;");
        }
    }
}
