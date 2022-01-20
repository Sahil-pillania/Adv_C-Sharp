using System;
using System.Collections.Generic;


namespace advanced2
{
    class space
    {
        int x, y, z;
        public space(int a, int b, int c)
        {
            x = a;
            y = b;
            z = c;
        }
        public void display()
        {
            Console.WriteLine(" " + x);
            Console.WriteLine(" " + y);
            Console.WriteLine(" " + z);
            Console.WriteLine();
        }
        public static space operator -(space s)
        {
            s.x = -s.x;
            s.y = -s.y;
            s.z = -s.z;
            return s;
        }
    }
    internal class Program
    {
        public static void Main()
        {
            space s = new space(10, 20, 30);
            Console.WriteLine("s : ");
            s.display();
            s = -s;
            s.display();
            Console.ReadKey();

        }
    }
}
