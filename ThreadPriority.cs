using System;
using System.Threading;




public class Abc
        {
            public void A()
            {
                Console.WriteLine("thread A");
                Console.WriteLine("priority of thread A is:" + Thread.CurrentThread.Priority.ToString());
                Console.WriteLine(" ");
                Thread.Sleep(5000);
                Console.WriteLine("thread with" + Thread.CurrentThread.Priority.ToString() + "has run");
                Console.WriteLine(" ");
            }
            public void B()
            {
                Console.WriteLine("thread B");
                Console.WriteLine("priority of thread B is:" + Thread.CurrentThread.Priority.ToString());
                Console.WriteLine("");
                Thread.Sleep(4000);
                Console.WriteLine("thread with" + Thread.CurrentThread.Priority.ToString() + "has run");
                Console.WriteLine(" ");

            }
            public void C()
            {
                Console.WriteLine("thread C");
                Console.WriteLine("priority of thread C is:" + Thread.CurrentThread.Priority.ToString());
                Console.WriteLine(" ");
                Thread.Sleep(3000);
                Console.WriteLine("thread with" + Thread.CurrentThread.Priority.ToString() + "has run");
                Console.WriteLine(" ");

            }
        }
  class ThreadPriority
        {
            public static System.Threading.ThreadPriority AboveNormal { get; private set; }
            public static System.Threading.ThreadPriority BelowNormal { get; private set; }
            public static System.Threading.ThreadPriority Lowest { get; private set; }

             public static void Main()
            {
                Console.WriteLine("scheduling thread.......");
                Abc A1 = new Abc();
                Thread t1 = new Thread(new ThreadStart(A1.A));
                Thread t2 = new Thread(new ThreadStart(A1.B));
                Thread t3 = new Thread(new ThreadStart(A1.C));
                Console.WriteLine("priority of main method is" + Thread.CurrentThread.Priority.ToString());
                Console.WriteLine(" ");
                t1.Name = "thread A";
                t2.Name = "thread B";
                t3.Name = "thread C";
                t1.Priority = ThreadPriority.AboveNormal;
                t2.Priority = ThreadPriority.BelowNormal;
                t3.Priority = ThreadPriority.Lowest;
                t1.Start();
                t2.Start();
                t3.Start();
                Console.ReadKey();
            }
        }

    

