using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFunctions
{
    class Mathematics
    {
        public static int Sum(List<int> numbers)
        {
            int r = 0;
            foreach(int number in numbers)
            {
                r = r + number;
            }
            return r;
        }
    }
}
