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
/*This is the read write property
some property is read only : only the get method is there
some property is write only : only the set methode is there,
you can write set then get or get then set .
but on execution is always set then get only.

make class object -> Then obj.Property = value; will call the set 
now do int value = obj.Property; will call the get

Some of them are the static variables.
Then for that field

A class can have the static field with the static property


eg
private static int x;

public static int X{
    get{
        return x;
    }
    set{
        x=value;
    }
}

Value and the reference types depend on the data.
Direct deal with the value : call by the value
Direct deal with the memory adderess : call by the address

keep the value is by value
keep the memory reference of the other variable : we will use the by referemce

value types are implemented through reference type{arrays,collections}
and enums and structs are the type of the value type.

class is always the reference type
local variable in the stack memory
and the new object / reference type is stored in the heap memory

structure is a value type data type
structure is a user defined data type containing all the variables of similar type
or dissimilar type with the security being : all public store in the stack.
while the class has all of its things by default private. it is the reference type

Structure has no inheritance , but the class has the inheritance.
Structure is a single independent unit will not come under the oops.
we can use a structure inside a structure but cannot be inherited.

make the structure when many variables of same time.
The structure does not have the constructor in it.



structure make a single unit that will combine the variables under it.

generic : run time the data type will change

make the structure : then name it the bill details.
we will use the new keyword to make the structure.
Then the reference(object) will be used to set the values
To clear the screen , we will use the Console.Clear()
and use the console.ReadKey(); to hold the screen


*/