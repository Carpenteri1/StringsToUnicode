using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsToUnicode
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "Hi!";
            string format = "";

            for (int i = 0; i < input.Length; i++)
                format += string.Format("\\u{0:X4}", (int)input[i]);
            
            Console.Write(format);
            Console.ReadKey();

        }
    }
}
