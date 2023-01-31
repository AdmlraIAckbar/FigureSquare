using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureSquare.Figures
{
    /// <summary>
    /// треугольник
    /// </summary>
    public class Triangle : IFigure
    {
        /// <summary>
        /// сторона A
        /// </summary>
        public double A { get; set; }
        /// <summary>
        /// сторона B
        /// </summary>
        public double B { get; set; }
        /// <summary>
        /// сторона C
        /// </summary>
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
