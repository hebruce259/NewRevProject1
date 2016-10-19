using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectA
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                //User will be prompted to enter a number here.
                Console.WriteLine("Hello Please enter a number:");

                int input = int.Parse(Console.ReadLine());
                int backwardsnum = 0;
                /*After user input for any number greater than zero reverse the number by 
                performing calculations below.*/
                while (input > 0)
                {

                    int rem = input % 10;
                    backwardsnum = (backwardsnum * 10) + rem;
                    input = input / 10;

                }
                //Finally print results on screen.
                Console.WriteLine("Result: {0}", backwardsnum);


                Console.ReadKey();
            }

        }
    }
}
