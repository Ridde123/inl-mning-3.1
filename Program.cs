﻿using System;
namespace Uppgift_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur gamal är du? (år)");
            int ålder = int.Parse(Console.ReadLine());

            if (ålder < 16 && ålder > 19)
            {
                Console.WriteLine("Du får delta i den här tävling");
            }
            else
            { 
                
                Console.WriteLine("Du får inte delta i den här tävlingen");
            }
        }
    }
}




