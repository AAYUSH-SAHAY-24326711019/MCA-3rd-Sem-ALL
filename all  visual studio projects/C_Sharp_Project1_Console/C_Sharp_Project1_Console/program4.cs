using System;
using System.Collections.Generic;
using System.Text;

/*
 date 19/12/2025

variable a =variable 2 =variable 3 = value ; will assign the same value to all the variables in same line
 
 */

class newTest
{
    public static void Main41() 
    { // variation 1
        Console.WriteLine("----------break case--------------");
        for (int i = 10; i < 20; i++)
        {
            if (i == 16)
                break;
            Console.WriteLine(i);
        }
        Console.WriteLine("out of loop");
        Console.WriteLine("----------Continue case--------------");
        for (int i = 10; i < 20; i++)
        {
            if (i == 16)
                continue;
            Console.WriteLine(i);
        }

        int incr, sumNum, number;
        for (incr = sumNum = number = 0; incr < 5; incr = incr + 1)
        {
            Console.WriteLine("Enter a positive number :");
            number = Convert.ToInt32(Console.ReadLine());
            if (number <= 0)
                continue;
            sumNum = sumNum + number;
        }
        Console.WriteLine("The sum of the positive numbers :"+sumNum);

    }

   
}

/*
Enter a positive number :
10
Enter a positive number :
2
Enter a positive number :
-5
Enter a positive number :
-5
Enter a positive number :
-5
The sum of the positive numbers :12*/

class newTest2
{
    public static void Main()
    {
        int num1; int num2;
        num1 = num2 = 1;
        Console.WriteLine("{0}", num1);
        while (num2 < 200)
        {
            Console.WriteLine(num2);
            num2 += num1;
            num1 = num2 - num1;
        }
    }
}