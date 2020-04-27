using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFunctions;

namespace Cas24
{
    class Program
    {
        static void Main(string[] args)
        {
            Car mojAuto = new Car();
            Car tvojAuto = new Car();

            tvojAuto.color = "red";

            Console.WriteLine("Boja mog vozila je {0}", mojAuto.color);
            Console.WriteLine("Boja tvog vozila je {0}", tvojAuto.color);

            mojAuto.Drive();
            mojAuto.Stop();

            //Math matematika = new Math();

            List<int> brojevi = new List<int>();
            brojevi.Add(1);
            brojevi.Add(10);

            Console.WriteLine("Suma je {0}", Mathematics.Sum(brojevi));

            Console.ReadKey();

        }
    }
}
