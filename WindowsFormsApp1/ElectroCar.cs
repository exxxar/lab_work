using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class ElectroCar:Car
    {
        double voltage;
        public ElectroCar()
        {
       
            
        }

        public void start(double voltage)
        {
            this.start((double)voltage*1000);

           // this.voltage = voltage;
        }
    }
}
