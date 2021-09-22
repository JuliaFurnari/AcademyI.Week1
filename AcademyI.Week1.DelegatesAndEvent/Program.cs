using System;
using System.Linq;

namespace AcademyI.Week1.DelegatesAndEvent
{
    class Program
    {
        public delegate string Reverse(string stringa);

        static void Main(string[] args)
        {
            Example.EsempioEventi();


            //string nuovaStringa = ReverseString2("Pippo");
            Reverse rev = ReverseString2;

            var nuovaStringa1 = rev("Pippo");
            var nuovaStringa2 = rev("Pippo");
            var nuovaStringa3 = rev("Pippo");
            var nuovaStringa4 = rev("Pippo");
            var nuovaStringa5 = rev("Pippo");
            var nuovaStringa6 = rev("Pippo");
            //string nuovaStringa2 = ReverseString2("Pippo");
            //string nuovaStringa3 = ReverseString2("Pippo");
            //string nuovaStringa4 = ReverseString2("Pippo");
            //string nuovaStringa5 = ReverseString2("Pippo");

        }

        static string ReverseString(string stringa)
        {
            var nuovaStringa = new string(stringa.Reverse().ToArray());
            return nuovaStringa;
        }

        static string ReverseString2(string stringa)
        {
            var nuovaStringa = new string(stringa.Reverse().ToArray());
            return nuovaStringa;
        }
    }
}
