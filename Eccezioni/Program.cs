using System;

namespace Eccezioni
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Example.Divisione();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
