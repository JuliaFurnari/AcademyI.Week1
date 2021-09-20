using System;

namespace AcademyI.Week1.Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = 1;
            int second = 2;

            Console.WriteLine($"Primo: {first} - Secondo: {second}");

            Example.Swap(ref first, ref second);

            Console.WriteLine($"Primo: {first} - Secondo: {second}");


            Console.WriteLine("-------------");

            string firstString = "Ciao";
            string secondString = "Come va?";

            Console.WriteLine($"Primo: {firstString} - Secondo: {secondString}");

            Example.Swap(ref firstString, ref secondString);

            Console.WriteLine($"Primo: {firstString} - Secondo: {secondString}");

            Console.WriteLine("-------------");

            object obj = 1;
            object obj2 = "Ciao";

            Console.WriteLine($"Primo: {obj} - Secondo: {obj2}");

            Example.Swap(ref obj, ref obj2);

            Console.WriteLine($"Primo: {obj} - Secondo: {obj2}");


        }
    }
}
