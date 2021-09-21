using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eccezioni
{
    static class Example
    {
        public static double Divisione()
        {
            int firstNumber = 10;
            int secondNumber = 0;

            double result = 0;
            try
            {
                result = firstNumber / secondNumber;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            //finally
            //{
            //    result = firstNumber;
            //}

            return result;
        }
    }
}
