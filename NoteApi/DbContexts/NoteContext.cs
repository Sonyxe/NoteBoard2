using Microsoft.EntityFrameworkCore;
using NoteApi.Entities;

namespace NoteApi.DbContexts
{
    public class NoteContext: DbContext
    {
        public DbSet<NoteEnt> NoteEnts { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Server=localhost;Database=Note;Trusted_Connection=true;");
        }
    }
}

