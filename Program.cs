using Day_13_Generics;
using System;
using System.Collections.Generic;

namespace GenericsProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***UC5***");
            int[] intArray = { 11, 342, 102, 55, 68 };
            GenericMaximum<int> generic = new GenericMaximum<int>(intArray);

            //generic.MaxMethod();
            generic.PrintMaxValue();

            double[] doubleArray = { 1.2, 34.4, 44.36, 51.55, 67.78 };
            GenericMaximum<double> genericDouble = new GenericMaximum<double>(doubleArray);
            //generic.MaxMethod();
            genericDouble.PrintMaxValue();

            string[] stringArray = { "apple", "mango", "grapes", "banana", "pineapple" };
            GenericMaximum<string> genericString = new GenericMaximum<string>(stringArray);
            genericString.PrintMaxValue();

            Console.ReadLine();



        }
    }
}