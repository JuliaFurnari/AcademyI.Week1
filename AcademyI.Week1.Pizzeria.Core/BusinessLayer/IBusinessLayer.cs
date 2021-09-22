using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyI.Week1.Pizzeria.Core
{
    public interface IBusinessLayer
    {
        List<Pizza> FetchPizze();
        List<Ingrediente> FetchIngredienti();
    }
}
