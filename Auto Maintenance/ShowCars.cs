using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto_Maintenance
{
    public partial class ShowCars : Form
    {
        public ShowCars()
        {
            InitializeComponent();
        }

        private void ShowCars_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'loginDataSet.CarInfo' table. You can move, or remove it, as needed.
            this.carInfoTableAdapter.Fill(this.loginDataSet.CarInfo);

        }
    }
}
