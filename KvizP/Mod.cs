using System;
using System.Collections.Generic;
using System.Linq;

namespace KvizP
{
    internal abstract class Mod { 

        protected List<int> usedIndexes;
        protected Pitanja pitanja;

        public Mod()
        {
            pitanja = new Pitanja();
            usedIndexes = new List<int>();
        }
        public abstract void Play();
        protected void AskQuestion(Score score, string playerName, int questionNumber)
        {
            int index = pitanja.GetRandomQuestion(usedIndexes);
            usedIndexes.Add(index);

            Console.WriteLine(playerName+" - Pitanje "+questionNumber+":");
            Console.WriteLine(pitanja.Questions[index]);

            foreach (string option in pitanja.Answers[index])
            {
                Console.WriteLine(option);
            }

            string playerAnswer = GetValidAnswer();

            if (pitanja.CheckAnswer(index, playerAnswer))
            {
                Console.WriteLine("Tačno!");
                score.AddPoint();
            }
            else
            {
                Console.WriteLine("Netačno!");
            }
            Console.WriteLine();
        }

        private string GetValidAnswer()
        {
            string[] validOptions = { "A", "B", "C" };
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

            return playerAnswer;
        }


    }
    
}
