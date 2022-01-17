using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advanced
{
    class strings
    {
        static void Main(string[] args)
        {
            string message = "This is a simple string message.";
            Console.WriteLine("message = {0}", message);
            Console.WriteLine("message.Length = {0}", message.Length);
            for (int i = 0; i < message.Length; i++)
            {
                Console.WriteLine("message[{0}] = {1}", i, message[i]);
            }
            
            
            // Console output:
            // message = This is a simple string message.
            // message.Length = 31 
            // message[0] = T 
            // message[1] = h
            // message[2] = i 
            // message[3] = s
            // ....
            Console.ReadLine();

        }
    }
}
