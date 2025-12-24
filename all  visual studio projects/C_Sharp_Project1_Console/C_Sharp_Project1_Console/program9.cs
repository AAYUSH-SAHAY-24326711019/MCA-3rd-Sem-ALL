/*Date 24/12/2025

we can make any member of a class static {methods,variable}\
we will be able tp access it without object or by the 
ClassName.variable / .method.

This is loaded into the memory in the start and exists throughout
the life of the program

Class vairable : attribute : instance variable
has a setter variable and getter method.

setter sets individual values
getter retrieves those values.

function : has local variable , the local variable destroyed when 
the control exits the functions.

every time function called , variable is created then automatically
destroyed. Member variable must retain value until the life cycle
of the program.

Static makes the program level scope and value can be changed.
it will be able to be accessed throughout the program.
we set it as the static

if the variable is static it must be used for static variable.
static variable is used by both static and non static functions.

static class is made in inner class in java
but it is not inside the C#.
For that inner class , only single copy will be created.
Static variable is made inside the heap memory;

we must alwaus give it a constant value.
Static variable is written in independent area inorder to be
initialised it

public class StaticExample{
public static int ivar;
StaticExample(){
    Console.WriteLine("object created");
}
}

class Program{
    static void Main(String[] args){
        staticExample.ivar=1;
        //static variable initialized
        Console.WriteLine(StaticExample.ivar.ToString());
    }
}

Static methods : All the methods except main is the non static.
All the non static method , make the object. then call the method.

if the method is the static , you do not need to call the method 
by the help of the object.

Static variable is only used by the static method.
But static variable will be utilized by both static and non static methods.

Befor creation of object , the static methods will occupy the memory
then the creation of the objects will take place


using system;
public class staticExample{
    public static int i; //integer by default the value is 0

    public void count(){
        i++;
    }// cannot call without making the object.

    public static int display(){
        return i;
    }

}
class staticc{
    static void Main(String[] args){
        StaticExample s = new StaticExample();
        s.count();
        s.count();
        s.count();
        s.count();
        s.count();
        Console.WriteLine("The value of variable is {0}",StaticExample.Display());
        Console.ReadLine();
        return 0;
    }
}

Constructor and Destructor in the C#

predefined value initialisation when the object is created.
in the class there are the instance variable.

many attributes 12-20 attributes.

when object creation , it can be initialised with the default value.
it can be done by a function , but it needs to be called explicitly.
but constructor is a special kind of function having same name as the
Class and it runs. It can also be an overloaded method,

The constructor can also be an overloaded , but it can be of many variations.

When you defocus the object / go out of the context , we want that it 
gets deinitialised with its default value ,we will use the destructor.
The destructor will be called , when object called in the function.
Control exits the functions.

Constructor  call is implicit nature.
Object creation is the explicit by the new keyword.

make the constructor for the class named Calculator

and initialize it and do the sum and the display the 
value.

Types of the constructors in C#

default Constructor : System default and user default constructor
System : even though you dont make the constructor , the compiler runs that on your behalf.
user : parameter less , made by the user is the also the default constructor.

we want that , different values then we will use the parameterised constructor.
Then we will use the copy constructor. Insided the C++.

To make the identical copy of the object.
Java : Clone() and Clonable interface (must read)

Static constructor , it will do the initalisation of the static variables .
it will work before the class even loads into the memory.

Inside being the class and not be called outside ,we have the private constructor









*/