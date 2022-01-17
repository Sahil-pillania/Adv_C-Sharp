using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

class multithread
{
    public void First()
    {
        Console.WriteLine("First method of multithread class is running on T1 thread.");
        Thread.Sleep(1000);
        Console.WriteLine("The first method called by T1 thread has ended");
    }
    public void Second()
    {
        Console.WriteLine("Second method of multithread class is running on T2 thread.");
        Thread.Sleep(1000);
        Console.WriteLine("The Second method called by T2 thread has ended");
    }
}


public class multithreading
{

        static void Main(string[] args)
        {
        Console.WriteLine("Example of Threading");
        multithread a = new multithread();
        Thread T1 = new Thread(new ThreadStart(a.First));
        T1.Start();
        Console.WriteLine("T1 thread started.");
        Thread T2 = new Thread(new ThreadStart(a.Second));
        
        T2.Start();
        Console.WriteLine("T2 thread started.");
        Console.ReadLine();

    }
    }


