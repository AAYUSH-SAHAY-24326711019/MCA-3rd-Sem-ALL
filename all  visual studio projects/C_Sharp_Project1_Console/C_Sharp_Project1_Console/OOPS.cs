using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace C_Sharp_Project1_Console
{   
    class Bike
    {
        public String bikeColor;
        String Model="Disel_Model";
        public void horn()
        {
            Console.WriteLine("bike horn sound : Beep Beep");
        }
        public void DisplayModel()
        {
            Console.WriteLine(Model);
        }
    }

    class Result
    {
        public static void Main61()
        {

            Bike bike = new Bike();
            bike.bikeColor = "Green";
            Console.WriteLine(bike.bikeColor);
            bike.horn();
            bike.DisplayModel();
            Console.ReadKey();
        }
    }
    internal class OOPS
    {
    }
}
