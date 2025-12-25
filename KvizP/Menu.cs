using System;
using System.Collections.Generic;
using System.Text;

namespace KvizP
{
    internal class Menu
    {
        public static int Odabir()
        {
            while (true)
            {
            Console.WriteLine("KVIZ ZNANJA");
            Console.WriteLine("1. Singleplayer");
            Console.WriteLine("2. Multiplayer");
            Console.WriteLine("3. Scoreboard");
            Console.WriteLine("4. Exit");
           
                try
                {
                    int input = int.Parse(Console.ReadLine());
                    switch (input)
                    {
                        case 1: 
                            
                            var singleplayer = new Singleplayer();
                            Console.Clear();
                            Console.WriteLine("Singleplayer");
                            singleplayer.Play();
                            break;

                        case 2:
                            var multiplayer = new Multiplayer();
                            Console.Clear();
                            Console.WriteLine("Multiplayer");
                            multiplayer.Play();
                            break;

                        case 3:
                            Console.Clear();
                            Console.WriteLine("Scoreboard");
                            if (Score.AllScores.Count == 0)
                            {
                                
                                Console.WriteLine("\nNema rezultata!");
                            }
                            else
                            {
                                Console.WriteLine("\n SCOREBOARD");
                                foreach (var score in Score.AllScores)
                                {
                                    Console.WriteLine(score.PlayerName + ": " + score.Points + "/7 (" + score.Mode + ")");
                                }
                            }
                            
                            break;

                        case 4:
                            Console.WriteLine("Kraj");
                            return 0;

                        default:
                            Console.WriteLine("Pogresan unos!");
                            break;
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Pogrešan unos."+ex.Message);
                }
            }
        }
    }

}

