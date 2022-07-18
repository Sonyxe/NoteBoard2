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
    public partial class MainForm : Form
    {
        public static MainForm instance;
        public MainForm()
        {
            InitializeComponent();
            instance = this;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NewNoteForm form = new NewNoteForm();
            form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MyNotes form2 = new MyNotes();
            form2.ShowDialog();
        }
    }
}
