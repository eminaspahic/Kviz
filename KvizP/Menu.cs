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
            Console.WriteLine("3. Scoreboard");
            Console.WriteLine("4. Exit");
            while (true)
            {
                try
                {
                    int input = int.Parse(Console.ReadLine());
                    switch (input)
                    {
                        case 1: 
                            Console.WriteLine("Singleplayer");
                            var singleplayer = new Singleplayer();
                            singleplayer.Play();  
                            break;

                        case 2:
                            Console.WriteLine("Multiplayer");
                            var multiplayer = new Multiplayer();
                            multiplayer.Play();
                            break;

                        case 3:
                            Console.WriteLine("Scoreboard");
                            //scoreboard
                            break;

                        case 4:
                            Console.WriteLine("Kraj");
                            return 0;

                        default:
                            Console.WriteLine("Pogresan unos!");
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("Pogrešan unos.");
                }
            }
        }
    }

}

