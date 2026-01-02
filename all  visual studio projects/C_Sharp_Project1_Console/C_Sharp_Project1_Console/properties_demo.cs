using System;
using System.Collections.Generic;
using System.Data;
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

        static void Main12()
        {
            properties_demo p = new properties_demo();
            p.X = 20;
            int values = p.X;
            Console.WriteLine(values);

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



    /*Date 29/12/2025*/
    /*class Demo
    {



        static void Main()
        {
            int sum=0, rowsum = 0;
            int[,] arr = new int[2, 4] { { 2, 2, 2, 2 }, { 3, 3, 3, 3 } };
            int row, col = 0;
            for (row=0; row < 2; row++)
            {
                rowsum = 0;
                for (col = 0; col < 4; col++)
                {

                    Console.Write("{0}\t", arr[row, col]);
                    rowsum = rowsum + arr[row, col];
                }Console.Write("Row Sum : {0}\n", rowsum);


                sum = sum + rowsum;

            }Console.WriteLine("The sum of array is = {0}", sum);


            // Program 2
            //String[] src = new string[]
            //{
            //   "Marigold","Rose","Lotus","Larkspur"
            //};

            //String[] Info = src;
            //foreach(String k in Info)
            //{
            //    Console.WriteLine(k[2]);
            //}
        }
    }
    */


    //31.12.2025

    /*
     indexer is the member of a class.
    treated as a virtual array.


    just like the index of the array , we can make it user friendly using
    1,2,3... index.

    mofiier return-type this[int index]{
       get{statements}
       set{statements}
    }
    (eno,ename,job,salary,dname,location)

    indexer depends on the property
     */

    public class Employee {

       private int eno;  private double salary;
        private String job, ename, dname, location;
        public Employee(int eno, String ename, String job, String dname, String location, double salary)
        {
            this.eno = eno;
            this.ename = ename;
            this.job = job;
            this.dname = dname;
            this.location = location;
            this.salary = salary;
        }

        //define the indexer
        //object is the top level object in the Java or C#
        //for the safer side we choose object.
        //it is reference type to store all the other 
        //data types in the hirearchy

        //indexer is written in the class ,
        //acts as a virtual array treating the variable of class as
        //array elements accessible through index starting by default
        //from 0
        //This is a data access scheme

        //*Readonly then only get
        //*write only then set , Get and set both if both read and write
        //make the indexer name using the index and other way we will make the
        //indexer scheme using the name of the fields

        public object this[int index] // we can write String name to access
        {
            get {
                //retrive the data
                if (index == 0) return (int)eno;
                else if (index == 1) return (double)salary;
                else if (index == 2) return (String)ename;
                else if (index == 3) return (String)job;
                else if (index == 4) return (String)dname;
                else if (index == 5) return (String)location;
                else 
                    return (object)null;
            }
            set {
                //set the values
                //retrive the data
                if (index == 0) eno = (int)value;
                else if (index == 1) salary = (double)value;
                else if (index == 2) ename = (String)value;
                else if (index == 3) job = (String)value;
                else if (index == 4) dname = (String)value;
                else if (index == 5) location = (String)value;
                
            }
        }
        //remove the main
        //public static void Main(String[] args)
        //{
           

        //}
    }

}