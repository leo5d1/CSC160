using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation
{
    internal class Converting
    {
        public static void DoIt()
        {
            // Casting and Converting

            // Implicit Conversion
            int intNum = 40751;
            long lngBigNum = intNum;
            var c = 'C';
            Console.WriteLine("var type: {0}", c.GetType());

            // Explicit Conversion
            // if a conversion cannot be made without risk of losing information, the compiler requires
            // you perform an explicit conversion, otherwise known as a "cast"
            // the cast tells the compiler that you are aware of the riskwhen converting, that it migjt fail at runtime
            double d = 1234.7;
            int i;
            i = (int)d;
            Console.WriteLine(i);

            //int intWasString = "5";
            string strNum = "5";
            int intResult = 0;
            intResult = int.Parse(strNum);
            Console.WriteLine("Parse: {0} {1}", intResult, intResult.GetType());
            bool bSuccess = int.TryParse(strNum, out intResult);
            Console.WriteLine(strNum + " converts to int? " + bSuccess);

            Console.WriteLine(IsNumeric("Pikachu"));
        }

        public static bool IsNumeric(string strNumber)
        {
            double dblIsNumber;
            return double.TryParse(strNumber, out dblIsNumber);
        }
    }
}
