namespace NoteApi.Entities
{
    public class NoteBoard
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Title { get; set; }
        public string Note { get; set; }

        public NoteBoard(int id, string category, string title, string note)
        {
            Id = id;
            Category = category;    
            Title = title;  
            Note = note;
            
        }
    }
}

