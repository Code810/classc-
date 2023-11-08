using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classc_.models
{
    internal class Factorial
    {
        public int input;
        public Factorial(int num)
        {
            input = num;
        }
        public void Factor()
        { 
        long result = 1;
            if(input > 0)
            {
                for (long i = input; i > 0; i--)
                {
                    result *= i;
                }
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("0 dan boyuk reqem olmalidir");
            }
        }
            
    
    }
}
