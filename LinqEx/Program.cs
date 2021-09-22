using System;

namespace LinqEx
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 3;

            int square = Square(num);

            square = Square2(num);

            square = Square3(num);
        }

        private static int Square(int num)
        {
            return num * num;
        }

        private static int Square2(int num) => num * num;

        static Func<int, int> Square3 = num => num * num;
    }
}
