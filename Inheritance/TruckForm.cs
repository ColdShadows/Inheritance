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
    public partial class TruckForm : Form
    {
        public TruckForm()
        {
            InitializeComponent();
        }

        private void btnAddTruck_Click(object sender, EventArgs e)
        {
            int mileage, year, wheeldrive;
            decimal price;
            Truck aTruck = new Truck();
            aTruck.Make = txtMake.Text;

            if (int.TryParse(txtMileage.Text, out mileage))
                aTruck.Mileage = mileage;
            else
            {
                MessageBox.Show("mileage must be a number");
                txtMileage.Clear();
                txtMileage.Focus();


            }

            if (int.TryParse(txtWheelDrive.Text, out wheeldrive) && wheeldrive == 2 || int.TryParse(txtWheelDrive.Text, out wheeldrive) && wheeldrive == 4)
                aTruck.WheelDrive = wheeldrive;
            else
            {
                MessageBox.Show("WheelDrive must be either 2 or 4");
                txtWheelDrive.Clear();
                txtWheelDrive.Focus();


            }
            if (int.TryParse(txtYear.Text, out year))
                aTruck.ModelYear = year;
            else
            {
                MessageBox.Show("year must be a number");
                txtYear.Clear();
                txtYear.Focus();


            }
            if (decimal.TryParse(txtPrice.Text, out price))
                aTruck.Price = price;
            else
            {
                MessageBox.Show("Price must be a number");
                txtPrice.Clear();
                txtPrice.Focus();


            }
            Main.trucks.Add(aTruck);
            txtWheelDrive.Clear();
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
