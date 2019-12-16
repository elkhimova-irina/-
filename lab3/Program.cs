using System;
using System.Collections.Generic;
using System.Collections;
using lab2;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = ("Elkhimova-irina ICS5-33B");
            Rect rect = new Rect(5, 4);
            Square square = new Square(10);
            Circle circle = new Circle(3);
           // circle.Print();

            Console.WriteLine("\nArrayList");
            ArrayList ar = new ArrayList();
            ar.Add(circle);
            ar.Add(rect);
            ar.Add(square);

            foreach (var x in ar) Console.WriteLine(x);

            Console.WriteLine("\nArrayList - сортировка");
            ar.Sort();
            foreach (var x in ar) Console.WriteLine(x);

            Console.WriteLine("\nList<GeomFigura>");
            List<GeomFigura> figuraList = new List<GeomFigura>();
            figuraList.Add(circle);
            figuraList.Add(rect);
            figuraList.Add(square);

            foreach (var x in figuraList) Console.WriteLine(x);

            Console.WriteLine("\nList<AbstractFigure> - сортировка");
            ar.Sort();

            foreach (var x in ar) Console.WriteLine(x);
     

                   Console.WriteLine("\nMatrix<GeomFigure>");
                   Matrix<GeomFigura> matrix = new Matrix<GeomFigura>(2, 2, 2, square);
                   Console.WriteLine(matrix.ToString());

                   Console.WriteLine("SimpleList<GeomFigura>");
                   SimpleList<GeomFigura> list = new SimpleList<GeomFigura>();
                   list.Add(square);
                   list.Add(rect);
                   list.Add(circle);

                   foreach (var x in list) Console.WriteLine(x);

                   Console.WriteLine("\nSimpleList<GeomFigura> - отсортированный");
                   list.Sort();

                   foreach (var x in list) Console.WriteLine(x);


                   Console.WriteLine("\nSimpleStack<GeomFigure>");
                   SimpleStack<GeomFigura> stack = new SimpleStack<GeomFigura>();
                   stack.Push(rect);
                   stack.Push(square);
                   stack.Push(circle);

                   while (stack.Count > 0)
                   {
                       GeomFigura f = stack.Pop();
                       Console.WriteLine(f);
                   }
                   Console.ReadKey();
        } 
    }
}
    


