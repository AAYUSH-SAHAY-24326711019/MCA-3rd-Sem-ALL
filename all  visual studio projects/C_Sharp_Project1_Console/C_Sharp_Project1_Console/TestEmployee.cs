using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Project1_Console
{
    public class TestEmployee
    {
        public static void runMain(String[] args)
        {
            Employee emp = new Employee(1, "AayushSahay", "Programmer", "IT", "Patna", 20000.00d);
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(emp[i]);
            }

            //Change the name 
            emp[2] = "Aayush-Sahay";
            Console.WriteLine("\n--------------------------\n");
            //print again
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(emp[i]);
            }
        }
    }
}

/*Differences between the indexer and the properties:
 
 We use the attributes / properties in both.
They will use the both setter and the getter.
in this front they look similar.

Indexer has no name like property has X and x
we will use the this keyword in the indexer.
They are identify by their index like int index or String parameter name
Property is known by name

Indexer is accessed by the array like on basis of index and the String parameter name
property has the set and get .

indexer cannot be static and the property can be static

property : get accessor has no parameter
indexer uses the same parameter list as that of the indexer

property uses the implicit 'value ' variable that inturn will change the value in
the variable.

syntax :
            public object this[int index]

in the indexer the get will need to be type casted.
The property uses the pair of parenthesis.


Date : 02/01/2026

Collections in C#

Array constraint is the datatype (All values of same data type be saved).
Array size is fixed. On max index , its size does not grow.

Java uses the collection
else : make array. if size 10 , check number of data , size and no. of inputs are 
compared. programmatic way , double the size of the array and make the new array.
and index by index do the copy. Then new array must be reference by the old array else
Garbage collector be remove it.

It must occur runtime and dynamically.

This was solution of the size fixed.

For Collections in C# , each collection best 2 features solves the problem of
array. Any Datatype . Collection is a container of objects. Collection object stores
objects of the other data type , eg . int / float / String/ bool.

if enter 10 -> make the object of integers , store the value and keep in container.
it can keep the hetrogeneous values.

In generics , runtime specific groups of datatype of objects be stored by container object.
ensures that same type of datatype objects be stored.

array at the time of declaration:do the sorting on the array.
string[5] employees;
employess = new String[5];

you have to manually add the values and then do the sorting of the array.
To store data in sorted array.
implement the logic of shifting of the early stored object.
cannot leave empty / do the reshuffling.

User will be free if uses the Collection as these features are provided.
The preceeding problem can be avoided by using the Collection.

1st demerits of array then benefits of Collection.
it has a lot of code of the it to wrap the data. These have classes
which have the methods that do the logic of manipulation.

array : user will do it by self.
Size of the collection will expand as per the requirement.
Arraylist has 4 elements in C# but java has 10 elements by default.
4elements insert by default. On 5 the element it will do its size 8
(double).

All collections classes are present in the namespace 
System.Collectiions; if you are going to use it.

Collection : Ada,.25,Manager,Sales
Array stores the elements as data , but the Collection , all elements
are the type of the objects.

The value is automatically converted in the object.
If we want to retrive the value from the collection to the normal variable
Here is unpacking / unboxing.

num->to->object (boxing)
object to ->num/ variable (unboxing)

The variable must be of the same value data typed as that of the object.
That is done by the Strongly typed Collection known as the <Generics>
This conflict can be resolved

ArrayList : ordered collection , use wihen object access by the index.
It is the advanced , flexible model of the Array. It is the best alternative.

Shifting in array is done manually, but the arraylist does it internally
without the involvement of the user

Queue uses the first in and first out.
Hold the elements that are discarded as they are used.

Stack : mathematical model uses the stack .LIFO manner

Hash table stores the value as key:value pairs.

The array List :

array content is accessed by the index number.
To resize the array you will need a new array.

all the methods related to the arraylist
To add the elements between the array.

There are the methods:

Add(){add at end}, Remove(), Clear(){remove all the elements at once , use the 
same container for new purpose },Insert(){add at the index}
Sort() , Reverse(); list.Count (returns the current number of objects(int))
list.Capacity(returns the total objects in collections.)

IEnumerable is in a list interface
contains the elements inside a list traversal methods.
Generics will enforce /restrict the collection to hold the specific
type of values.

Implements Collection as the without the typechecking / typecasting

we can put any data type , reason : that all the datatype classes
have the parent as the Object class. It only looks for the Object 
type.
Collections will contradict the typesafety as the prime feature of C#
as a type safe language.


We want to implement the specific type checking / type safety.



p s v PrintValues(IEnumerable myList){
foreach(Object obj in myList){
    Console.WriteLine("{0}\t",obj);
}
}

You get the significant performace overhead to store the 
different data type : typecast then retrive from IEnumeration

to address the type safety issue , we will use the generics to
create the classes and methods that hold the reference as well
as the value types.

There is a sub namespace

Generics : Concept of Type parameter , make the object / methods

public class classData<T> // T is template , and can be written by 
//any data types 
{private T data;
public T value{
    get{return this.data;}
    set{this.data=data;}
}

class test{
    s v m (){
        classData <String> = new classData<String>();
        name.value=".NET";
        classData <Float> = new classData<Float>();
        version.value=4.0;
}
}


/*

    Date : 03/01/2025

Make a common pointer that holds the address of the function
Then the functions signature basis , the pointer led to the call of the function.

Here we know it as the delegate which is the type safe function pointer.
it will call the function which parameters it is going to match with,

Delegates will store the address / reference of the function that it is going
to call.

Make a delegate that will call more than one function but the signature of the
respective function must match with the parameter of the delegeate.

1st we make the object then we do the function call and give the actual parameters
of the function call by object.

if the function is static then we will call it by the ClassName.StaticMethod.
A delegate will be able to call more than one functions

Now with the help of the delegates

Step1 Define the delegate : modifer delegate_keyword return_keyword Name_Delegate(ParameterList)
now all those functions whose parameters match with that of the delgate that function is called.
name of the delegate and the function must not be the same.

then we will make the instances of the delegate. make the delegate that is common that
can call other functions. The delegate it is the refernce and the namespace.

It must be made in the namespace so that it be accessible the namespace wise,
Best idea is to not to make in the Class but to make it inside the namespace,

multiple functions of the same signature then do the calling by the delegate,

This is similar to the dynamic dispatch in java. it will do the calling in the runtime.










 */
namespace aayush {
    public delegate void AddDelegate(int a, int b);
    public delegate string SayDelegate(string name);
    public class program_demo
{
    public void AddNums(int a , int b)
    {
        Console.WriteLine(a + b);
    }

    public static string SayHello(string name)
    {
        return "Hello " + name;
    }
    //
   
    
    public static void Main_run(String[] args)
    {
        program_demo demo = new program_demo();
            Demo_Second ds = new Demo_Second();
        // instantiating the delegate of the class program_demo

        AddDelegate ad = new AddDelegate(demo.AddNums);
        AddDelegate ad1 = new AddDelegate(ds.SubNums);
        
        SayDelegate sd = new SayDelegate(program_demo.SayHello);

        ad(10, 20);
        ad1(20, 10);
        String sd_msg = sd("Aayush_Sahay");
        Console.WriteLine(sd_msg);

    }
}

    public class Demo_Second
    {
        public void SubNums(int a, int b) {
            Console.WriteLine(a - b);
        }
    }
}

















