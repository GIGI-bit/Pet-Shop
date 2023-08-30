﻿using System;
using System.Diagnostics.Tracing;

namespace ConsoleApp2
{
    internal class Program
    {
       
      static int makeMenu(int _count,params string[] arr)
        {
            int index = 1;


            dynamic choice;
            while (true)
            {
                for (int i = 0; i < _count; i++)
                {
                    if(index==i)
                        Console.Write("-->");
                    else
                        Console.Write("   ");
                    Console.WriteLine(arr[i]);


                }


               

                choice = Console.ReadKey();

                if(choice.Key==ConsoleKey.UpArrow && index == 1)
                {
                    index = _count-1;
                }
                else if (choice.Key == ConsoleKey.UpArrow)
                {
                    index--;
                }
                else if (choice.Key == ConsoleKey.DownArrow && index == _count-1)
                {
                    index = 1;
                }
                else if (choice.Key == ConsoleKey.DownArrow)
                {
                    index++;
                }
                else if (choice.Key == ConsoleKey.Enter)
                {
                    return index;
                }

            }


        }


        static void Main()
        {
            makeMenu(4, "one", "two", "three");


        }
    }
}