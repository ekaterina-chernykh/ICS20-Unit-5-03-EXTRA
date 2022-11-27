// Created by: Ekaterina
// Created on: Nov 2022
//
// This program generates random positive or negative number

using System;

class Program
{
    public static void Main(string[] args)
    {
        int userNumber;

        // This function accepts user input
        Console.WriteLine("What movie can you watch??");
        Console.WriteLine(" ");

        Console.WriteLine("Enter your age to find out ");
        Console.WriteLine(" ");
        userNumber = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine(" ");
        if (userNumber >= 17)
        {
            Console.WriteLine("You can watch a G, Pg13 and R movie ");
        }
        else if (userNumber >= 13)
        {
            Console.WriteLine("You can watch a G and Pg13 movie ");
        }
        else if (userNumber <= 12)
        {
            Console.WriteLine("You can watch a G movie ");
        }

        Console.WriteLine("\nDone.");
    }
}