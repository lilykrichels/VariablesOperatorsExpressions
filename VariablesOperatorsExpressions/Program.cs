﻿using System;
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

            //In class practeice Problems

            int friends = 4;
            int billEven = 13;
            int total = billEven * friends;
            Console.WriteLine(total);

            int mikeBill = 13;
            int frankBill = 13;
            int daveBill = 13;
            int jimBill = 13;
            Console.WriteLine(mikeBill + frankBill + daveBill + jimBill);

            int sugar = 7;
            int sugarUsed = 2;
            Console.WriteLine(sugar - sugarUsed);
       
            int one = 8;
            int moneyTotal = 40;
            Console.WriteLine(moneyTotal / one);

            float diaper = 3;
            float totalMoney = 14;
            Console.WriteLine(totalMoney / diaper);

            int juliaMiles = 47;
            int previousMiles = 30;
            int pranavMiles = juliaMiles - previousMiles;
            Console.WriteLine(pranavMiles);
           
            int myMoney = 12;
            int perEnvelope = 3;
            int envelopers = myMoney / perEnvelope;
            Console.WriteLine(envelopers);



        }
    }
}
 