using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesOperatorsExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Lily";
            Console.WriteLine(name);
            name = "Monty";
            Console.WriteLine(name);

            string birthMonth = "may";
            Console.WriteLine(birthMonth);

            int birthMonthNumber = 5;
            int age = 65;
            int population = 34234444;
            //Floating Type Variables
            float number = 2.164403304897294849383961032f;
            double someNumber = 2.164403304897294849383961032d;
            decimal anotherNum = 2.164403304897294849383961032m;
            Console.WriteLine(number);
            Console.WriteLine(someNumber);
            Console.WriteLine(anotherNum);

            bool isPresent = true;

            char lastLetter = 'x';

            int jessicaAge = 23;
            int samAge = 7;

            Console.WriteLine(jessicaAge < samAge);


        }
    }
}
 