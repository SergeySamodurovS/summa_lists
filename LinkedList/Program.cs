using System;
using System.Collections.Generic;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> numberOne = new LinkedList<int>();
            LinkedList<int> numberTwo = new LinkedList<int>();
            int inNumber1 = 12345;
            int inNumber2 = 5386;
            int outNumber1 = 0;
            int outNumber2 = 0;
            int summa = 0;

            FillingList(inNumber1, numberOne);
            FillingList(inNumber2, numberTwo);
            
            outNumber1 = ReturningNumber(numberOne);
            outNumber2 = ReturningNumber(numberTwo);
            summa = outNumber1 + outNumber2;
        }

        static void FillingList(int number, LinkedList<int> list)
        {
            while (number >= 1)
            {
                list.AddLast(number % 10);
                number /= 10;
            }
        }

        static int ReturningNumber(LinkedList<int> list)
        {
            int number = 0;
            int count = 0;
            foreach (var item in list)
            {
                number += item * (int)Math.Pow(10, count);
                count++;
            }
            return number;
        }
    }
}
