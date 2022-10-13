using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation
{
    internal class Arrays
    {
        public static void Commence()
        {
            int[] myArray1 = new int[3]; // integerarray size 3
            // defaults to 0 if nothing is in it, other types usually default to null
            myArray1[0] = 55;
            myArray1[1] = 125;
            myArray1.SetValue(23, 2); // same as: myArray1[2] = 23;

            int[] myArray2 = { 1, 2, 3, 4 }; // short hand - implicitly knows it is an int array
            int[] myArray3 = new int[] { 1, 2, 3, 4 }; // long hand version

            for (int i = 0; i < myArray1.Length; i++)
            {
                Console.Write("{0} ", myArray1[i]);
            }
            Console.WriteLine();
            foreach (int intNum in myArray1)
            {
                Console.Write("{0} ", intNum);
                break; // exits the loop
                continue; // gets out of this iteration int the loop, ignoring the rest of the code in the loop
            }

            Console.WriteLine();
            string[,] alphabet = new string[2, 2] { { "A", "B" }, { "C", "D" } };

            for (int row = 0; row < alphabet.GetLength(0); row++)
            {
                for (int col = 0; col < alphabet.GetLength(1); col++)
                {
                    Console.Write("{0} ", alphabet[row, col]);
                } 
                Console.WriteLine();
            }
            Console.WriteLine();

            object[] myThings = new object[] { 10, "Bob", 10.5f }; // all typpes derive from objects, not possible with var
            foreach (object th in myThings)
            {
                Console.WriteLine("{0} ", th);
            }

        }
    }
}
