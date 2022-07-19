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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=LAPTOP-UO5LH5O6;Initial Catalog=Register;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            String username, password;
            username = txtUserName.Text;
            password = txtPassword.Text;

            try
            {
                String querry = ("SELECT *  FROM Registers WHERE name='"+txtUserName.Text+"' AND password='"+txtPassword.Text+"'");
                SqlDataAdapter sd=new SqlDataAdapter(querry,cn);

                DataTable dtable=new DataTable();
                sd.Fill(dtable);

                if(dtable.Rows.Count > 0)
                {
                    username = txtUserName.Text;
                    password=txtPassword.Text;

                    MainForm2 form1 = new MainForm2();
                    form1.Show();
                    this.Hide();
                    

                }
                else
                {
                    MessageBox.Show("Invalid","Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                cn.Close();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}

          
