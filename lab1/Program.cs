
using System;
using System.Text;




namespace lab1
{

    class Program
    {
        static void Main(string[] args)
        {
        
            bool Ac = false;
            bool Bc = false;
            bool Cc = false;
            double A = 0;
            double B = 0;
            double C = 0;
           Console.Title = ("Elkhimova-irina ICS5-33B");


            if (args != null && args.Length == 3)
            {
                Ac = double.TryParse(args[0], out A);
                Bc = double.TryParse(args[1], out B);
                Cc = double.TryParse(args[2], out C);
            }

            if (!Ac || !Bc || !Cc)
            {
                if (!Ac)
                 A =ReadDouble("Write coefficient A: ");
                if(!Bc)
                 B = ReadDouble("Write coefficient B: ");
                if(!Cc)
                 C = ReadDouble("Write coefficient C: ");
            }

            if (A == 0)
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No real roots\n");

            }
            else
              if (B == 0)
            {
                if ((-C / A) > 0)
                {
                    double y = Math.Sqrt(-C / A);
                    double x1 = Math.Sqrt(y);
                    double x2 = -Math.Sqrt(y);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Real root 1: " + x1);
                    Console.WriteLine("Real root 2: " + x2 + "\n");
                }
                else
                      if ((-C / A) == 0)
                {
                    double x = 0;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Real root: " + x + "\n");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("No real roots\n");
                }
            }

            else
            {
                double dis = System.Math.Pow(B, 2) - 4 * A * C;



                if (dis > 0)
                {
                    double y1 = (-B + Math.Sqrt(dis)) / (2 * A);
                    double y2 = (-B - Math.Sqrt(dis)) / (2 * A);

                    if ((y1 == 0) && (y2 == 0))
                    {
                        double x = 0;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Real root: " + x + "\n");
                    }
                    else if ((y1 == 0) && (y2 != 0))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        double x = 0;
                        if (y2 > 0)
                        {
                            double x2 = -Math.Sqrt(y2);
                            double x3 = Math.Sqrt(y2);
                            Console.WriteLine("Real root 1: " + x + "\n");
                            Console.WriteLine("Real root 2: " + x2 + "\n");
                            Console.WriteLine("Real root 3: " + x3 + "\n");
                        }
                        else
                            Console.WriteLine("Real root: " + x + "\n");
                    }
                    else if ((y1 != 0) && (y2 == 0))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        double x = 0;
                        if (y1 > 0)
                        {
                            double x2 = -Math.Sqrt(y1);
                            double x3 = Math.Sqrt(y1);
                            Console.WriteLine("Real root 1: " + x + "\n");
                            Console.WriteLine("Real root 2: " + x2 + "\n");
                            Console.WriteLine("Real root 3: " + x3 + "\n");
                        }
                        else
                            Console.WriteLine("Real root: " + x + "\n");
                    }

                    else if ((y1 < 0) && (y2 < 0))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("No real roots\n");
                    }
                    else
                    {

                        double x1 = Math.Sqrt(y1);
                        double x2 = -Math.Sqrt(y1);
                        double x3 = Math.Sqrt(y2);
                        double x4 = -Math.Sqrt(y2);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Real root 1: " + x1 + "\n");
                        Console.WriteLine("Real root 2: " + x2 + "\n");
                        Console.WriteLine("Real root 3: " + x3 + "\n");
                        Console.WriteLine("Real root 4: " + x4 + "\n");
                    }
                }
                else if (dis == 0)
                {
                    double y = (-B / (2 * A));
                    if (y > 0)
                    {
                        double x1 = Math.Sqrt(y);
                        double x2 = -Math.Sqrt(y);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Real root 1: " + x1 + "\n");
                        Console.WriteLine("Real root 2: " + x2 + "\n");
                    }
                    else
                        if (y == 0)
                    {
                        double x = 0;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Real root: " + x + "\n");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("No real roots\n");
                    }

                }
                else
                {

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("No real roots\n");
                }

                Console.ReadLine();
            }
        }

        static double ReadDouble(string message)
        {
            string resultString;
            double resultDouble;
            bool flag;

            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(message);

                resultString = Console.ReadLine();

                flag = double.TryParse(resultString, out resultDouble);
                if (!flag)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Coefficient entered incorrectly!");
                }

            }
            while (!flag);

            return resultDouble;
        }

    }
}
