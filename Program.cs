using System;

namespace Array;

class Program

{
    static void Main()

    {
        int[] arr = new int[3];
        string[] order = {"first", "second", "third"};
        int i;

        for (i = 0; i < 3; i++)
        {
            Console.Write("Enter your "+ order[i]+ " number ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (i = 0; i < 3; i++)
        {
            Console.WriteLine();
            Console.WriteLine("Your "+ order[i]  +" number is " + arr[i]);
        }
        Console.WriteLine();
        Console.WriteLine("Press ENTER key");
        Console.Read();
    }

}