using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyI.Week1.Pizzeria.Core
{
    public class BusinessLayer: IBusinessLayer
    {
        private readonly IPizzeRepository pizzeRepo;
        private readonly IIngredientiRepository ingredientiRepo;
        private readonly IPizzeIngredientiRepository pizzeIngredientiRepo;

        public BusinessLayer(IPizzeRepository pizze, IIngredientiRepository ingredienti, IPizzeIngredientiRepository pizzeIngredienti)
        {
            pizzeRepo = pizze;
            ingredientiRepo = ingredienti;
            pizzeIngredientiRepo = pizzeIngredienti;
        }

        public List<Ingrediente> FetchIngredienti()
        {
            return ingredientiRepo.Fetch();
        }

        public List<Pizza> FetchPizze()
        {
            #region MenuDaFile

            //const string path = @"C:\Users\arian\Desktop\AcademyI.Week1\Menu.txt";

            //string menu = string.Empty;

            //using (StreamReader sr = new StreamReader(path))
            //{
            //    menu = sr.ReadToEnd();
            //}

            //// Margherita 0
            //// pomodoro, mozzarella 1
            //// 5 2

            //// Vegetariana - pomodoro, mozzarella, zucchine, peperoni - 7
            //// Bufalina - pomodoro, mozzarella di bufala - 6"


            //var righe = menu.Split("\r\n");

            //List<Pizza> pizze = new List<Pizza>();

            //foreach (var riga in righe)
            //{
            //    var pizzaArray = riga.Split("-");

            //    Pizza pizza = new Pizza();
            //    pizza.Nome = pizzaArray[0].Trim();
            //    pizza.Prezzo = Convert.ToDouble(pizzaArray[2].Trim());
            //    List<string> ingredienti = new List<string>();
            //    var ingredientiArray = pizzaArray[1].Split(",");
            //    foreach (var ingrediente in ingredientiArray)
            //    {
            //        ingredienti.Add(ingrediente.Trim());
            //    }
            //    pizza.Ingredienti = ingredienti;

            //    pizze.Add(pizza);
            //}

            //return pizze;

            #endregion

            var ingredienti = ingredientiRepo.Fetch();
            var pizzeIngredienti = pizzeIngredientiRepo.Fetch();
            return pizzeRepo.Fetch(ingredienti, pizzeIngredienti);
        }
    }
}
