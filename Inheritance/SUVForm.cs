using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inheritance
{
    public partial class SUVForm : Form
    {
        public SUVForm()
        {
            InitializeComponent();
        }

        private void btnAddSUV_Click(object sender, EventArgs e)
        {
            int mileage, year, passengers;
            decimal price;
            SUV anSUV = new SUV();
            anSUV.Make = txtMake.Text;

            if (int.TryParse(txtMileage.Text, out mileage))
                anSUV.Mileage = mileage;
            else
            {
                MessageBox.Show("mileage must be a number");
                txtMileage.Clear();
                txtMileage.Focus();


            }

            if (int.TryParse(txtPassengers.Text, out passengers))
                anSUV.Passengers = passengers;
            else
            {
                MessageBox.Show("passengers must be a number");
                txtPassengers.Clear();
                txtPassengers.Focus();


            }
            if (int.TryParse(txtYear.Text, out year))
                anSUV.ModelYear = year;
            else
            {
                MessageBox.Show("year must be a number");
                txtYear.Clear();
                txtYear.Focus();


            }
            if (decimal.TryParse(txtPrice.Text, out price))
                anSUV.Price = price;
            else
            {
                MessageBox.Show("Price must be a number");
                txtPrice.Clear();
                txtPrice.Focus();


            }
            Main.suvs.Add(anSUV);
            txtPassengers.Clear();
            txtMake.Clear();
            txtMileage.Clear();
            txtPrice.Clear();
            txtYear.Clear();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
