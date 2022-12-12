using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSnake
{

    internal class Player
    {
        string name;
        int score;
        public Player(string name, int score)
        {
            Name = name;
            Score = score;  
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Score
        {
            get { return score; }
            set { score = value; }
        }
    }
}
