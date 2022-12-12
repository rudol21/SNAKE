using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSnake
{
    internal class Snake
    {
        ArrayList snake = new ArrayList();
        int direction;//0-right,1-up,2-left,3-down
        public Snake()
        {
            direction = 0;
            Rectangle rec1 = new Rectangle(6, 5, ConsoleColor.DarkMagenta);
            Rectangle rec2 = new Rectangle(4, 5, ConsoleColor.DarkRed);
            Rectangle rec3 = new Rectangle(2, 5, ConsoleColor.DarkRed);
            snake.Add(rec1);
            snake.Add(rec2);
            snake.Add(rec3);
        }
        ~Snake()
        {

        }
        public int Direction
        {
            get { return direction;}
            set { direction = value;}
        }
        public Rectangle update()
        {

            int aux = this.snake.Count;
            int x = ((Rectangle)this.snake[0]).X;
            int y = ((Rectangle)this.snake[0]).Y;

            switch (direction)
            {
                case 0:
                    ((Rectangle)this.snake[0]).X += 2; 
                    break;
                case 1:
                    ((Rectangle)this.snake[0]).Y -= 1;
                    break;
                case 2:
                    ((Rectangle)this.snake[0]).X -= 2;
                    break;
                case 3:
                    ((Rectangle)this.snake[0]).Y += 1;
                    break; 
            }

            Console.BackgroundColor = ConsoleColor.Black;
            Console.CursorTop = ((Rectangle)this.snake[aux - 1]).Y;
            Console.CursorLeft = ((Rectangle)this.snake[aux - 1]).X;
            Console.Write("  ");

            for (int i = aux-1; i > 1; i--)
            {
                ((Rectangle)this.snake[i]).X = ((Rectangle)this.snake[i - 1]).X;
                ((Rectangle)this.snake[i]).Y = ((Rectangle)this.snake[i - 1]).Y;
            }
            ((Rectangle)this.snake[1]).X = x;
            ((Rectangle)this.snake[1]).Y = y;
            return (Rectangle)this.snake[0];
            /*
            ArrayList auxSnake = new ArrayList();
            auxSnake.Add(this.snake[0]);

            Console.BackgroundColor = ConsoleColor.Black;
            Console.CursorTop = ((Rectangle)this.snake[aux - 1]).Y;
            Console.CursorLeft = ((Rectangle)this.snake[aux - 1]).X;
            Console.Write("  ");

            ((Rectangle)this.snake[aux - 1]).X = x;
            ((Rectangle)this.snake[aux - 1]).Y = y;

            auxSnake.Add(this.snake[aux - 1]);
           ((Rectangle)auxSnake[1]).Color = ConsoleColor.DarkRed;
            foreach (Rectangle i in this.snake.GetRange(1, aux - 2))
            {
                auxSnake.Add(i);
            }
            this.snake.Clear();
            this.snake = auxSnake;*/


        }
        public void drawSnake()
        {
            foreach (Rectangle i in this.snake)
            {
                Console.BackgroundColor = i.Color;
                Console.CursorTop = i.Y;
                Console.CursorLeft = i.X;
                Console.Write("  ");
            }
        }
        public void setBigger()
        {
            
            int aux = this.snake.Count;
            int x1 = ((Rectangle)this.snake[aux - 1]).X;
            int y1 = ((Rectangle)this.snake[aux - 1]).Y;
            int x2 = ((Rectangle)this.snake[aux - 2]).X;
            int y2 = ((Rectangle)this.snake[aux - 2]).Y;
            int x = x1;
            int y = y1;
            if (x1 == x2)
            {
                if (y1 > y2)
                    y += 2;
                if (y1 < y2)
                    y -= 2;               
            }else if(y1 == y2)
            {
                if (x1 > x2)
                    x += 2;
                if (x1 < x2)
                    x -= 2;
            }
            
            Rectangle rec = new Rectangle(x, y, ConsoleColor.DarkRed);
            this.snake.Add(rec);
            
        }
        public void setSmaller()
        {
            int aux = this.snake.Count;
            this.snake.RemoveAt(aux -1);
        }
    }
}




