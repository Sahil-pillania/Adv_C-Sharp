using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Complex
{
    double x;
    double y;
    public Complex()
    {

    }
    public Complex(double real, double imag)
    {
        x = real;
        y = imag;
    }
    public static Complex operator +(Complex c1, Complex c2)
    {
        Complex c3 = new Complex();
        c3.x = c1.x + c2.x;
        c3.y = c1.y + c2.y;
        return (c3);
    }
    public void Display()
    {
        Console.Write(x);
        Console.Write(" +j" + y);
        Console.WriteLine();


    }
}
namespace advanced
{
    class operatorOverloadingBinary
    {
        static void Main(string[] args)
        {
            Complex a, b, c ;
            Complex a1, b1;
            a = new Complex(2.5, 3.5);
            b = new Complex(1.6, 2.7);
            c = a + b;
            c.Display();


            Console.ReadKey();

        }
    }
}
