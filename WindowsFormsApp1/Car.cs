using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Car
    {
        public class Fuel
        {
            public int value { get; set; }

            public Fuel(int fuel = 0)
            {
                this.value = fuel;
            }
        }
            
        Fuel fuel = new Fuel();
        public Car()
        {

        }

        public Car(int fuell = 12)
        {
            this.fuel.value = fuell;
        }

        public Car(int fuell = 12, string title = "test")
        {

        }
        private void start()
        {

        }

        private bool start(int fuel = 0)
        {
            this.fuel.value--;

            return false;
        }

        private int start(int fuel = 0, String fuelType = "95")
        {
            return 0;
        }
    }
}
