using C_Sharp_Project1_Console;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace C_Sharp_Project1_Console
{
    using System;

    class Answer1
    {
        public static void Main1()
        {
            Console.Write("Enter a character: ");
            char ch = Char.ToLower(Console.ReadLine()[0]);

            if ("aeiou".IndexOf(ch) != -1)
                Console.WriteLine("Vowel");
            else
                Console.WriteLine("Consonant");
        }
    }

    class Answer2
    {
        public static void Main2()
        {
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(n % 2 == 0 ? "Even" : "Odd");
        }
    }

    class Answer3
    {
        public static void Main3()
        {
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Prime numbers:");
            for (int i = 2; i <= n; i++)
            {
                bool prime = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        prime = false;
                        break;
                    }
                }
                if (prime) Console.Write(i + " ");
            }
        }
    }

    class Answer4
    {
        public static void Main4()
        {
            Console.Write("Enter first number: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int b = int.Parse(Console.ReadLine());

            if (b == 0)
                Console.WriteLine("Error: Division by zero");
            else
                Console.WriteLine(a % b == 0 ? "Divisible" : "Not divisible");
        }
    }

    class Answer5
    {
        public static void Main5()
        {
            Console.Write("Enter first number: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int b = int.Parse(Console.ReadLine());

            if (b == 0)
                Console.WriteLine("Error: Division by zero");
            else if (b > a)
                Console.WriteLine("Error: Second number is greater than first");
            else
                Console.WriteLine("Quotient = " + (a / b));
        }
    }

    class Answer6
    {
        public static void Main6()
        {
            Console.Write("Enter a number (1-7): ");
            int d = int.Parse(Console.ReadLine());

            string[] days = { "Invalid", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            if (d >= 1 && d <= 7)
                Console.WriteLine(days[d]);
            else
                Console.WriteLine("Invalid input");
        }
    }

    class Answer7
    {
        public static void Main7()
        {
            int max = int.MinValue;

            Console.WriteLine("Enter 10 numbers:");
            for (int i = 0; i < 10; i++)
            {
                int n = int.Parse(Console.ReadLine());
                if (n > max) max = n;
            }

            Console.WriteLine("Highest number = " + max);
        }
    }

    class Answer8
    {
        public static void Main8()
        {
            int product = 1;

            for (int i = 1; i <= 10; i++)
                product *= (2 * i);

            Console.WriteLine("Product of first 10 even numbers = " + product);
        }
    }

    class Answer9
    {
        public static void Main9()
        {
            Console.Write("Enter year: ");
            int year = int.Parse(Console.ReadLine());

            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
                Console.WriteLine("Leap Year");
            else
                Console.WriteLine("Not a Leap Year");
        }
    }

}

class Runner
{
    public static void Main55()
    {
        int inp;
        while (true)
        {
            Console.WriteLine("Program1\nProgram2\nProgram3\nProgram4\nProgram5");
            Console.WriteLine("Program6\nProgram7\nProgram8\nProgram9\nHit control C to quit.\n");
            Console.WriteLine("Give what program you want to run");
            inp = Convert.ToInt32(Console.ReadLine());
            switch (inp) {
                case 1:
                    Answer1.Main1();
                    break;
                case 2:
                    Answer2.Main2();
                    break;
                case 3:
                    Answer3.Main3();
                    break;
                case 4:
                    Answer4.Main4();
                    break;
                case 5:
                    Answer5.Main5();
                    break;
                case 6:
                    Answer6.Main6();
                    break;
                case 7:
                    Answer7.Main7();
                    break;
                case 8:
                    Answer8.Main8();
                    break;
                case 9:
                    Answer9.Main9();
                    break;
                default:
                    Console.WriteLine("Give input range {1 to 9} only");
                    break;
            }
        }
    }
}