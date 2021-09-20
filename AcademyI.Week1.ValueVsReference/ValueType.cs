using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyI.Week1.ValueVsReference
{
    static class ValueType
    {
        public static void Example()
        {
            // Tipi semplici

            // Tipi numerici integrali - Default 0

            // con segno

            int _int;      //   da -2.147.483.648 a +2.147.483.647    -> 32 bit
            sbyte _sbyte;  // 8 bit
            short _short;  // 16 bit
            long _long;    // 64 bit
            nint _nint;    // 32 o 64 bit

            // senza segno

            uint _uInt;      // 32 bit  -> Da 0 a 4.294.967.295
            byte _byte;      // 8 bit
            ushort _uShort;  // 16 bit;
            ulong _uLong;    // 64 bit
            nuint _nuInt;    // 32 o 64 bit

            // Tipi numerici con virgola

            float _float;     // 4 byte , 6/9 cifre
            double _double;   // 8 byte ,  15/17 cifre
            decimal _decimal;  // 16 byte ,  28/19 cifre




            // Caratteri  -> Default '\0'
            char _char;

            // Boolean -> false

            bool _bool;



            // Tipi complessi  -> 0 o il primo elemento

            Month _month;     // 0
            Season _season;   //-> Spring 0

            // Struct   -> o il default delle proprietà oppure solo il tipo

            Coords _coords = new Coords();
            Coords2 _coords2 = new Coords2();

            DateTime dt = new DateTime();


            (int, double) _tupla = new(4, 5.6);



            int ilPrimoIntero = 5;
            int ilSecondoIntero = 10;

            // 5                  5
            ilSecondoIntero = ilPrimoIntero;

            ilPrimoIntero = 7;

            // IlSecondoIntero -> 5



            int i = 123;
            object o = i;      // Boxing
            int j = (int)o;    // Unboxing




            //var result = j.CompareTo(5);

            //char c;
            //c.GetType();
            

        }

        enum Month { }
        enum Season
        {
            Spring,
            Summer,
            Autumn,
            Winter
        }

        enum CorsiDiLaurea
        {
            Economia = 5,
            Matematica = 5
        }


        public struct Coords
        {
            public double X { get; set; }
            public double Y { get; set; }

            public void StampaCoordinate()
            {
                Console.WriteLine($"x vale {X} e y vale {Y}");
            }
        }

        public struct Coords2 { }
    }
}

