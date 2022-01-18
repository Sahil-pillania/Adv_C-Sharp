using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Space
{
    int x, y, z;
    public Space(int a, int b, int c)
    {
        x = a;
        y = b;
        z = c;
    }
    public void Display()
    {
        Console.Write(" "+x );
        Console.Write(" " + y);
        Console.Write(" " + z);
        Console.WriteLine();
    }
   /* public static Space operator  - (Space s)
    {
        s.x = -s.x;
        s.y = -s.y;
        s.z = -s.z;
        //return (s.x, s.y, s.z);
    }*/
}
namespace advanced
{
    class operatorOverloadingUnary
    {
        static void Main(string[] args)
        {

            Space s = new Space(10, -40, 50);
            Console.Write("s: ");
            s.Display();

           // -s;

            Console.Write("s: ");
            s.Display();


            Console.ReadKey();

        }
    }
}
