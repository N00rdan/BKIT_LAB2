using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.Height = 10;
            r.Width = 5;
            r.Print();

            Square s = new Square(5);
            s.Print();

            Circle c = new Circle(8);
            c.Print();
            Console.ReadLine();

        }
    }
}

