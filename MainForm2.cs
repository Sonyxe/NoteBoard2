using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteBoard
{
    public partial class MainForm2 : Form
    {
        public MainForm2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewNoteForm form = new NewNoteForm();
            form.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MyNotes form1= new MyNotes();
            form1.ShowDialog();
        }
    }
}
