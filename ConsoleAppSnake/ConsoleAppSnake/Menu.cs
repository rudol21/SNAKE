using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSnake
{
    internal class Menu
    {
        public Menu()
        {

        }
        public int enterMenu()
        {
            int aux = 3;
            int index = 0;
            Console.CursorVisible = false;
            Console.Clear();
            Console.CursorTop = 15;
            Console.CursorLeft = 69;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("PLAY GAME");
            Console.CursorLeft = 103;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("HIGHEST SCORE");
            Console.CursorLeft = 144;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("EXIT");
            do
            {
                
                ConsoleKey charValue = Console.ReadKey(true).Key;
                switch (charValue)
                {
                    case ConsoleKey.LeftArrow:
                        if (index > 0)
                            index--;
                        break;
                    case ConsoleKey.RightArrow:
                        if (index < 2)
                            index++;
                        break;
                }
                switch (index)
                {
                    case 0:
                        Console.CursorLeft = 69;
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.Write("PLAY GAME");
                        Console.CursorLeft = 103;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write("HIGHEST SCORE");
                        aux = 1;
                        break;
                    case 1:
                        Console.CursorLeft = 69;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write("PLAY GAME");
                        Console.CursorLeft = 103;
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.Write("HIGHEST SCORE");
                        Console.CursorLeft = 144;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write("EXIT");
                        aux = 2;
                        break;
                    case 2:
                        Console.CursorLeft = 103;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write("HIGHEST SCORE");
                        Console.CursorLeft = 144;
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.Write("EXIT");
                        Console.BackgroundColor = ConsoleColor.Black;
                        aux = 3;
                        break;
                }
                if (charValue == ConsoleKey.Enter)
                    return aux;

            } while (true);
        }
        public int recordsMenu()
        {
            int aux = 3;
            int index = 0;
            Console.CursorVisible = false;
            Console.Clear();
            Console.CursorTop = 15;
            Console.CursorLeft = 69;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("SORT BY DATE");
            Console.CursorLeft = 103;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("SORT BY NAME");
            Console.CursorLeft = 144;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("SORT BY SCORE");
            do
            {

                ConsoleKey charValue = Console.ReadKey(true).Key;
                switch (charValue)
                {
                    case ConsoleKey.LeftArrow:
                        if (index > 0)
                            index--;
                        break;
                    case ConsoleKey.RightArrow:
                        if (index < 2)
                            index++;
                        break;
                }
                switch (index)
                {
                    case 0:
                        Console.CursorLeft = 69;
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.Write("SORT BY DATE");
                        Console.CursorLeft = 103;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write("SORT BY NAME");
                        aux = 1;
                        break;
                    case 1:
                        Console.CursorLeft = 69;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write("SORT BY DATE");
                        Console.CursorLeft = 103;
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.Write("SORT BY NAME");
                        Console.CursorLeft = 144;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write("SORT BY SCORE");
                        aux = 2;
                        break;
                    case 2:
                        Console.CursorLeft = 103;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write("SORT BY NAME");
                        Console.CursorLeft = 144;
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.Write("SORT BY SCORE");
                        Console.BackgroundColor = ConsoleColor.Black;
                        aux = 3;
                        break;
                }
                if (charValue == ConsoleKey.Enter)
                    return aux;

            } while (true);
        }
        public string getPlayerName()
        {
            Console.CursorVisible = true;
            Console.Clear();
            Console.CursorTop = 15;
            Console.CursorLeft = 80;
            Console.Write("ENTER NAME: ");
            Console.BackgroundColor = ConsoleColor.Black;
            string name = Console.ReadLine();
            return name;
        }
        /*public Boolean numberOfPlayer()
        {
            Boolean singlePlayer = true;
            Console.CursorVisible = false;
            Console.Clear();
            Console.CursorTop = 15;
            Console.CursorLeft = 80;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("ONE PLAYER");
            Console.CursorLeft = 103;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("TWO PLAYERS");
            do
            {
                ConsoleKey charValue = Console.ReadKey(true).Key;

                switch (charValue)
                {
                    case ConsoleKey.LeftArrow:
                        Console.CursorTop = 15;
                        Console.CursorLeft = 80;
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.Write("ONE PLAYER");
                        Console.CursorLeft = 103;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write("TWO PLAYERS");
                        singlePlayer = true;
                        break;
                    case ConsoleKey.RightArrow:
                        Console.CursorTop = 15;
                        Console.CursorLeft = 103;
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.Write("TWO PLAYERS");
                        Console.CursorLeft = 80;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write("ONE PLAYER");
                        singlePlayer = false;
                        break;
                }
                if (charValue == ConsoleKey.Enter)
                    return singlePlayer;

            } while (true);
        }*/

        public int difficulty()
        {
            int aux = 1;
            int index = 0;
            Console.Clear();
            Console.CursorVisible = false;
            Console.CursorTop = 15;
            Console.CursorLeft = 69;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("EASY");
            Console.CursorLeft = 103;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("MEDIUM");
            Console.CursorLeft = 144;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("HARD");
            do
            {
                ConsoleKey charValue = Console.ReadKey(true).Key;

                switch (charValue)
                {
                    case ConsoleKey.LeftArrow:
                        if (index > 0)
                            index--;
                        break;
                    case ConsoleKey.RightArrow:
                        if(index<2)
                            index++;    
                        break;
                }
                switch(index)
                {
                    case 0:
                        Console.CursorLeft = 69;
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.Write("EASY");
                        Console.CursorLeft = 103;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write("MEDIUM");
                        aux = 1;
                        break;
                    case 1:
                        Console.CursorLeft = 69;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write("EASY");
                        Console.CursorLeft = 103;
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.Write("MEDIUM");
                        Console.CursorLeft = 144;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write("HARD");
                        aux = 2;
                        break;
                    case 2:
                        Console.CursorLeft = 103;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write("MEDIUM");
                        Console.CursorLeft = 144;
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.Write("HARD");
                        Console.BackgroundColor = ConsoleColor.Black;
                        aux = 3;
                        break;
                }
                if (charValue == ConsoleKey.Enter)
                    return aux;

            } while (true);
        }
    }
}
