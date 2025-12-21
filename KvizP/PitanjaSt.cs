using System;
using System.Collections.Generic;
using System.Text;

namespace KvizP
{
       internal class PitanjaSt
    {
        public static List<string> GetQuestions()
        {
            return new List<string>
            {
                "Koji je glavni grad Francuske?",
                "What is the capital of France?",
                "Koja je najveća planeta u Sunčevom sistemu?",
                "What is 2 + 2?",
                "Ko je napisao 'Romeo i Julija'?",
                "What is the chemical symbol for water?",
                "Koji je najduži rijeka na svijetu?",
                "How many continents are there?",
                "Koja je formula za izračunavanje površine kruga?",
                "What year did World War II end?"
            };
        }

        public static List<string[]> GetAnswers()
        {
            return new List<string[]>
            {
                new string[] { "A) Pariz", "B) Rim", "C) Berlin" },
                new string[] { "A) London", "B) Berlin", "C) Paris" },
                new string[] { "A) Zemlja", "B) Jupiter", "C) Saturn" },
                new string[] { "A) 3", "B) 4", "C) 5" },
                new string[] { "A) Charles Dickens", "B) William Shakespeare", "C) Mark Twain" },
                new string[] { "A) H2O", "B) CO2", "C) O2" },
                new string[] { "A) Nil", "B) Amazona", "C) Mississippi" },
                new string[] { "A) 5", "B) 6", "C) 7" },
                new string[] { "A) πr²", "B) 2πr", "C) πd" },
                new string[] { "A) 1943", "B) 1945", "C) 1947" }
            };
        }

        public static List<string> GetCorrectAnswers()
        {
            return new List<string>
            {
                "A",  // Pariz
                "C",  // Paris
                "B",  // Jupiter
                "B",  // 4
                "B",  // Shakespeare
                "A",  // H2O
                "A",  // Nil
                "C",  // 7
                "A",  // πr²
                "B"   // 1945
            };
        }
    }

}
