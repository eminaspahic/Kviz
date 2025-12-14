using System;
using System.Collections.Generic;
using System.Text;

namespace KvizP
{
    internal class Menu
    {
        public static int Odabir()
        {
            Console.WriteLine("KVIZ ZNANJA");
            Console.WriteLine("1. Singleplayer");
            Console.WriteLine("2. Multiplayer");
            while (true)
            {
                try
                {
                    int input = int.Parse(Console.ReadLine());
                    if (input==1||input==2)
                    {
                        return input;
                    }
                    else
                        Console.WriteLine("Unesite 1 ili 2.");
                }
                catch
                {
                    Console.WriteLine("Pogrešan unos.");
                }
            }
        }
    }

}

