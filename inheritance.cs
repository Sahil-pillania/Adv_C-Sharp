using System;


class Item
{
    public void Company()   //base class
    {
        Console.WriteLine("This is Company method of base class item.");
    }
}
class Fan : Item   // derived class
{
    public void Model()
    {
        Console.WriteLine("Fan Model : #000145T6");

    }
}
namespace advanced
{
    class Inheritance
    {
        static void Main(string[] args)
        {
            Item item = new Item();
            Fan fan = new Fan();
            item.Company();
            Console.WriteLine("Now we are calling item through derived class");
            fan.Company();
            fan.Model();
        Console.ReadLine();
        }
    }
}
