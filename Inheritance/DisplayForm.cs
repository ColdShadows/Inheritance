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
    public partial class DisplayForm : Form
    {
        public DisplayForm()
        {
            InitializeComponent();
        }

        private void DisplayForm_Load(object sender, EventArgs e)
        {
            
            foreach (Car car in Main.cars)
                lstAutomobile.Items.Add(car.Make + "\t" + car.Mileage.ToString() + "\t" + car.ModelYear.ToString() + "\t" + car.Price.ToString());
            foreach (Truck truck in Main.trucks)
                lstTrucks.Items.Add(truck.Make + "\t" + truck.Mileage.ToString() + "\t" + truck.ModelYear.ToString() + "\t" + truck.Price.ToString());
            foreach (SUV suv in Main.suvs)
                lstSUV.Items.Add(suv.Make + "\t" + suv.Mileage.ToString() + "\t" + suv.ModelYear.ToString() + "\t" + suv.Price.ToString());
        
        
        }
    }
}
