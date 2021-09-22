using AcademyI.Week1.Pizzaria.RepositoryMock;
using AcademyI.Week1.Pizzeria.Core;
using System;
using System.Collections.Generic;

namespace AcademyI.Week1.Pizzaria.ConsoleAppMain
{
    class Program
    {
        private static readonly IBusinessLayer bl = new BusinessLayer(new RepositoryPizzeMock(), new RepositoryIngredientiMock(), new RepositoryPizzeIngredientiMock());
        static void Main(string[] args)
        { 
            bool continua = true;

            do
            {
                Console.WriteLine("1. Scegli pizze dal menu generale");
                Console.WriteLine("2. Scegli pizze per ingredienti");
                Console.WriteLine("0. Exit");

                int scelta;
                Console.Write("Inserisci scelta: ");
                while (!int.TryParse(Console.ReadLine(), out scelta) || scelta < 0 || scelta > 2)
                {
                    Console.Write("\nScelta errata. Inserisci scelta corretta: ");
                }

                switch (scelta)
                {
                    case 0:
                        continua = false;
                        break;
                    case 1:
                        ChoosePizza();
                        break;
                    case 2:
                        ChoosePizzaByIngrediente();
                        break;

                }

            } while (continua);
        }

        private static void ChoosePizza()
        {
            List<Pizza> pizze = bl.FetchPizze();
            PrintPizze(pizze);
        }
       

        private static void ChoosePizzaByIngrediente()
        {
            List<Ingrediente> ingredienti = bl.FetchIngredienti();
            int scelta;

                PrintIngredienti(ingredienti);
                //scelta = SceltaIngrediente(ingredienti);
            
            
        }

        //private static int SceltaIngrediente(List<Ingrediente> ingredienti)
        //{
        //    //Ingrediente ingrediente;
        //    //do
        //    //{
        //    //    scelta
        //    //    ingrediente = ingredienti.Find(i => i.Id == scelta)
        //    //}while(int.TryParse(Console.ReadLine(), out int scelta))
        //    //return ingrediente;
        //}

        private static void PrintPizze(List<Pizza> pizze)
        {
            foreach (var pizza in pizze)
            {
                Console.WriteLine(pizza.Print());
            }
        }

        private static void PrintIngredienti(List<Ingrediente> ingredienti)
        {
            foreach (var ingrediente in ingredienti)
            {
                //Console.WriteLine($"Premi {ingrediente.Id}per selezionare {ingrediente.Nome});
            }
        }

    }
}
