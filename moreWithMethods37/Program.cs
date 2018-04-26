using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moreWithMethods37
{
    class Program
    {
        static void Main(string[] args)
        {
            string enterNum = "Enter a number:";
            Console.WriteLine(enterNum);
            //int input1 = Convert.ToInt32(Console.ReadLine());
            //double input = Convert.ToDouble(Console.ReadLine());
            string input3 = Console.ReadLine();

            //mathOperation math = new mathOperation();
            //Console.WriteLine(math.Multiply(input1));


            //mathOperation math2 = new mathOperation();
            //Console.WriteLine(math2.Multiply(input2, 0));

            mathOperation math3 = new mathOperation();
            Console.WriteLine(math3.Multiply(input3, 0));
            Console.ReadLine();
        }
    }
}
