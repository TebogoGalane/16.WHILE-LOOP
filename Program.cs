using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.WHILE_LOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int index = 0;
            Console.WriteLine("This is the while loop");
            while(index <= 5)
            {
                Console.WriteLine(" the value is " + index);
                index++;
            }
            Console.WriteLine("This is the do while loop");
            int index2 = 0;
            do
            {
                Console.WriteLine("the value is  "  +  index2);
                index2++;

            }
            while (index2 <= 5);

            Console.Read();
        }
    }
}
