using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyI.Week1.MetodiEstensione
{
    static class Example
    {
        public static int Age(this DateTime birthDate)
        {
            var today = DateTime.Now;

            var age = today.Year - birthDate.Year;   // 2021 - 1991 = 30

            // 22 settembre 1991 > 21 settembre (2021 - 30) 1991
            if (birthDate > today.AddYears(-age))
                age--;

            return age;
        }
    }
}
