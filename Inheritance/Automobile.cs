using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inheritance
{
    public class Automobile
    {


        private string _make;
        private int _modelYear;
        private int _mileage;
        private decimal _price;

        public Automobile()
        {




        }
        public string Make
        {

            get { return _make; }
            set { _make = value; }

             

        }
        public int ModelYear
        {

            get { return _modelYear; }
            set { _modelYear = value; }



        }
        public int Mileage
        {
            get { return _mileage; }
            set { _mileage = value; }

        }
        /*public decimal Price
        {

            get { return _price; }
            set { _price = value; }


        }*/
        public virtual string MakeSound()
        {

            return "Vroom!";


        }
        public  void StartEngine()
        {
            MessageBox.Show(this.MakeSound());


        }
        public virtual decimal Price
        {

            get { return _price; }
            set { _price = value; }

        }
        public virtual void ShowInfo()
        {
            MessageBox.Show("mileage " + this.Mileage.ToString() + ", price " + this.Price.ToString("c"));

        }

        /*public virtual void StartEngine()
        {
            MessageBox.Show("Vroom");


        }*/
        public Automobile(string make, int year, int mileage, decimal price)
        {
            _make = make;
            _modelYear = year;
            _mileage = mileage;
            _price = price;




        }
    }
}
