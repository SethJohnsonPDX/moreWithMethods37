using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moreWithMethods37
{
    class mathOperation
    {
        public int Multiply(int i)
        {
            return i * 4;
        }

        public int Multiply(double j, int i)
        {
            i = Convert.ToInt32(j) * 8;
            return i;
        }

        public int Multiply(string k, int i)
        {
            i = int.Parse(k) * 2;
            return i;
        }
    }
}
