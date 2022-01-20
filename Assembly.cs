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
            string output1 = one.Funone("Hello");
            string output2 = one.Funtwo("Hello2");
            Console.WriteLine(output1);
            Console.WriteLine(output2);
            Console.ReadKey();


        }
    }
}
