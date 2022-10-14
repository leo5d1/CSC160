using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
                //Console.Write("{0} ", myArray1[i]);
            }
            //Console.WriteLine();
            foreach (int intNum in myArray1)
            {
                //Console.Write("{0} ", intNum);
                break; // exits the loop
                continue; // gets out of this iteration int the loop, ignoring the rest of the code in the loop
            }

            //Console.WriteLine();
            string[,] alphabet = new string[2, 2] { { "A", "B" }, { "C", "D" } };

            for (int row = 0; row < alphabet.GetLength(0); row++)
            {
                for (int col = 0; col < alphabet.GetLength(1); col++)
                {
                    //Console.Write("{0} ", alphabet[row, col]);
                } 
                //Console.WriteLine();
            }
            //Console.WriteLine();

            object[] myThings = new object[] { 10, "Bob", 10.5f }; // all typpes derive from objects, not possible with var

            //---------------------------------------\\
            int[] aryNums = { 5, 1, 7, 3, 2, 9, 6 };

            //WriteArray(aryNums);
            //WriteArray(aryNums[..3]);
            //WriteArray(aryNums[1..4]);
            //WriteArray(aryNums[4..]);

            //Array.Reverse(aryNums);
            //WriteArray(aryNums);
            //Array.Sort(aryNums);
            //WriteArray(aryNums);

            //Console.WriteLine("Find index of 2: {0}", Array.IndexOf(aryNums, 2));

            // takes in a method/function that returns a boool (predicate)
            // Array.FindAll finds all true instances
            //Console.WriteLine("All numbers less than 4: ");
            //WriteArray(Array.FindAll(aryNums, LessThanFour));

            // Jaggrd Array
            // could define row, but columns could be varying sizes
            int[][] jagged = new int[3][];
            jagged[0] = new int[] { 1, 2, 3, 4 };
            jagged[1] = new int[] { 5, 6, 7 };
            jagged[2] = new int[] { 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };



        }

        static bool LessThanFour(int value)
        {
            return value < 4;
        }


        static void WriteArray(int[] values)
        {
            //for (int i = 0; i < values.Length; i++)
            //{
            //    Console.Write("{0} ", values[i]);
            //}
            //Console.WriteLine();

            Console.WriteLine(String.Join(", ", values));
        }

    }
}
