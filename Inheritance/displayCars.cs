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
    public partial class displayCars : Form
    {
        public displayCars()
        {
            InitializeComponent();
        }

        private void displayCars_Load(object sender, EventArgs e)
        {
            foreach (Car car in Main.cars)
                lstCars.Items.Add(car.Make + "\t" + car.Mileage.ToString() + "\t" + car.ModelYear.ToString() + "\t" + car.Price.ToString());
        }
    }
}
