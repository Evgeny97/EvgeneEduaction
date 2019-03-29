using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Trucks : Car
    {

        public Trucks(string marka, string engineCapacity, string speed, int luggageSpace, string currentLoad) : base(marka, engineCapacity, speed, luggageSpace, currentLoad)
        {
        }

        Trucks Lorry = new Trucks()

        public void debag()
        {
        }
    }
}