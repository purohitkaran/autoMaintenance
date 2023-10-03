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

namespace Auto_Maintenance
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        SqlConnection connect = new SqlConnection(@"Data Source=KP-HP\SQLEXPRESS;Initial Catalog=login;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            String username, password;

            try
            {
                String querry = "SELECT * FROM LoginInfo WHERE username='" + text_username.Text + "' AND password='" + text_password.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, connect);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);


                if (dtable.Rows.Count > 0)
                {
                    username = text_username.Text;
                    password = text_password.Text;

                    Form1 form1 = new Form1();
                    form1.Show();
                    this.Hide();
                }
                else
                {

                    MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    text_username.Clear();
                    text_password.Clear();

                    text_username.Focus();

                }
            }
            catch
            {
                // MessageBox.Show("Invalid login details","Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                MessageBox.Show("Invalid login details");
                text_username.Clear();
                text_password.Clear();

                text_username.Focus();
            }
            finally
            {
                connect.Close();
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            text_username.Clear();
            text_password.Clear();

            text_username.Focus();
        }

    }
}
