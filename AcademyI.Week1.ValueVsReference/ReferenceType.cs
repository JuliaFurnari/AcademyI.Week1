using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyI.Week1.ValueVsReference
{
    static class ReferenceType
    {
        public static void Example()
        {
            Object _object;

            string _string;
            _string = null;          // -> null
            _string = String.Empty;  // -> ""


            int[] _array;
            int[][] _matrix;

            _array = new int[5];    // -> contiene 5 elementi
            _array = new int[] { 1, 4, 7 };

           // _array = { 1,2,3,4,5,6};

            int[] _array2 = { 1, 2, 3, 4, 5, 67 };


            IInterfaceExample _interface;

            ClassExample classExample;

            ClassExample primaClasse = new ClassExample();
            primaClasse.Nome = "Arianna";

            ClassExample secondaClasse = new ClassExample();
            secondaClasse.Nome = "Alessandra";

            secondaClasse = primaClasse;   // -> secondaClasse.Nome = "Arianna" , primaClasse.Nome = "Arianna"

            primaClasse.Nome = "Renata"; // -> secondaClasse.Nome = "Renata" , primaClasse.Nome = "Renata"


            // Attenzione alle stringhe


            string salutoInglese = "Hello!";
            string salutoItaliano = "Ciao!";

            salutoInglese = salutoItaliano;   //-> salutoInglese = "Ciao!" salutoItaliano = "Ciao!"

            salutoItaliano = "Buongiorno!";   //-> salutoInglese = "Ciao!" salutoItaliano = "Buongiorno!"


        }
    }

    public interface IInterfaceExample { }

    public class ClassExample
    {
        public string  Nome { get; set; }
    }
}
