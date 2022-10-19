using System;

namespace ConsoleLibrary
{
    public static class IO
    {
        /// <summary>
        /// Can a string be converted to a number
        /// </summary>
        /// <param name="strNumber"></param>
        /// <returns>Tru if a valid number</returns>
        public static bool IsNumeric(string strNumber)
        {
            double dblIsNumber;
            return double.TryParse(strNumber, out dblIsNumber);
        }

        public static void Print(string strToPrint)
        {
            Console.WriteLine(strToPrint);
        }

        public static int GetConsoleInt(string strMsg, int min, int max)
        {
            bool bSuccess = false;
            int intTypedValue;
            do
            {
                Print(strMsg);

                //attempt to parse the string as an integer
                bSuccess = int.TryParse(Console.ReadLine(), out intTypedValue);
                bSuccess = bSuccess && intTypedValue >= min && intTypedValue <= max;

                if(!bSuccess)
                {
                    Console.WriteLine("You entered an invalid value. " + "Must be between {0} and {1} and be a valid integer.", min, max);
                }

            } while (!bSuccess);

            return intTypedValue;
        }

        public static float GetConsoleFloat(string strMsg, float min, float max)
        {
            bool bSuccess = false;
            float fltTypedValue;
            do
            {
                Print(strMsg);

                //attempt to parse the string as a float
                bSuccess = float.TryParse(Console.ReadLine(), out fltTypedValue);
                bSuccess = bSuccess && fltTypedValue >= min && fltTypedValue <= max;

                if (!bSuccess)
                {
                    Console.WriteLine("You entered an invalid value. " + "Must be between {0} and {1} and be a valid integer.", min, max);
                }

            } while (!bSuccess);

            return fltTypedValue;
        }

        public static bool GetConsoleBool(string strMsg)
        {
            bool bSuccess = false;
          
            Print(strMsg);

            //attempt to parse the string as a bool
            bool.TryParse(Console.ReadLine(), out bSuccess);

            return bSuccess;
        }

        public static char GetConsoleChar(string strMsg)
        {
            bool bSuccess = false;
            char chTypedValue;
            do
            {
                Print(strMsg);

                //attempt to parse the string as a float
                bSuccess = char.TryParse(Console.ReadLine(), out chTypedValue);

                if (!bSuccess)
                {
                    Console.WriteLine("You entered an invalid value. Must be a single character.");
                }

            } while (!bSuccess);

            return chTypedValue;
        }

        public static string GetConsoleString(string strMsg)
        {
            string strTypedValue;
            bool bSuccess;

            Print(strMsg);

            return strTypedValue = Console.ReadLine();
        }

        public static int GetConsoleMenu(string[] items)
        {
            for(int i = 0; i < items.Length; i++)
            {
                Console.WriteLine("{0} - {1}", i + 1, items[i]);
            }

            return GetConsoleInt("Selection: ", 1, items.Length);
        }
    }
}