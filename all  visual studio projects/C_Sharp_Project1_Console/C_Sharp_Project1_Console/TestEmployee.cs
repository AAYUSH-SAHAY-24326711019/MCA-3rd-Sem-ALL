using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Project1_Console
{
    public class TestEmployee
    {
        public static void Main(String[] args)
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