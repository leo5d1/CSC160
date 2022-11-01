using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation
{
    internal class ExtensionMethod
    {
        public static void DoIt()
        {
            string strMsg = "Havarti Cheese";

            Console.WriteLine("Size of {0} is {1}", strMsg, strMsg.Length);

            Console.WriteLine("Is '{0}' first letter capitalized? {1}", strMsg, strMsg);
        }
    }
}
