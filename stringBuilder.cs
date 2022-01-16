using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advanced
{
    class stringBuilder
    {
        static void Main(string[] args)
        {
            StringBuilder sbstr = new StringBuilder(15);
            sbstr.Append("Hello, Sahil");
            Console.WriteLine(sbstr);
            Console.ReadLine();
        }
    }
}
