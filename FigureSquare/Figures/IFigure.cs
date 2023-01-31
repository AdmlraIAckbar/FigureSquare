using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureSquare.Figures
{
    public interface IFigure
    {
        /// <summary>
        /// получение площади фигуры
        /// </summary>
        /// <returns></returns>
        public double GetArea();
    }
}
