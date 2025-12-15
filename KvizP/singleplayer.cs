using System;
using System.Collections.Generic;
using System.Text;

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
                    Console.Write("Your answer (A, B, C): ");
                    playerAnswer = Console.ReadLine().Trim().ToUpper();

                    if (validOptions.Contains(playerAnswer))
                        break;
                    else
                        Console.WriteLine("Invalid input! Try again.");
                }

                if (pitanja.CheckAnswer(index, playerAnswer))
                {
                    Console.WriteLine("Correct!");
                }
                else
                {
                    Console.WriteLine("Wrong!");
                }
            }
        }
    }
}
