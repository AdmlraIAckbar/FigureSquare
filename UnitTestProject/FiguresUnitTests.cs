using FigureSquare.Figures;

namespace UnitTestProject
{
    public class FiguresUnitTests
    {
        /// <summary>
        /// тест вычисления площади круга
        /// </summary>
        [Fact]
        public void CircleAreaTest()
        {
            var r = 10;
            var circle = new Circle(r);
            var area = circle.GetArea();
            Assert.Equal(Math.PI*r*r, area);
        }
        /// <summary>
        /// тест вычисления площади треугольника
        /// </summary>
        [Fact]
        public void TriangleAreaTest()
        {
            var triangle = new Triangle(3,4,5);
            var area = triangle.GetArea();
            Assert.Equal(6, area);
        }
        /// <summary>
        /// проверка треугольника на прямоугольнсть
        /// </summary>
        [Fact]
        public void RightTriangleTest()
        {
            var triangle = new Triangle(3, 4, 5);
            var isRight = triangle.IsRightTriangle();
            Assert.True(isRight);
        }
        /// <summary>
        /// получаем фигуру(круг или треугольник)
        /// </summary>
        /// <returns></returns>
        private IFigure getfigure()
        {
            // c щансами примерно 50/50 возвращаем или круг или треугольник
            if (new Random().NextSingle() >= 0.5)
            {
                return new Triangle(3, 4, 5);
            }
            else
            {
                return new Circle(10);
            }
        }
        /// <summary>
        /// тест Ifigure (вычисление площади фигуры без знания типа фигуры в compile-time )
        /// </summary>
        [Fact]
        public void FigureAreaTest()
        {
            var figure = getfigure();

            var area = figure.GetArea();

            /// проверяем площадь фигуры на равенство площади треугольника или круга
            Assert.True(area == 6 || area == Math.PI*100);
        }
    }
}