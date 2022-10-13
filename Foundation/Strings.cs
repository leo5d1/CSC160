using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation
{
    internal class Strings
    {
        public static void Start()
        {
            // 3 different ways to format strings
            //string strName = Console.ReadLine();
            //Console.WriteLine("V1 - Hello " + strName + "glad to meet you!"); // string concatenation
            //Console.WriteLine("V2 - Hello {0} glad to meet you!", strName); // string interpolation
            //Console.WriteLine($"V3 - Hello {strName} glad to meet you!"); // string injection

            string strRandom = "Neumont College of Computer Science";
            Console.WriteLine("Length: {0}", strRandom.Length);
            Console.WriteLine("Contains 'of': {0}", strRandom.Contains("of"));

            int indexOf = strRandom.IndexOf("of");
            Console.WriteLine("IndexOf position: {0}", indexOf != -1 ? indexOf.ToString() : "Not Found");

            Console.WriteLine("Remove: {0}", strRandom.Remove(indexOf, 3));
            Console.WriteLine(strRandom);

            //StringBuilder
            StringBuilder sb = new StringBuilder();
            //sb.Append();
            //sb.Append();
            //sb.Append();
        }
    }
}