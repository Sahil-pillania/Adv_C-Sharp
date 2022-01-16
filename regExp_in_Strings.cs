using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace advanced
{
    class regExp_in_Strings
    {
        static void Main(string[] args)
        {
            string doc = "Sahil's number: 0898880022\nSmarty can be " + "found at 0888333566.\nPillania's mobile number: 0887098321";
            string replacedDoc = Regex.Replace(doc, "(08)[0-9]{8}", "$1********");
            Console.WriteLine(replacedDoc);
            Console.ReadLine();
        }
    }
}
