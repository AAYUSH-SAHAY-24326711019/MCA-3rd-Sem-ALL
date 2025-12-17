using System;
using System.Collections.Generic;
using System.Text;


class Game
{
    public static void Main(string[] args)
    {
        //example of the formatted output..
        //There is also a concatenated method.
        Console.WriteLine("Enter a number :");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine("Your entered number is {0} ,{1}",x,80);

        x = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Your value is : "+x);

    }
}

/*operstor operates on the operands.
 There are need of 2 operands then binary operator.

 arithematic , arith. assignment, unary operator, comparison operator, logical operator.
expression produce the resuly , constant , operator , method (combination of any oreder)
and will return us a value after computation.
eg.int result = 10+5; is an expression 

Therea are many expressions.
a+= value ; compound / augmented / composite assignment operation

int max = (condition)?true_expression:false_expression;

5=0101
3=0011

namespace = package(java)
make the class in vb.net , be used in c# and other .Net framework languages.
avoid the name conflict which have the same name , if they are seperate the 
namespaces to resolve the conflict.


 */