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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-UO5LH5O6;Initial Catalog=Register;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("insert into Registers Values (  @Name, @Password)", con);

            cmd.Parameters.AddWithValue("@Name", txtName.Text);
            cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
            con.Open();
            cmd.ExecuteNonQuery();

            MessageBox.Show("Saved!");
        }
    }
}
