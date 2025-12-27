using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Project1_Console
{
    internal class program10 
    {
        int val1, val2 = 0;
        public program10(ref int v1,ref int v2) {

            //Console.WriteLine("Give the value 1");
            //val1 = Convert.ToInt16(Console.ReadKey());
            val1 = v1;
            //Console.WriteLine("Give the value 2");
            //val2 = Convert.ToInt16(Console.ReadKey());
            val2 = v2;
            int temp1 = 0;
            temp1 = val1;
            val1 = val2;
            val2 = temp1;
        }
       public void display()
        {
            Console.WriteLine($"Value1 {val1} and Value2 {val2}");
        }
        ~program10()
        {
            String res="Destructor was called";
            Console.WriteLine(res);
        }

        public static void Main10()
        {
            int a = 10, b = 20;
        
            program10 p10 = new program10(ref a,ref b);
            p10.display();
            Console.WriteLine("000");
            //p10.Dispose();
            
        }

       
    }
}


//C++ has destructor and no garbage collector
/* Java has Garbage collector and no destructor
 * C# has both destructor and garbage collector : garbage collector runs the
   automatic way
Destructor will remove the instance of the class from the memory.
Then delete the object , the content deleted from the memory
A class has only one destructor and without the parameters.
Memory occupy and cleanup routine. Not in user control to call the
garbage collector that will later call the destructor.

.NET framework routinely runs the memory checks which it sees the objects
that are released from the memory.

Destructor has a ~ sybol, so the user cannot determine when the destructor be called.
it will inform to .NET Framework GC to clear the object.
We cannot call it explicitly , only .NET Framework will clear it.
only the unrequired memory will released.


 

 
 */