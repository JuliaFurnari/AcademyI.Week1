using AcademyI.Week1.Pizzeria.Core;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AcademyI.Week1.Pizzaria.RepositoryMock
{
    public class RepositoryIngredientiMock: IIngredientiRepository
    {
        public static List<Ingrediente> ingredienti = new List<Ingrediente>()
        {
            new Ingrediente(1, "Pomodoro"),
            new Ingrediente(2, "Mozzarella"),
            new Ingrediente(3, "Prosciutto"),
            new Ingrediente(4, "Funghi"),
            new Ingrediente(5, "Bufala"),
            new Ingrediente(6, "Speck")
        };



        public List<Ingrediente> Fetch()
        {
            return ingredienti;
        }


        //public void Add(Ingrediente item)
        //{
        //    if(ingredienti.Count() == 0)
        //    {
        //        item.Id = 1;
        //    }
        //    else
        //    {
        //        var query = from ingrediente in ingredienti
        //                orderby ingrediente.Id descending
        //                select ingrediente.Id;

        //        var id = query.ToList();
        //        item.Id = id[0] + 1;

        //        ingredienti.Add(item);
        //    }
        //}
    }
}
