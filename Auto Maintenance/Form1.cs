using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto_Maintenance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowCustomers ShowCustomersform = new ShowCustomers();
            ShowCustomersform.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowCars ShowCarform = new ShowCars();
            ShowCarform.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= (checkedListBox2.Items.Count - 1); i++)
            {
                if (checkedListBox2.GetItemChecked(i))
                {
                    String carType = checkedListBox2.Items[i].ToString();
                    if (carType == "SUV")
                    {
                        float charge = quote.calculateCharge(Int32.Parse(textBox4.Text));
                        MessageBox.Show("Your Total Charges would be " + 2 * charge);
                    }
                    if (carType == "SEDAN")
                    {
                        float charge = quote.calculateCharge(Int32.Parse(textBox4.Text));
                        MessageBox.Show("Your Total Charges would be " + charge);
                    }
                    if (carType == "CROSSTEK")
                    {
                        float charge = quote.calculateCharge(Int32.Parse(textBox4.Text));
                        MessageBox.Show("Your Total Charges would be " + 1.5 * charge);
                    }
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
                for (int x = 0; x < checkedListBox1.Items.Count; ++x)
                {
                    if (e.Index != x) checkedListBox1.SetItemChecked(x, false);
                }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(@"Data Source=KP-HP\SQLEXPRESS;Initial Catalog=login;Integrated Security=True");
                
            for (int i = 0; i <= (checkedListBox1.Items.Count - 1); i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    String carType = checkedListBox1.Items[i].ToString();
                    if (carType == "SUV") {
                        string query = "INSERT INTO CarInfo(Make,Model,Year,Type)VALUES('" + textBox1.Text +"','"+ textBox2.Text + "','" + textBox3.Text + "','" + carType + "')";
                        connect.Open();
                        SqlCommand sqlCommand = new SqlCommand(query, connect);
                        sqlCommand.ExecuteNonQuery();
                        Car SUV = new SUV();
                        SUV.Make = textBox1.Text;
                        SUV.Model = textBox2.Text;
                        SUV.Year = Int32.Parse(textBox3.Text);
                        File.AppendAllText(Application.StartupPath + "\\files\\" + "carInfo.txt",
                            SUV.Make + "\t\t" + SUV.Model + "\t\t" + SUV.Year + "\t\t" + carType + "\n");
                    }
                    if (carType == "SEDAN"){
                        string query = "INSERT INTO CarInfo(Make,Model,Year,Type)VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + carType + "')";
                        connect.Open();
                        SqlCommand sqlCommand = new SqlCommand(query, connect);
                        sqlCommand.ExecuteNonQuery();
                        Car SEDAN = new SEDAN();
                        SEDAN.Make = textBox1.Text;
                        SEDAN.Model = textBox2.Text;
                        SEDAN.Year = Int32.Parse(textBox3.Text);
                        File.AppendAllText(Application.StartupPath + "\\files\\" + "carInfo.txt",
                            SEDAN.Make + "\t\t" + SEDAN.Model + "\t\t" + SEDAN.Year + "\t\t" + carType + "\n");
                    }
                    if (carType == "CROSSTEK"){
                        string query = "INSERT INTO CarInfo(Make,Model,Year,Type)VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + carType + "')";
                        connect.Open();
                        SqlCommand sqlCommand = new SqlCommand(query, connect);
                        sqlCommand.ExecuteNonQuery();
                        Car CROSSTEK = new CROSSTEK();
                        CROSSTEK.Make = textBox1.Text;
                        CROSSTEK.Model = textBox2.Text;
                        CROSSTEK.Year = Int32.Parse(textBox3.Text);
                        File.AppendAllText(Application.StartupPath + "\\files\\" + "carInfo.txt",
                        CROSSTEK.Make + "\t\t" + CROSSTEK.Model + "\t\t" + CROSSTEK.Year + "\t\t" + carType + "\n");
                    }
                }
            }
            MessageBox.Show("Car Added to Records! Check 'Show Cars'");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(@"Data Source=KP-HP\SQLEXPRESS;Initial Catalog=login;Integrated Security=True");

                string query = "INSERT INTO Customers(Name,Address,Phone)VALUES('" + textBox7.Text + "','" + textBox6.Text + "','" + textBox5.Text + "')";
                connect.Open();
                SqlCommand sqlCommand = new SqlCommand(query, connect);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Records Updated: \t\t\n" + textBox7.Text + "\t" + textBox6.Text + "\t" + textBox5.Text + "\n");
            }

        private void button7_Click(object sender, EventArgs e)
        {
            using (SqlConnection sc = new SqlConnection(@"Data Source=KP-HP\SQLEXPRESS;Initial Catalog=login;Integrated Security=True"))
            using (SqlCommand cmd = sc.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM Customers WHERE Phone = '" + textBox8.Text + "'";
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    DataTable table = new DataTable();
                    Console.WriteLine(table.Rows.Count);
                    sda.Fill(table);
                    if (table.Rows.Count > 0)
                        MessageBox.Show("Record Found!\nName:\t\t" + table.Rows[0].ItemArray[0].ToString() + "\n" + "Address:\t\t" + table.Rows[0].ItemArray[1].ToString() + "\n" + "Phone:\t\t" + table.Rows[0].ItemArray[2].ToString());
                    else
                        MessageBox.Show("Recods NOT FOUND!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
