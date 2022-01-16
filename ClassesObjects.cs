using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Rectangle
{
    public int length, width;

    public void GetData(int x, int y)
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
    class ClassesObjects
    {
        static void Main(string[] args)
        {
            int area1, area2;
            Rectangle R1 = new Rectangle();
            Rectangle R2 = new Rectangle();

            R1.length = 20;
            R1.width = 30;
            area1 = R1.length * R1.width;

            R2.length = 20;
            R2.width = 30;
            area2 = R2.length * R2.width;

            Console.WriteLine("Area1 is = " + area1);
            Console.WriteLine("Area2 is = " + area2);
            Console.ReadLine();
        }
    }
}
