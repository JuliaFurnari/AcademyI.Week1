using AcademyI.Week1.Pizzeria.Core;
using System;

namespace AcademyI.Week1.Pizzeria.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Stampare le pizze
            PrintPizze();

            //Chiedere all'utente quali pizze vuole

            // Stampare lo scontrino
        }

        private static void PrintPizze()
        {
            BusinessLayer bl = new BusinessLayer();
            bl.GetPizze();
        }
    }
}
