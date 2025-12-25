using System;
using System.Collections.Generic;
using System.Text;

namespace KvizP
{
    internal class Multiplayer : Mod
    {

  
        public override void Play()
        {
            Console.Write("\nIme igrača 1: ");
            string name1 = Console.ReadLine();
            Console.Write("Ime igrača 2: ");
            string name2 = Console.ReadLine();

            if (string.IsNullOrEmpty(name1) || string.IsNullOrEmpty(name2) || name1 == name2)
            {
                Console.WriteLine("Unesite tačno ime");
                return;
            }

            Score score1 = new Score(name1, "Multiplayer");
            Score score2 = new Score(name2, "Multiplayer");

            for (int i = 0; i < 7; i++)
            {
                AskQuestion(score1, name1, i + 1);
                AskQuestion(score2, name2, i + 1);
            }
            Console.Clear();
            Console.WriteLine("Rezultat:");
            Console.WriteLine(name1 + ": " + score1.Points + " poena");
            Console.WriteLine(name2 + ": " + score2.Points + " poena");
            score1.Save();
            score2.Save();

            Console.Write("\nIgrati ponovo? (D/N): ");
            string response = Console.ReadLine().Trim().ToUpper();
            if (response == "D")
            {
                Console.WriteLine("\n");
                Play();
            }
            else
            {
                return;
            }
        }

    }
}
