using System;

namespace NoteApi.Entities
{
    public class NoteEnt
    {
        public Guid Id { get; set; }
        public int Category { get; set; }
        public string Title { get; set; }
        public string Note { get; set; }

        public NoteEnt(int category, string title, string note)
        {
            Id = Guid.NewGuid();
            Category = category;
            Title = title;
            Note = note;
        }
    }
}

