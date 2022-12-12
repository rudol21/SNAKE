using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSnake
{
    internal class Scene
    {
        int level, lives;
        Rectangle[,] rectangles;
        public Scene(int level = 1, int lives = 3)
        {
            this.level = level;
            this.lives = lives;
 

            int x = Console.LargestWindowWidth;
            int y = Console.LargestWindowHeight;
            rectangles = new Rectangle[x, y];
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    rectangles[i, j] = new Rectangle(i, j, ConsoleColor.Black);
                }
            }
            for (int i = 0; i < x; i++)
            {
                rectangles[i, 0].Color = ConsoleColor.Green;
                rectangles[i, 0].Value = true;
                rectangles[i, 1].Color = ConsoleColor.Gray;
                rectangles[i, 1].Value = true;
                rectangles[i, y - 1].Color = ConsoleColor.Gray;
                rectangles[i, y - 1].Value = true;
            }
            for (int i = 2; i < y; i++)
            {
                rectangles[0, i].Color = ConsoleColor.Gray;
                rectangles[0, i].Value = true;
                rectangles[1, i].Color = ConsoleColor.Gray;
                rectangles[1, i].Value = true;
                rectangles[x - 1, i].Color = ConsoleColor.Gray;
                rectangles[x - 1, i].Value = true;
                rectangles[x - 2, i].Color = ConsoleColor.Gray;
                rectangles[x - 2, i].Value = true;
            }

        }
        public Rectangle getRectangle(Coordinates par)
        {
            return rectangles[par.x, par.y];
        }


        public void setScene()
        {
            
            switch(this.level)
            {
                case 1:
                    for (int i = 0; i < 15; i++)
                    {
                        rectangles[i + 70, 19].Color = ConsoleColor.Gray;
                        rectangles[i + 70, 19].Value = true;
                        rectangles[i + 70, 20].Color = ConsoleColor.Gray;
                        rectangles[i + 70, 20].Value = true;
                    }
                    break;
                case 2:
                    for (int i = 0; i < 15; i++)
                    {
                        rectangles[i+70, 19].Color = ConsoleColor.Gray;
                        rectangles[i + 70, 19].Value = true;
                        rectangles[i+70, 20].Color = ConsoleColor.Gray;
                        rectangles[i + 70, 20].Value = true;

                        rectangles[i + 15, 10].Color = ConsoleColor.Gray;
                        rectangles[i + 15, 10].Value = true;
                        rectangles[i + 15, 11].Color = ConsoleColor.Gray;
                        rectangles[i + 15, 11].Value = true;
                    }
                    break;
                case 3:
                    for (int i = 0; i < 15; i++)
                    {
                        rectangles[i + 70, 19].Color = ConsoleColor.Gray;
                        rectangles[i + 70, 19].Value = true;
                        rectangles[i + 70, 20].Color = ConsoleColor.Gray;
                        rectangles[i + 70, 20].Value = true;

                        rectangles[i + 15, 10].Color = ConsoleColor.Gray;
                        rectangles[i + 15, 10].Value = true;
                        rectangles[i + 15, 11].Color = ConsoleColor.Gray;
                        rectangles[i + 15, 11].Value = true;

                        rectangles[i + 50, 35].Color = ConsoleColor.Gray;
                        rectangles[i + 50, 35].Value = true;
                        rectangles[i + 50, 36].Color = ConsoleColor.Gray;
                        rectangles[i + 50, 36].Value = true;
                    }
                    break;


            }
        }
        public void drawScene()
        {
            int x = Console.LargestWindowWidth;
            int y = Console.LargestWindowHeight;

           /* for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.BackgroundColor = rectangles[i,j].Color;
                    Console.CursorTop = j;
                    Console.CursorLeft = i;                     
                    Console.Write(" \b" );
                    

                }
            }*/
            for (int i = x-1; i >= 0; i--)
            {
                for (int j = y-1; j >= 0; j--)
                {
                    if (rectangles[i, j].Value)
                    {
                        Console.BackgroundColor = rectangles[i, j].Color;
                        Console.CursorTop = j;
                        Console.CursorLeft = i;
                        Console.Write(" ");
                    }
                }
            }
            Console.CursorTop = 0;
            Console.CursorLeft = 0;
            Console.Write("LEVEL:" + this.level);
            Console.CursorLeft = 102;
            Console.Write("LIVES:" + this.lives);
            Console.CursorLeft = 203;
            Console.Write("SCORE:0");
        }
        public Rectangle makeFood()
        {
            Random rnd = new Random();
            int x,y;
            label:
            do
            {
                x = rnd.Next(2, Console.LargestWindowWidth - 4);
            } while (x % 2 != 0);
            y = rnd.Next(2, Console.LargestWindowHeight - 2);

            if (!rectangles[x, y].Value)
            {
                rectangles[x, y].Value = true;
                Console.BackgroundColor = ConsoleColor.Green;
                Console.CursorTop = y;
                Console.CursorLeft = x;
                Console.Write("  ");

            }
            else
                goto label;
            return rectangles[x, y];
        }
    }
}
