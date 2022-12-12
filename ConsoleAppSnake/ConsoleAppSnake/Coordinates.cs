using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSnake
{
    internal class Coordinates
    {
        public int x, y;

        public Coordinates(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public static Coordinates operator +(Coordinates c1, Coordinates c2)
        {
            return new Coordinates(c1.x + c2.x, c1.y + c2.y);
        }
        public static Coordinates operator -(Coordinates c1, Coordinates c2)
        {
            return new Coordinates(c1.x - c2.x, c1.y - c2.y);
        }
        public static Coordinates operator *(Coordinates c1, Coordinates c2)
        {
            return new Coordinates(c1.x * c2.x, c1.y * c2.y);
        }
        public static Coordinates operator /(Coordinates c1, Coordinates c2)
        {
            return new Coordinates(c1.x / c2.x, c1.y / c2.y);
        }
        public static bool operator ==(Coordinates c1, Coordinates c2)
        {
            return (c1.x == c2.x) && (c1.y == c2.y);
        }
        public static bool operator !=(Coordinates c1, Coordinates c2)
        {
            return (c1.x != c2.x) && (c1.y != c2.y);
        }
    }
}
