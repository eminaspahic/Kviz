using System;
using System.Collections.Generic;
using System.Text;

namespace KvizP
{
    internal class Pitanja
    {
        public List<string> Questions { get; set; }
        public List<string[]> Answers { get; set; }
        public List<string> CorrectAnswers { get; set; }
        public Pitanja()
        {
            Questions = PitanjaSt.GetQuestions();
            Answers = PitanjaSt.GetAnswers();
            CorrectAnswers = PitanjaSt.GetCorrectAnswers();
        }

        public int GetRandomQuestion(List<int> usedIndexes)
        {
            Random random = new Random();
            int index;

            do
            {
                index = random.Next(0, Questions.Count);
            }
            while (usedIndexes.Contains(index));

            return index;
        }

        public bool CheckAnswer(int questionIndex, string playerAnswer)
        {
            playerAnswer = playerAnswer.Trim().ToUpper();

            return playerAnswer == CorrectAnswers[questionIndex];
        }
    }
}
