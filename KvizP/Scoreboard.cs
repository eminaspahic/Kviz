using System;
using System.Collections.Generic;
using System.Text;

namespace KvizP
{
    internal class Score
    {
        public string PlayerName { get; set; }
        public int Points { get; set; }
        public string Mode { get; set; }

        public static List<Score> AllScores = new List<Score>();

        public Score(string playerName, string mode)
        {
            PlayerName = playerName;
            Mode = mode;
            Points = 0;
        }

        public void AddPoint()
        {
            Points++;
        }

        
        public void Save()
        {
            AllScores.Add(this);
        }
    }


}
