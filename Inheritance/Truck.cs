using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Truck:Automobile
    {
        private int _wheelDrive;
        decimal _price;
        


        public Truck()
        {

            _wheelDrive = 2;


        }

        public int WheelDrive
        {
            get { return _wheelDrive;}
            set {_wheelDrive = value;}


        }
        public override decimal Price
        {
            get {return _price * 1.10M;}
            set {_price = value;}

        }
    }
}
