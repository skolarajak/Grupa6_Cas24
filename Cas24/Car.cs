using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cas24
{
    class Car
    {
        public string color = "white";
        public int weight = 1267;

        public void Drive()
        {
            Console.WriteLine("Drive!");
        }

        public void Stop()
        {
            Console.WriteLine("Stop!");
        }
    }
}
