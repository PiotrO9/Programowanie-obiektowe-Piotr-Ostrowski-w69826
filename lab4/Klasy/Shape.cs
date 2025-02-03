using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4.Klasy
{
    public class Shape
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }

        public virtual void Draw()
        {
            Console.WriteLine("Rysowanie kształtu...");
        }

        public class Rectangle : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("Rysowanie prostokąta.");
            }
        }

        public class Triangle : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("Rysowanie trójkąta.");
            }
        }

        public class Circle : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("Rysowanie koła.");
            }
        }
    }
}
