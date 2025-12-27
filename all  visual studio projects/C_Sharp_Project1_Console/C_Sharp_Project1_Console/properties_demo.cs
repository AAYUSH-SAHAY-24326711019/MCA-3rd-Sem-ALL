using System;
using System.Collections.Generic;
using System.Text;


/*
 Properties is the Oops technique for encapsulation / abstraction.
 class has properties (private class variables) having accessors (getters)
 and having mutators(setters) both of them remaining public.

Good programming practice to declare the private variable and
the public getter to access the attribute. This will allow
permissible access to the data.

.NET Framework Vs JRE.JVM

inside the class we make the variables / instance variables / properties /fields 
They perform the program lofic and declare with any modifier,

public int poperty_age{
    // it has the get {} //block of code
    // it has the set {} //block of code
//There are no parenthesis
}

 */

namespace C_Sharp_Project1_Console
{
    internal class properties_demo
    {
        private int x, y, z;
        public int X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }

        static void Main()
        {
            properties_demo p = new properties_demo();
            p.X = 20;
            int values = p.X;  
            Console.WriteLine(values);

        }
    }
}
