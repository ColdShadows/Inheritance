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
    public partial class displayTrucks : Form
    {
        public displayTrucks()
        {
            InitializeComponent();
        }

        private void displayTrucks_Load(object sender, EventArgs e)
        {
            foreach (Truck truck in Main.trucks)
                lstTrucks.Items.Add(truck.Make + "\t" + truck.Mileage.ToString() + "\t" + truck.ModelYear.ToString() + "\t" + truck.Price.ToString());
        }
    }
}
