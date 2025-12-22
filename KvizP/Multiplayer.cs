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
            string[] validOptions = { "A", "B", "C" };

            for (int i = 0; i < 7; i++)
            {
                int index1 = pitanja.GetRandomQuestion(usedIndexes);
                usedIndexes.Add(index1);

                Console.WriteLine( name1+ " - Pitanje "+ (i + 1)+ ":");
                Console.WriteLine(pitanja.Questions[index1]);

                foreach (string option in pitanja.Answers[index1])
                {
                    Console.WriteLine(option);
                }

                string player1Answer;
                while (true)
                {
                    Console.Write("Player 1 odgovor (A, B, C): ");
                    player1Answer = Console.ReadLine().Trim().ToUpper();

                    if (validOptions.Contains(player1Answer))
                        break;
                    else
                        Console.WriteLine("Pogrešan unos! Pokušaj ponovo.");
                }

                if (pitanja.CheckAnswer(index1, player1Answer))
                {
                    Console.WriteLine("Tačno!");
                    score1.AddPoint();
                }
                else
                    Console.WriteLine("Netačno!");


                int index2 = pitanja.GetRandomQuestion(usedIndexes);
                usedIndexes.Add(index2);

                Console.WriteLine();
                Console.WriteLine("Player 2 - Pitanje "+ (i + 1)+ ":");
                Console.WriteLine(pitanja.Questions[index2]);

                foreach (string option in pitanja.Answers[index2])
                {
                    Console.WriteLine(option);
                }

                string player2Answer;
                while (true)
                {
                    Console.Write("Player 2 Odgovor (A, B, C): ");
                    player2Answer = Console.ReadLine().Trim().ToUpper();

                    if (validOptions.Contains(player2Answer))
                        break;
                    else
                        Console.WriteLine("Pogrešan unos! Pokušaj ponovo.");
                }

                if (pitanja.CheckAnswer(index2, player2Answer)) {
                    Console.WriteLine("Tačno!"); 
                    score2.AddPoint();
                }
                    
                else
                    Console.WriteLine("Netačno!");
                Console.WriteLine();
            }
            Console.WriteLine("Rezultat:");
            Console.WriteLine(name1 + ": " + score1.Points + " poena");
            Console.WriteLine(name2 + ": " + score2.Points + " poena");
            score1.Save();
            score2.Save();

            Console.Write("\nIgrati ponovo? (D/N): ");
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
