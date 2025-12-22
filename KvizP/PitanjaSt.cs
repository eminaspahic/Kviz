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

                "Koja je najduža rijeka na svijetu?",
                "Ko je naslikao Mona Lizu?",
                "Kako se zove najveća tehnološka kompanija u Južnoj Koreji?",
                "Koji je hemijski simbol za vodu?",
                "Koji je najveći organ u ljudskom tijelu?",
                "Koliko dana ima obična godina?",
                "Kako se zove kuća napravljena isključivo od leda?",
                "Koliki je kvadratni korijen broja 64?",
                "Koji mjesec ima 28 dana?",
                "Koji je glavni grad Portugala?",
                "Koliko udaha ljudsko tijelo napravi dnevno (otprilike)?",
                "Koji je hemijski simbol za srebro?",
                "Koji je prvi stih romana Moby Dick?",
                "Koja je najmanja ptica na svijetu?",
                "Kako glasi puno ime lutke Barbie?",
                "U čemu Paul Hunn drži rekord od 118,1 decibela?",
                "Koji je bio prvi Disneyjev crtani film u boji?",
                "U kojoj godini je film The Godfather prvi put objavljen?",
                "Koji glumac je osvojio Oscara za filmove Philadelphia i Forrest Gump?",
                "Koliko srca ima hobotnica?"
            };
        }

        public static List<string[]> GetAnswers()
        {
            return new List<string[]>
            {
                new string[] { "A) Nil", "B) Amazona", "C) Misisipi" },                     
                new string[] { "A) Leonardo da Vinci", "B) Pablo Picasso", "C) Van Gogh" },
                new string[] { "A) LG", "B) Sony", "C) Samsung" },                          
                new string[] { "A) H2O", "B) CO2", "C) O2" },                               
                new string[] { "A) Srce", "B) Jetra", "C) Koža" },                          
                new string[] { "A) 365", "B) 364", "C) 366" },                              
                new string[] { "A) Šator", "B) Iglo", "C) Koliba" },                        
                new string[] { "A) 8", "B) 6", "C) 7" },                                    
                new string[] { "A) Januar", "B) Februar", "C) Svi mjeseci" },               
                new string[] { "A) Porto", "B) Madrid", "C) Lisabon" },                    
                new string[] { "A) 10.000", "B) 20.000", "C) 5.000" },                     
                new string[] { "A) Fe", "B) Au", "C) Ag" },                              
                new string[] { "A) Bio je to mračan dan...", "B) Nazovite me Ishmael", "C) Jednom davno..." }, 
                new string[] { "A) Pčelinji kolibri", "B) Vrabac", "C) Lastavica" },
                new string[] { "A) Barbara Roberts", "B) Betty Millicent Roberts", "C) Barbara Millicent Roberts" },
                new string[] { "A) Najglasnije vikanje", "B) Najglasniji smijeh", "C) Najglasnije podrigivanje" },
                new string[] { "A) Cvijeće i drveće", "B) Pinokio", "C) Snjeguljica" },
                new string[] { "A) 1975", "B) 1969", "C) 1972" }, 
                new string[] { "A) Tom Hanks", "B) Brad Pitt", "C) Leonardo DiCaprio" },
                new string[] { "A) Dva", "B) Jedno", "C) Tri" }
            };
        }

        public static List<string> GetCorrectAnswers()
        {
            return new List<string>
            {
               "A", 
                "A", 
                "C", 
                "A", 
                "C", 
                "A", 
                "B", 
                "A", 
                "C", 
                "C", 
                "B", 
                "C", 
                "B", 
                "A", 
                "C", 
                "C", 
                "A", 
                "C", 
                "A", 
                "C"
            };
        }
    }

}
