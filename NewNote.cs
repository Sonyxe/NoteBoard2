using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBoard
{
    public class NewNote
    {
       
        public string title;
        public string note;
        public string category;  

        public string Category
        {
           get { return category; }
           set { category = value; }
        }
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Note
        {
            get { return note; }
            set { note = value; }
        }

      
    }
 }
    

