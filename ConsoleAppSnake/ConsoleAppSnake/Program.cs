using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Threading;
using System.Xml.Linq;
using System.IO;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleAppSnake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int charValue = Console.Read();
            Console.WriteLine(charValue);
            */
            /*
            string writeText = "Hello World!";
            using (StreamWriter sw = File.AppendText("TextFileScore.txt"))
            {
                sw.WriteLine(writeText);
                sw.WriteLine(writeText);
                sw.Close();
            }
            using (StreamReader sr = new StreamReader("TextFileScore.txt"))
            {
                writeText = sr.ReadToEnd();
                sr.Close();
            }*/

            Console.CursorVisible = false;
            Console.Clear();
            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
            Console.SetBufferSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
                      
            Menu menu = new Menu();
            Record rec = new Record();
            Label:
            switch(menu.enterMenu())
            {
                case 1:
                string name = menu.getPlayerName();
                int aux2 = menu.difficulty();
                Game game = new Game(aux2, name);
                Console.Clear();
                game.playGame();
                    break;
                case 2:
                    switch(menu.recordsMenu())
                    {
                        case 1:
                            rec.sortByDate();
                            break;
                        case 2:
                            rec.sortByName();
                            break;
                        case 3:
                            rec.sortByScore();
                            break;
                    }
                    while (Console.ReadKey(true).Key != ConsoleKey.Enter)
                    { }
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
            }
            goto Label;


        }
    }
}
