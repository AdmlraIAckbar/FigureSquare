using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureSquare.Figures
{
    /// <summary>
    /// круг
    /// </summary>
    public class Circle : IFigure
    {
        /// <summary>
        /// радиус
        /// </summary>
        public double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
