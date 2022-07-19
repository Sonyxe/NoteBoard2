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
    public partial class MyNotes : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-UO5LH5O6;Initial Catalog=NoteBoard;Integrated Security=True");

        public MyNotes()
        {
            InitializeComponent();
        }
        public void populateGrid()
        {
            conn.Open();
            string query = "select * from NoteBoard";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            dataGv.DataSource = ds.Tables[0];
            conn.Close();
        }
        public void TextBoxFilter()
        {
            conn.Open();
            string query = "select * from NoteBoard where Category='" + txtCategory.Text + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            dataGv.DataSource = ds.Tables[0];
            conn.Close();
        }




        private void MyNotes_Load(object sender, EventArgs e)
        {
            populateGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBoxFilter();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            populateGrid();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            SqlCommand cmd = new SqlCommand("DELETE FROM NoteBoard WHERE Title=@title", conn);

            cmd.Parameters.AddWithValue("@Category", txtCategory.Text);
            cmd.Parameters.AddWithValue("@Title", txtTitle.Text);
            
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Delete!");
        }

        private void dataGv_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {

            txtCategory.Text = dataGv.CurrentRow.Cells[1].Value.ToString();
            txtTitle.Text = dataGv.CurrentRow.Cells[2].Value.ToString();
            
        }
    }
}
