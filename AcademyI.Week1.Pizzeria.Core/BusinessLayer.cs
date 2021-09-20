using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyI.Week1.Pizzeria.Core
{
    public class BusinessLayer
    {
        public List<Pizza> GetPizze()
        {
            const string path = @"C:\Users\arian\Desktop\AcademyI.Week1\Menu.txt";

            string menu = string.Empty;

            using (StreamReader sr = new StreamReader(path))
            {
                menu = sr.ReadToEnd();
            }

            var righe = menu.Split("\r\n");

            List<Pizza> pizze = new List<Pizza>();

            foreach(var riga in righe)
            {
                var pizzaArray = riga.Split("-");

                Pizza pizza = new Pizza();
                pizza.Nome = pizzaArray[0].Trim();
                pizza.Nome = pizzaArray[2].Trim();
                List<string> ingredienti = new List<string>();
                var ingredientiArray = pizzaArray[1].Split(",");
                foreach(var ingrediente in ingredientiArray)
                {
                    ingredienti.Add(ingrediente.Trim());
                }
                pizza.Ingredienti = ingredienti;

                pizze.Add(pizza);
            }

            return pizze;
        }
    }
}
