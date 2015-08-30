using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inheritance
{
    public class SUV :Automobile
    {

        private int _passengers;

        public SUV()
        {

            _passengers = 4;


        }

        public int Passengers
        {
            get { return _passengers; }
            set { _passengers = value; }

        }
        public override void ShowInfo()
        {
            MessageBox.Show("This automobile is a " + this.Make + ", the mileage is " + this.Mileage.ToString() + ", and the price is $" + this.Price.ToString("c") );

        }
    }
}
