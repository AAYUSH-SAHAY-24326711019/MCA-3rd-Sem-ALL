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

    public static void Main()
    {
        StudentDetails sd = new StudentDetails();
        sd.Student();
        StudentDetails Aayush = new StudentDetails("Aayush",102,21);
        Aayush.Student();
    }
}