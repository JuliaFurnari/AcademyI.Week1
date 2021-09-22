using AcademyI.Week1.Pizzeria.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyI.Week1.Pizzaria.RepositoryMock
{
    public class RepositoryPizzeMock : IPizzeRepository
    {


        public static List<Pizza> pizze = new List<Pizza>()
        {
             new Pizza(1,"Margherita", 5),
             new Pizza (2, "Prosciutto e funghi",8),
             new Pizza (3, "Bufalina", 6),
            new Pizza(4, "Tirolese", 7)
        };

        public List<Pizza> Fetch()
        {
            return pizze;
        }

        public List<Pizza> Fetch(List<Ingrediente> ingredienti, List<PizzaIngrediente> pizzeIngredienti)
        {
            var pizze = Fetch();

            var a = from ingrediente in ingredienti
                                             join pizzaIngrediente in pizzeIngredienti on ingrediente.Id equals pizzaIngrediente.IdIngrediente

                                             select new IngredientiWithIdPizza(ingrediente.Id, pizzaIngrediente.IdPizza, ingrediente.Nome);

            var d = (from singleb in a
                     join pizza in pizze on singleb.IdPizza equals pizza.Id
                    select new PizzaWithIngrediente(pizza.Id, pizza.Nome, pizza.Prezzo, singleb.NameIngrediente)).ToList();

            return new List<Pizza>();
        }


        public struct IngredientiWithIdPizza
        {
            public int IdIngrediente { get; set; }
            public int IdPizza { get; set; }
            public string NameIngrediente { get; set; }

            public IngredientiWithIdPizza(int idIngrediente, int idPizza, string nameIngrediente)
            {
                IdIngrediente = idIngrediente;
                IdPizza = idPizza;
                NameIngrediente = nameIngrediente;
            }

        }

        public struct PizzaWithIngrediente
        {
            public int IdPizza { get; set; }
            public string Name { get; set; }
            public double Price { get; set; }
            public string NameIngrediente { get; set; }

            public PizzaWithIngrediente(int idPizza, string name, double price, string nameIngrediente)
            {
                IdPizza = idPizza;
                Name = name;
                Price = price;
                NameIngrediente = nameIngrediente;
            }

        }

    }
}
