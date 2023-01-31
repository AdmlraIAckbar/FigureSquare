using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureSquare.Figures
{
    /// <summary>
    /// интерфейс абстрактной фигуры
    /// </summary>
    public interface IFigure
    {
        /// <summary>
        /// получение площади фигуры
        /// </summary>
        /// <returns></returns>
        public double GetArea();
    }
}
