/*
Class Date : 23/12/2025

Class notes
make a console app .net framework
make the project name as : MyApp
Then you make the code inside the main method

Console.WriteLine("Hi MCA Students!");
Console.ReadKey();
when you run this you will get an exe to run.

what process in that ? internally -> namespace ->was made to an
assembly
in the solution explorer , right click your porgram 
ope in the exploerr , App ->Debug -> here you can see your
exe file. Double click to make it run, You need to have the
.NET Framework so that you could be able to be run the exe.

Now you can place the application anywhere on your device
exe is an assembly that is executable. 

To make the DLL , DLL will give the functionality to an exe / used by
some exe.

make a new project and add a .NET Framework named class library
Now make its name as : MyDll and it must be build and not be
run since no Main () as an entry point of control.

code :
using System;
namespace MyDLl{
        public class class1{
            public String greet(){
                return "Hi, i am greet fn from MyDll"
            }
        }
}

Then build MyDLL.
go to file exp : bin>debug>see the dll file there.
now to be able to use in the application that we have made.

now open the MyApp project , we will import the Class 1 in namespace
MyDLL. We make the object of the class 1. in order to be access the
greet()

open the MyApp.sln (set the reference to use it)-> right click 
add reference -> browse -> go to MyDll folder > bin >debug
add it there and finally check the references.

Then in the code : add using MyDLL;
in the main method make the object of class1

Class1 c = new Class1();
String s1 = c.greet();
Console.WriteLine("The message is {s1}");
Console.ReadKey();

output : Hi, Students from MCA 3rd Semester
Hii i am from greet function from DLL

msil is the bytecode of .NET
it is cpu indepented made by the .NETCompiler
MSIL will then run on target machine
src->compiler->clr->jit->Then run on the target machine

jre loads byte code -> it has jit -> then engine
to finally execute
like bytecode of Java
features : platform independent. Can run on any system 
but it must have the CLR (Common language runtime)
cross .NET framework application interoperability
There is object creation 
and security checks/ methods , exception handling


Passing the information to the methods. how to call the
functions. Same way. Function / method , we pass the 
parameters , function may / maynot return output if incase
return type is void.


to make the parametrized Methods :

void methodWithParameters(int n , String y){
    //up the parameters is the formal parameters
}

methodWithParameters(10,"Hello");
here above is the actual parameters

To call the method , we must ensure the parameters are 
matching with the signature:
There is pass by value . pass by reference . pass by output.
There will be use of the output keyword.
The data can be extracted from there and the out


make the calculator application there is an AddOne function will do the +1
to all the values it gets,

The local varaiable will be sent 

int number = 6;
Calculator obj = new Calculator();
obj.AddOne(number);
Console.WriteLine(number);


Then in the function of the calculator

void AddOne(int var){
    var++;
    Console.WriteLine(var);
}

Then will print 7 (6 was incremented from 1)
Then printing the value of number will print 6

Passing the Parameters by Reference
There will be passing of the address

there we use the ref kwyeord. it does not make the extra memory
it use the memory of the formal parameter

ref : reference and out : out
* you must be specific to use the ref keyword.


void AddOne(ref int var){
    var++;
}

obj.AddOne(ref number);
Console.WriteLine(number);

pass the output , we can use the return statement.
This can be used to return a singlr value
this overcome the limitation of the return keyword,
use out with multiple variables of the parameters list

sometimes uninitialised values can be returned

class out example

make a static function of out demo 

static void outDemo(out int i){
    i=38;

}

//you know that the parameter list variables are the local variable

main(){
int num1;
        OutDemo(out num1);
        Console.WriteLine("Value is now: {0}",num1);
        Console.ReadKey();
}

Value is now :38

There are the named and the optional arguments.

Optional arguments can be omitted.
in C/C++ java , there is a must requirement to make the signature
be matching.  The name of the arguments are made the optional.
These make the call flexible , they make it compatible to vb.

C#, VB , F# take care of each other. They will interoperate

public void myMethod(int x, int y =10, int z=20){}

y and z are optional , if  not mentioned then y and 
z assume their values to be 10 and 20.
You cannot leave x as blank as its a mandatory parameter

myMethod(10,20,30);
myMethod(10,30);
myMethod(10);
myMethod(); X This will not be working.

named parameters

myMethod(x:10,y:20,z:30);
This make the function call : readable , flexible and convinient.








*/