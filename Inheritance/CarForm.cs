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
    public partial class CarForm : Form
    {
        public CarForm()
        {
            InitializeComponent();
        }

        private void CarForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            int year, mileage, doors;
            decimal price;
            string make = txtMake.Text;
           /* Car aCar = new Car();
            aCar.Make = txtMake.Text;
            if (int.TryParse(txtYear.Text, out year))
                aCar.ModelYear = year;
            else
            {
                MessageBox.Show("Year must be an integer");
                txtYear.Clear();
                txtYear.Focus();

            }
            if (int.TryParse(txtMileage.Text, out mileage))
                aCar.Mileage = mileage;
            else
            {
                MessageBox.Show("Mileage must be an integer");
                txtMileage.Clear();
                txtMileage.Focus();

            }
            if( int.TryParse(txtDoors.Text, out doors))
                aCar.Doors = doors;
            else
            {
                MessageBox.Show("Doors must be an integer");
                txtDoors.Clear();
                txtDoors.Focus();

            }
            if (decimal.TryParse(txtPrice.Text, out price))
                aCar.Price = price;
            else
            {

                MessageBox.Show("Price must be a decimal");
                txtPrice.Clear();
                txtPrice.Focus();


            }
            Main.cars.Add(aCar);*/

            doors = int.Parse(txtDoors.Text);
            year = int.Parse(txtYear.Text);
            mileage = int.Parse(txtMileage.Text);
            price = decimal.Parse(txtPrice.Text);
            make = txtMake.Text;
            Car someCar = new Car(make, year, mileage, price, doors);
            Main.cars.Add(someCar);

            txtDoors.Clear();
            txtMake.Clear();
            txtMileage.Clear();
            txtPrice.Clear();
            txtYear.Clear();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStartCar_Click(object sender, EventArgs e)
        {
            Car myCar = new Car();
            myCar.StartEngine();
            
            
        }
    }
}
