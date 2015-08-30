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
    public partial class displaySUVs : Form
    {
        public displaySUVs()
        {
            InitializeComponent();
        }

        private void displaySUVs_Load(object sender, EventArgs e)
        {
            foreach (SUV suv in Main.suvs)
                lstSUVs.Items.Add(suv.Make + "\t" + suv.Mileage.ToString() + "\t" + suv.ModelYear.ToString() + "\t" + suv.Price.ToString());
        }
    }
}
