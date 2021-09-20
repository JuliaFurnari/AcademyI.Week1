using System;
using System.Collections.Generic;

namespace AcademyI.Week1.Pizzeria.Core
{
    public class Pizza
    {
        public string Nome { get; set; }
        public List<string> Ingredienti { get; set; }
        public double Prezzo { get; set; }
    }
}
