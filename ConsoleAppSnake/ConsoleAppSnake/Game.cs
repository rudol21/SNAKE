using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Collections;
using System.IO;

namespace ConsoleAppSnake
{
    internal class Game
    {
        int skuskaGitu=0;
        Scene scene;
        Snake snake;
        Player player;
        int milliseconds;
        int level;
        ArrayList food = new ArrayList();
        int aux = 0;
        public Game(int level, String name)
        {
            this.scene = new Scene(level);
            this.snake = new Snake();
            this.player = new Player(name,0);
            this.level = level;


            switch (level)
            {
                case 1:
                    milliseconds = 200;
                    aux = 6;
                    break;
                case 2:
                    milliseconds = 150;
                    aux = 4;
                    break;
                case 3:
                    milliseconds = 100;
                    aux = 2;
                    break;
            }
            
        }
        /*public int Score
        {
            get { return score; }
            set { score = value; }
        }*/
        public void drawScore()
        {
            this.player.Score += 10;
            Console.CursorTop = 0;
            Console.CursorLeft = 203;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("SCORE:" + this.player.Score);
        }
        public void playGame()
        {
            
            scene.setScene();
            scene.drawScene();
            snake.drawSnake();

            for(int i = 0; i < aux; i++)
            {
                food.Add(scene.makeFood());  
            } 
        point:
            do
            {
                Rectangle r3 = snake.update();
                if (scene.getRectangle(r3.Coordinates).Value && scene.getRectangle(r3.Coordinates).Color == ConsoleColor.Gray)
                {
                    this.lost();
                    return;                    
                }
               
                for (int i = 0; i < food.Count; i++)
                {
                    if(((Rectangle)food[i]).Coordinates == r3.Coordinates)
                    {
                        snake.setBigger();
                        this.drawScore();
                        ((Rectangle)food[i]).Value = false;
                        food[i] = scene.makeFood();
                    }
                }
                snake.drawSnake();

                Thread.Sleep(milliseconds);
            } while (!Console.KeyAvailable);

            ConsoleKey charValue = Console.ReadKey(true).Key;
            switch (charValue)
            {
                case ConsoleKey.LeftArrow:
                    if (snake.Direction != 0)
                        snake.Direction = 2;
                    break;
                case ConsoleKey.DownArrow:
                    if (snake.Direction != 1)
                        snake.Direction = 3;
                    break;
                case ConsoleKey.RightArrow:
                    if (snake.Direction != 2)
                        snake.Direction = 0;
                    break;
                case ConsoleKey.UpArrow:
                    if (snake.Direction != 3)
                        snake.Direction = 1;
                    break;
                case ConsoleKey.Spacebar:
                    do
                    { }
                    while (!Console.KeyAvailable || !(Console.ReadKey(true).Key == ConsoleKey.Spacebar));                   
                    break;
            }
            goto point;
            Console.ReadKey(true);
        }
        public void lost()
        {
            DateTime dt = new DateTime();
            dt = DateTime.Now;
            using (StreamWriter sw = File.AppendText("TextFileScore.txt"))
            {
                sw.WriteLine(this.player.Name + " " + this.player.Score + " " + dt.ToString());
                sw.Close();
            }
            Console.Clear();
            Console.CursorTop = 24;
            Console.CursorLeft = 100;
            Console.Write("YOU LOST");
            Console.CursorTop = 25;
            Console.CursorLeft = 103;
            Console.Write(player.Score);
            Thread.Sleep(2000);
        }
    }
}
