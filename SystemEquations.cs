using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using System.Text;

namespace Lab1_OOP
{
    internal class SystemEquations
    {
        private double[,] k = new double[2, 3];
        public double this[int equation, int k1]
        {
            get
            {
                if (equation >= 0 && equation < 2 && k1 >= 0 && k1 < 3)
                {
                    return k[equation, k1];
                }
                return 0;
            }
            set
            {
                if (equation >= 0 && equation < 2 && k1 >= 0 && k1 < 3)
                {
                    k[equation, k1] = value;
                }
            }
        }
        public void Input()
        {
            Console.WriteLine("Перше рівняння:");
            Console.Write("a1 = ");
            k[0, 0] = Convert.ToDouble(Console.ReadLine());
            Console.Write("b1 = ");
            k[0, 1] = Convert.ToDouble(Console.ReadLine());
            Console.Write("c1 = ");
            k[0, 2] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Друге рівняння:");
            Console.Write("a2 = ");
            k[1, 0] = Convert.ToDouble(Console.ReadLine());
            Console.Write("b2 = ");
            k[1, 1] = Convert.ToDouble(Console.ReadLine());
            Console.Write("c2 = ");
            k[1, 2] = Convert.ToDouble(Console.ReadLine());
        }
        public void Output()
        {
            Console.WriteLine($"Перше рівняння: {k[0, 0]}x + {k[0, 1]}y = {k[0, 2]}");
            Console.WriteLine($"Друге рівняння: {k[1, 0]}x + {k[1, 1]}y = {k[1, 2]}");
        }
        public bool Solve(out double x, out double y)
        {
            double a1 = k[0, 0];
            double b1 = k[0, 1];
            double c1 = k[0, 2];
            double a2 = k[1, 0];
            double b2 = k[1, 1];
            double c2 = k[1, 2];
            double determinant = a1 * b2 - a2 * b1;
            if (determinant == 0)
            {
                x = 0;
                y = 0;
                return false;
            }
            else
            {
                x = (c1 * b2 - c2 * b1) / determinant;
                y = (a1 * c2 - a2 * c1) / determinant;
                return true;
            }

        }
        public bool IsSolved(double x, double y)
        {
            double left1 = k[0, 0] * x + k[0, 1] * y;
            double left2 = k[1, 0] * x + k[1, 1] * y;
            return Math.Abs(left1 - k[0, 2]) < 0.000001 && Math.Abs(left2 - k[1, 2]) < 0.000001;
        }
    


    }
}
