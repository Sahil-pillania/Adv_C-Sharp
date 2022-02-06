using System;

using ClassLib ;

namespace advanced
{
    class Assembly
    {
        static void Main(string[] args)
        {
            //Console.Write("hello");
            Class1 one = new Class1();
            string output1 = one.Funone("Hello. This is function one");
            string output2 = one.Funtwo("Hello. This is function two.");
            Console.WriteLine(output1);
            Console.WriteLine(output2);
            Console.ReadKey();


        }
    }
}
