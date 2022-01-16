using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advanced
{
    class stringOperations
    {
        static void Main(string[] args)
        {
            // Comparison for equality
            string word1 = "C#";
            string word2 = "c#";
            Console.WriteLine("Comparison for equality");
            Console.WriteLine(word1.Equals("C#"));
            Console.WriteLine(word1.Equals(word2));
            Console.WriteLine(word1 == "C#");
            Console.WriteLine(word1 == word2);

            Console.WriteLine("lexicographical string with ignore case.");

            string alpha = "alpha";
            string score1 = "sCorE";
            string score2 = "score";
            Console.WriteLine(string.Compare(alpha, score1, false));
            Console.WriteLine(string.Compare(score1, score2, false));
            Console.WriteLine(string.Compare(score1, score2, true));
            Console.WriteLine(string.Compare(score1, score2, StringComparison.CurrentCultureIgnoreCase));

            Console.WriteLine("The == and != Operators");
            string hel = "Hel";
            string hello = "Hello";
            string copy = hel + "lo";
            Console.WriteLine(copy == hello);

            Console.WriteLine("Concatination in strings");
            string greet = "Hello, ";
            string name = "Sahil!";
            string result = string.Concat(greet, name);

            Console.WriteLine("Casing in strings ");
            string pass1 = "PasswoRd";
            string pass2 = "PaSSwoRD"; 
            Console.WriteLine(pass1.ToUpper() == "PASSWORD");
            Console.WriteLine(pass2.ToUpper() == "PASSWORD");

            string text = "All Kind OF LeTTeRs";
            Console.WriteLine(text.ToLower());

            Console.WriteLine("Searching in strings ");
            string book = "My name is Sahil Pillania";
            int index = book.IndexOf("Sahil");
            Console.WriteLine(index);



            Console.ReadLine();
        }
    }
}
