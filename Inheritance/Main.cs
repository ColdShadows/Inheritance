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
    public partial class Main : Form
    {
        public static List<Car> cars = new List<Car>();
        public static List<Truck> trucks = new List<Truck>();
        public static List<SUV> suvs = new List<SUV>();
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CarForm newCars = new CarForm();
            newCars.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DisplayForm display = new DisplayForm();
            display.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TruckForm truck = new TruckForm();
            truck.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SUVForm suv = new SUVForm();
            suv.ShowDialog();
        }

        private void btnAnyCar_Click(object sender, EventArgs e)
        {
            Automobile myAuto = new Automobile();
            Automobile myOtherAuto = new Car();
            Automobile myOtherAutoT = new Truck();
            Automobile myOtherAutoS = new SUV();

            myAuto.Price = 100M;
            myAuto.Mileage = 10;
            myAuto.StartEngine();

            myOtherAutoS.Make = "New SUV!";
            myOtherAutoS.Mileage = 12;
            myOtherAutoS.Price = 22000M;
            myOtherAutoS.StartEngine();
            myOtherAutoS.ShowInfo();


            myOtherAuto.StartEngine();
            myOtherAutoT.Price = 100000M;
            myOtherAutoT.Mileage = 10;
            myAuto.ShowInfo();
            myOtherAutoT.ShowInfo();

            //tryStartingAgain(myAuto);
            //tryStartingAgain(myOtherAuto);


            //Car coolCar = (Car) new Automobile();
            //MessageBox.Show("Test: " + myOtherAuto.Doors);
            //Cannot access
        }
        private void tryStartingAgain(Automobile auto)
        {
            auto.StartEngine();
            
        }

        private void btndisplayCars_Click(object sender, EventArgs e)
        {
            displayCars dc = new displayCars();
            dc.ShowDialog();
        }

        private void btndisplayTrucks_Click(object sender, EventArgs e)
        {
            displayTrucks dt = new displayTrucks();
            dt.ShowDialog();
        }

        private void btnDisplaySUVs_Click(object sender, EventArgs e)
        {
            displaySUVs ds = new displaySUVs();
            ds.ShowDialog();

        }
    }
}
