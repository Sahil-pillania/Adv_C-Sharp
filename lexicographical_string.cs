using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advanced
{
    class lexicographical_string
    {
        static void Main(string[] args)
        {
            string score = "sCore";
            string scary = "scary";
            Console.WriteLine(score.CompareTo(scary));
            Console.WriteLine(scary.CompareTo(score));
            Console.WriteLine(scary.CompareTo(scary));

            Console.WriteLine("lexicographical string with ignore case.");

            string alpha = "alpha";
            string score1 = "sCorE";
            string score2 = "score";
            Console.WriteLine(string.Compare(alpha, score1, false));
            Console.WriteLine(string.Compare(score1, score2, false));
            Console.WriteLine(string.Compare(score1, score2, true));
            Console.WriteLine(string.Compare(score1, score2, StringComparison.CurrentCultureIgnoreCase));

            
            Console.ReadLine();
        }
    }
}
