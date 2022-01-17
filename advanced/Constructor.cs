using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Rectangle1
{
    public int length, width;

    public Rectangle1(int x, int y)
    {
        length = x;
        width = y;
    }
    public int RectArea()
    {
        int area = length * width;
        return (area);
    }
}
namespace advanced
{
    class Constructor
    {
        static void Main(string[] args)
        {
            
            Rectangle1 R1 = new Rectangle1(10, 20);
            int area = R1.RectArea();
            Console.WriteLine("Area is = " + area);
            Console.ReadLine();

        }
        }
}
