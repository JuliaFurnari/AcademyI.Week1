using AcademyI.Week1.Pizzeria.Core.InterfaceRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyI.Week1.Pizzeria.Core
{
    public interface IPizzeRepository : IRepository<Pizza>
    {
        public List<Pizza> Fetch(List<Ingrediente> ingredienti, List<PizzaIngrediente> pizzeIngredienti);
    }
}
