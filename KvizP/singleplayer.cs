using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks.Sources;

namespace KvizP
{
    internal class Singleplayer:Mod
    {
       
        public override void Play()//sada je override
        {
            Console.Write("\nUnesite vaše ime: ");
            string name = Console.ReadLine();
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Unesite tačno ime");
                return;
            }
            Score score = new Score(name, "Singleplayer");

            for (int i = 0; i < 7; i++)
            {
                AskQuestion(score, name, i + 1);
            }
            Console.Clear();
            Console.WriteLine("Konačni rezltat je:" + score.Points);
            score.Save();

            Console.Write("\nIgrati ponovo (D/N): ");
            string response = Console.ReadLine().Trim().ToUpper();
            if (response == "D")
            {
                Play();
            }
            else
            {
                return;
            }
        }
    }
}