using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSnake
{
    internal class Rectangle
    {
        Coordinates coordinate;
        ConsoleColor color;
        bool value;

        public Rectangle(int x, int y, ConsoleColor color)
        {
            coordinate = new Coordinates(x, y);
            this.color = color;
            this.value = false;
        }
        public Coordinates Coordinates
        {
            get { return coordinate; }
            set { coordinate = value; }
        }
        public ConsoleColor Color
        {
            get { return color; }
            set { color = value; }
        }
        public bool Value
        {
            get { return value; }   
            set { this.value = value; }
        }
        public int X
        {
           get { return coordinate.X; }
           set { coordinate.X = value; }
        }
        public int Y
        {
            get { return coordinate.Y; }
            set { coordinate.Y = value; }
        }
    }
}
