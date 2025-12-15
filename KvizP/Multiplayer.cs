using System;
using System.Collections.Generic;
using System.Text;

namespace KvizP
{
    internal class Multiplayer
    {

        private List<int> usedIndexes = new List<int>();
        private Pitanja pitanja;

        public Multiplayer()
        {
            pitanja = new Pitanja();
            usedIndexes = new List<int>();
        }

        public void Play()
        {
            string[] validOptions = { "A", "B", "C" };

            for (int i = 0; i < 7; i++)
            {
                int index1 = pitanja.GetRandomQuestion(usedIndexes);
                usedIndexes.Add(index1);

                Console.WriteLine("Player 1 - Question"+ (i + 1)+ ":");
                Console.WriteLine(pitanja.Questions[index1]);

                foreach (string option in pitanja.Answers[index1])
                {
                    Console.WriteLine(option);
                }

                string player1Answer;
                while (true)
                {
                    Console.Write("Player 1 answer (A, B, C): ");
                    player1Answer = Console.ReadLine().Trim().ToUpper();

                    if (validOptions.Contains(player1Answer))
                        break;
                    else
                        Console.WriteLine("Invalid input! Try again.");
                }

                if (pitanja.CheckAnswer(index1, player1Answer))
                    Console.WriteLine("Correct!");
                else
                    Console.WriteLine("Wrong!");

                int index2 = pitanja.GetRandomQuestion(usedIndexes);
                usedIndexes.Add(index2);

                Console.WriteLine();
                Console.WriteLine($"Player 2 - Question"+ (i + 1)+ ":");
                Console.WriteLine(pitanja.Questions[index2]);

                foreach (string option in pitanja.Answers[index2])
                {
                    Console.WriteLine(option);
                }

                string player2Answer;
                while (true)
                {
                    Console.Write("Player 2 answer (A, B, C): ");
                    player2Answer = Console.ReadLine().Trim().ToUpper();

                    if (validOptions.Contains(player2Answer))
                        break;
                    else
                        Console.WriteLine("Invalid input! Try again.");
                }

                if (pitanja.CheckAnswer(index2, player2Answer))
                    Console.WriteLine("Correct!");
                else
                    Console.WriteLine("Wrong!");
            }
        }
    }
}
