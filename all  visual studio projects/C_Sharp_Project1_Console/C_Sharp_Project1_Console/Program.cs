using System;
public class Event
{public static void Main1() //String args is optional command
    {
        Console.WriteLine("\tEvent Name :"+"\t"+"Tennis Match\n");
        Console.WriteLine("\tVenue :"+"\t"+"Star Sports Complex\n");
        Console.WriteLine("\tTime :"+"\t"+"4 PM To 6 PM");
    }

}

/*
 * Class : 11/12/2020 Notes
 * 
 *                  Variable and its Scope
 * 
 * console has keyboard and monitor.
 it has input output and error.
for input it has keyboard and
output has monitor

 Visual Studio gives intellesense feature.
variable is named location which value can be manipulated
variable is going to store the data of fixed datatype.
value change during execution, declare before use.
specific type means the type of data it holds.

5 types of variables on C#

1. local var , all place made , we can make it in a block .
    Between the opening and closing braces of a block / class /function /loop
    After we exit the block the variable vanish from the memory.
    Inside the block the variable can be accessible.
    We can be make it in coonstructor ,These are created as we enter the block.
    It will be activated until the control stays in the block.

# object in java can be cloned 
    by clonable interface. C++ has the copy constructor.


instance var : out of constructor or normal method but always in class.
    When make the object of class in memory , in object it has an
    individual copy.
student class {id , name , address , marks} are the attributes of class
are declared as the instance variable , 11 objects of Student class
in memory , the seperate copy of above variables is made for all the
objects of class. This is other name of NonStatic variable 

Static variable in memory , inside heap memory , made once reffered by all the 
other objects.Static variable is known as the Class Variable.

The Constant variable is made 'final' in java , always make it static in java
to prevent its seperate copy when seperate objects of the class is made.

Read only variable : 

 */

public class StudentDetails
{   //example of instance variables
    int age, rollNo;
    String name = "";

    StudentDetails()
    {
        age = 0;
        rollNo = 101;
        this.name = "Anonymous";
    }

    StudentDetails(String name,int roll,int age)
    {
        this.age =age ;
        rollNo = roll;
        this.name = name;
    }
    
    public void Student()
    {
        
        Console.WriteLine("Roll No  "+rollNo+"\nStudentName: "+name+"\nAge: "+age);
    }

    public static void Main2()
    {
        StudentDetails sd = new StudentDetails();
        sd.Student();
        StudentDetails Aayush = new StudentDetails("Aayush",102,21);
        Aayush.Student();
    }
}

/*Date : 16/12/2025 (Notes) 
 we have already seen the local variable program as above.

Instance variable aka non static variable at the class level.
and outside the function and outside the constructor.
They serve to be the property.

As we make the object , its variables are made the seperate copy.
They dont get destroyed until the object is destroyed.
They are used throughout the class body. inside class functions
or inside the class constructors
 
 
 
 
 */

class Marks
{
    public const int Max = 200;
    //a constant value made by const keyword.
    //it is handled by the compile time.
    // we cannot make it change.
    //it is a type of read only variable.
    //behaviour like the static variable.
    //it is initialized one time.
    //like static accessible as a single copy to all the variables.
    //access directly by the class name.
    //but we cannot modify the values.


    public readonly int id;
    //Read only variable is initialzed only 1 time
    //it is handled at the run time.
    //it can be initialized in the constructor only once.
    //const :  compile,declaration, static, fast, not object specific
    //readonly :  runtime, init in declaration or function , object specific and slower


    int engMarks, mathsMarks, phyMarks;
    //These are the class level variables.

    static int numberOfStudents;
    //This is the static variable. known as the instance variable
    //This is created in the heap variable. This is in memory specific location.
    //Static variable single copy , shared among all the objects of the same class.
    //make the counter , call in the constructor.
    //not have garbage value and start with 0 when integer.
    //can changed at any time of the program , for all.
    //

    //make init function
    void init(int eng, int maths,int phy)
    {
        numberOfStudents += 1;
        //increase the variable
        engMarks = eng; mathsMarks = maths; phyMarks = phy;

        //eg. of local variable inside the init :
        //int localVar = 60; will show error when accessed , so does not exist in current context.
        //it is accessible till the lifetime of init method.
        //When control enters block / block of the functions , the variable is made
        //exit from the block , the variable gets destroyed.
        //instance variable made seperately for all the instances of the class.
        //all have the garbage value by default.
    }

   static int dispNumberStudents()
    {
        return numberOfStudents;
    }



    //display function
    void display()
    {
        //Console.WriteLine("English :" + engMarks + "\tMaths :" + mathsMarks + "\tPhysics :" + phyMarks+
        //    "\nNumber of Students :"+Marks.numberOfStudents);

        Console.WriteLine("English :" + engMarks + "\tMaths :" + mathsMarks + "\tPhysics :" + phyMarks+
            "\n\n Serial Number of Students :"+Marks.dispNumberStudents());
    }
    public static void Main()
    {
        Marks mk1 = new Marks();
        mk1.init(77, 85, 92);
        mk1.display();
        Marks mk2 = new Marks();
        mk2.init(50, 50, 50);
        mk2.display();
    }
}