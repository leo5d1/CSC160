using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation
{
    internal class Parameters
    {
        public static void DoIt()
        {
            int intRef = 7;
            int[] ary = new int[] { 5, 6 };
            string strByVal = "Fred";
            RefTest clsRT = new RefTest();
            clsRT.x = 1;
            int intValue = 66;
            int[] ary2 = new int[2];
            ary.CopyTo(ary2, 0);

            ByValRefTest(ref intRef, strByVal, ary2, clsRT, intValue);
            //Console.WriteLine("int ByRef: {0}", intRef);
            //Console.WriteLine("string: " + strByVal);
            //Console.WriteLine("ary[0]: {0}", ary[0]);
            //Console.WriteLine("ary2[0]: {0}", ary2[0]);
            //Console.WriteLine("clsRT.x: {0}", clsRT.x);
            //Console.WriteLine("intValue: {0}", intValue);

            //DefaultParam();
            //DefaultParam(50);
            NamedFunction(5, 10);
            NamedFunction(y: 60, x: 5);
        }

        static void NamedFunction(int x, int y)
        {
            Console.WriteLine("Named Param: {0} - {1}", x, y);
        }

        static void DefaultParam(int n = 20)
        {
            Console.WriteLine("Default Param: {0}", n);
        }

        public static void ByValRefTest(ref int xRef, string sVal, int[] ary, RefTest clsRefTest, int intValue)
        {
            xRef = xRef * xRef;
            sVal = "Fanny";
            ary[0] = 10;
            clsRefTest.x = 88;
            int value = 42;
        }

        public class RefTest
        {
            public int x;
        }
    }
}
