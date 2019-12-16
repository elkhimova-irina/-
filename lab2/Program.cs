using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab2
{
    public interface IPrint
    {
        void Print();
    }

    public abstract class GeomFigura : IComparable
    {
        public string Figura { get; protected set; }

        public abstract double Area();
        public override string ToString()
        {
            return this.Figura + " площадью " + this.Area().ToString();
        }

        public int CompareTo(object f2)
        {
            GeomFigura f1 = (GeomFigura)f2;
            if (this.Area() < f1.Area())
                return -1;
            else
            if (this.Area() == f1.Area())
                return 0;
            else
                return 1;
        }
    }


    public class Rect : GeomFigura, IPrint
    {
        double height;
        double width;
        public Rect(double height, double width)
        {
            this.height = height;
            this.width = width;
            this.Figura = "Прямоугольник";
        }
        public override double Area()
        {
            return this.width * this.height;
        }
        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }

    public class Circle : GeomFigura, IPrint
    {
        double radius;
        public Circle(double pr)
        {
            this.radius = pr;
            this.Figura = "Круг";
        }

        public override double Area()
        {
            double Result = Math.PI * this.radius * this.radius;
            return Result;
        }
        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }


    public class Square : Rect, IPrint
    {
        public Square(double size)
            : base(size, size)
        {
            this.Figura = "Квадрат";
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Console.Title = ("Elkhimova-irina ICS5-33B");
            Rect rect = new Rect(5, 4);
            rect.Print();
            Square square = new Square(10);
            square.Print();
            Circle circle = new Circle(3);
            circle.Print();
            Console.ReadKey();
        }
    }
}

