using Microsoft.EntityFrameworkCore;
using NoteApi.Entities;

namespace NoteApi.DbContexts
{
    public class NoteBoardContext: DbContext
    {
        public DbSet<NoteBoard> NoteBoard { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Server=localhost;Database=NoteBoard;Trusted_Connection=true;");
        }
    }
}

