using FigureSquare.Figures;

namespace UnitTestProject
{
    public class FiguresUnitTests
    {
        /// <summary>
        /// ���� ���������� ������� �����
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
        /// ���� ���������� ������� ������������
        /// </summary>
        [Fact]
        public void TriangleAreaTest()
        {
            var triangle = new Triangle(3,4,5);
            var area = triangle.GetArea();
            Assert.Equal(6, area);
        }
        /// <summary>
        /// �������� ������������ �� ��������������
        /// </summary>
        [Fact]
        public void RightTriangleTest()
        {
            var triangle = new Triangle(3, 4, 5);
            var isRight = triangle.IsRightTriangle();
            Assert.True(isRight);
        }
        /// <summary>
        /// �������� ������(���� ��� �����������)
        /// </summary>
        /// <returns></returns>
        private IFigure getfigure()
        {
            // c ������� �������� 50/50 ���������� ��� ���� ��� �����������
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
        /// ���� Ifigure (���������� ������� ������ ��� ������ ���� ������ � compile-time )
        /// </summary>
        [Fact]
        public void FigureAreaTest()
        {
            var figure = getfigure();

            var area = figure.GetArea();

            /// ��������� ������� ������ �� ��������� ������� ������������ ��� �����
            Assert.True(area == 6 || area == Math.PI*100);
        }
    }
}