using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classc_.models
{
    internal class Caculate
    {
        public int num1;
        public int num2;
        public string prosses;

        public Caculate(int num1,int num2,string prosses)
        {
           this.num1= num1;
            this.num2= num2;
            this.prosses = prosses; 
        }

        public void StartProsses()
        {
            string result = prosses == "+" ? $"{num1 + num2}" :
            prosses == "-" ? $"{num1 - num2}" :
            prosses == "*" ? $"{num1 * num2}" :
            prosses == "/" ? $"{num1 / num2}" :"Duzgun daxil edin";
            Console.WriteLine($"Cavab:{result}");
        }
    }
}
