using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyI.Week1.Generics
{
    static class Example
    {
                                                              // con il where definisco una sottocategoria di tipi riferiti a T
        public static void Swap<T>(ref T first, ref T second) //where T: class
        {
            var tmp = first;
            first = second;
            second = tmp;
        }
    }
}
