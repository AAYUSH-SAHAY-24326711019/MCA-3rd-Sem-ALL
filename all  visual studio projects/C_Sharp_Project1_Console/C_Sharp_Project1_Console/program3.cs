using System;

/*
 Date :19/12/2025 (notes)

for loop (initialization (optional/ Executes only once) ; condition(optional); increment/decrement){
	//code in the for loop
}
 
default internal (self assembly accessible) , public (self + other assembly access)

 */


public class variables{

	public static void Main31()
	{ // variation 1
		for(int i = 10; i<20; i++)
		{
			Console.WriteLine(i);
		}
        Console.WriteLine("--------------------------------------------");
        // variation 2
        {
            int i = 10;
			for (; i < 20; i++)
			{
				Console.WriteLine(i);
			}
		}
        Console.WriteLine("--------------------------------------------");
        // variation 3
        {
            int i = 10;
            for (; ; i++)
            {
                if(i < 20)
                    Console.WriteLine(i);
            }
        }
        Console.WriteLine("--------------------------------------------");
        // variation 4
        {
            int i = 10;
            for (; ;)
            {
                if (i < 20)
                    Console.WriteLine(i);
                i++;
            }
        }


    }
}
