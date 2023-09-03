using ConsoleApp06;
using System;
using System.Diagnostics.Tracing;

namespace ConsoleApp2
{
    internal class Program
    {

        public static int makeMenu(int _count, params string[] arr)
        {
            int index = 0;


            dynamic choice;
            while (true)
            {
                Console.Clear();
                for (int i = 0; i < _count; i++)
                {
                    if (index == i)
                        Console.Write("-->");
                    else
                        Console.Write("   ");
                    Console.WriteLine(arr[i]);


                }




                choice = Console.ReadKey();

                if (choice.Key == ConsoleKey.UpArrow && index == 0)
                {
                    index = _count - 1;
                }
                else if (choice.Key == ConsoleKey.UpArrow)
                {
                    index--;
                }
                else if (choice.Key == ConsoleKey.DownArrow && index == _count - 1)
                {
                    index = 0;
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
            PetShop shop = new PetShop("name");
            User user = new User();
            Console.Write("Enter username: ");
            user.Name = Console.ReadLine();
            Console.Clear();
            int index = makeMenu(3, "All Pets", "Buy", "My Pets", "Exit");

            if (index == 0)
            {
                Console.Clear();
                shop.AllPets();
            }
            else if (index == 1)
            {
                Console.Clear();
                Console.Write("Enter id of the animal: ");
                dynamic id=Console.ReadLine();
                shop.Buy(id, user);
            }
            else if (index == 2)
            {
                Console.Clear();
                user.ShowMyPets();
            }

        }
    }
}
