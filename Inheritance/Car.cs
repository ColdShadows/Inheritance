using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inheritance
{
    public class Car : Automobile
    {

        private int _doors;

        public Car() 
        {
            _doors = 2;
            
        }
        public int Doors
        {

            get { return _doors; }
            set { _doors = value; }


        }

        public override string MakeSound()
        {

            return "rrr-rrr-rrr-rrr";

        }

        /*public override void StartEngine()
        {

            MessageBox.Show("rrr-rrr-rrr-rrr");

        }*/
        public Car(string make, int year, int mileage, decimal price, int doors): base(make, year, mileage, price)
        {

            _doors = doors;

        }
    }
    
}
