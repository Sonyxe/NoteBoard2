using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteBoard
{
    public partial class NewNoteForm : Form
    {
        public NewNoteForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            NewNote noteObject = new NewNote();
            noteObject.Category = txtCategory.Text;
            noteObject.Title = txtTitle.Text;   
            noteObject.Note = txtNote.Text;   

            listNote.Items.Add(noteObject.Category);
            listNote.Items.Add(noteObject.Title);
            listNote.Items.Add(noteObject.Note);
          
            

        }

        private void btnAddPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = new Bitmap(opnfd.FileName);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=LAPTOP-UO5LH5O6;Initial Catalog=NoteBoard;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("insert into NoteBoard Values ( @Category, @Title, @Note)", conn);
           
            cmd.Parameters.AddWithValue("@Category", txtCategory.Text);
            cmd.Parameters.AddWithValue("@Title", txtTitle.Text);
            cmd.Parameters.AddWithValue("@Note", txtNote.Text);
            conn.Open();
            cmd.ExecuteNonQuery();

            MessageBox.Show("Saved!");
           
        }
    }
}
