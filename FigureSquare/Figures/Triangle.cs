using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureSquare.Figures
{
    public class Triangle : IFigure
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }
        /// <summary>
        /// получение периметра
        /// </summary>
        /// <returns></returns>
        public double GetPerimiter()
        {
            return A + B + C;
        }
        public double GetArea()
        {
            var p = GetPerimiter() / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
        /// <summary>
        /// Проверка на то, является ли треугольник прямоугольным
        /// </summary>
        /// <returns></returns>
        public bool IsRightTriangle()
        {
            var max = Math.Max(Math.Max(A, B), C);
            var min = Math.Min(Math.Min(A, B), C);
            var mid = A + B + C - max - min;
            return min * min + mid * mid == max * max;
        }
    }
}
