using System;
using System.Collections.Generic;

namespace advanced
{
        class GenericClass
	    {  
        public void Show<T>(T msg)
	        {  
	            Console.WriteLine(msg);  
	        }  
    }  

    class genericMethods
    {
        static void Main(string[] args)
        {
            {
                GenericClass genC = new GenericClass();
                genC.Show("This is generic method");
                genC.Show(101);
                genC.Show('I');
                Console.ReadLine();
            }

        }
    }
}
