using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation
{
    internal class DataTypes
    {
        public static void Execute()
        {
            short shtNum = 32767; // 16 bits
            int intNum = 10; // 32 bits
            uint uintNum = 50; // 32 bits ( only positive )
            long lngNum = 9999; // 64 bits
            float fltNum = 10.5f; // 4 bytes
            double dblum = 500.4; // 8 bytes
            decimal decNum = 602.25M; // 16 bytes

            Console.WriteLine("short min: {0}", short.MinValue);
            Console.WriteLine("short max: {0}", short.MaxValue);
            Console.WriteLine();

            Console.WriteLine("int min: {0}", int.MinValue);
            Console.WriteLine("int max: {0}", int.MaxValue);
            Console.WriteLine();

            Console.WriteLine("uint min: {0}", uint.MinValue);
            Console.WriteLine("uint max: {0}", uint.MaxValue);
            Console.WriteLine();

            Console.WriteLine("long min: {0}", long.MinValue);
            Console.WriteLine("long max: {0}", long.MaxValue);
            Console.WriteLine();

            Console.WriteLine("float min: {0}", float.MinValue);
            Console.WriteLine("float max: {0}", float.MaxValue);
            Console.WriteLine();

            Console.WriteLine("double min: {0}", double.MinValue);
            Console.WriteLine("double max: {0}", double.MaxValue);
            Console.WriteLine();

            Console.WriteLine("decimal min: {0}", decimal.MinValue);
            Console.WriteLine("decimal max: {0}", decimal.MaxValue);
            Console.WriteLine();

            char c = '8';
            Console.WriteLine("Char is: {0}", c);
            Console.WriteLine("IsDigit: {0}", char.IsDigit(c));
            Console.WriteLine("IsLetter: {0}", char.IsLetter(c));
            Console.WriteLine();

            string str = "Stuff";
        }
    }
}
