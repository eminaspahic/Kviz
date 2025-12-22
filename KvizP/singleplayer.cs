using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks.Sources;

namespace KvizP
{
    internal class Singleplayer
    {
        private List<int> usedIndexes = new List<int>();
        private Pitanja pitanja;

        public Singleplayer()
        {
            pitanja = new Pitanja();
            usedIndexes = new List<int>();
        }
        public void Play()
        {
            Console.Write("\nEnter your name: ");
            string name = Console.ReadLine();
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Unesite tačno ime");
                return;
            }
            Score score = new Score(name, "Singleplayer");
            string[] validOptions = { "A", "B", "C" };

            for (int i = 0; i < 7; i++)
            {
                int index = pitanja.GetRandomQuestion(usedIndexes);
                usedIndexes.Add(index);
                Console.WriteLine("Pitanje " + (i + 1) + ".");
                Console.WriteLine(pitanja.Questions[index]);

                foreach (string option in pitanja.Answers[index])
                {
                    Console.WriteLine(option);
                }
                string playerAnswer;
                while (true)
                {
                    Console.Write("Vaš odgovor (A, B, C): ");
                    playerAnswer = Console.ReadLine().Trim().ToUpper();

                    if (validOptions.Contains(playerAnswer))
                        break;
                    else
                        Console.WriteLine("Pogrešan unos! Pokušaj ponovo.");
                }

                if (pitanja.CheckAnswer(index, playerAnswer))
                {
                    Console.WriteLine("Tačno!");
                    score.AddPoint();
                }
                else
                {
                    Console.WriteLine("Netačno!");
                }


            }
            Console.WriteLine("Konačni rezltat je:" + score.Points);
            score.Save();

            Console.Write("\nPlay again? (Y/N): ");
            string response = Console.ReadLine().Trim().ToUpper();
            if (response == "Y")
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