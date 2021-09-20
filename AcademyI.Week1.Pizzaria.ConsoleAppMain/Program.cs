using AcademyI.Week1.Pizzeria.Core;
using System;
using System.Collections.Generic;

namespace AcademyI.Week1.Pizzaria.ConsoleAppMain
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
            List<Pizza> pizze = bl.GetPizze();


        }

    }
}
