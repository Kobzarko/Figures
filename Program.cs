using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            //Triangle triangle = new Triangle("треугольник", 4, 4, 5);
            //triangle.Area();
            //triangle.Perimeter();
            //triangle.PrintFigure();

            //Square square = new Square("квадрат", 4);
            //square.Perimeter();
            //square.Area();
            //square.PrintFigure();

            //Rectangle rectangle = new Rectangle("прямоугольник", 5, 7);
            //rectangle.Perimeter();
            //rectangle.Area();
            //rectangle.PrintFigure();

            //Romb romb = new Romb("ромб", 3, 4, 5);
            //romb.Perimeter();
            //romb.Area();
            //romb.PrintFigure();

            //Parallelogram parallelogram = new Parallelogram("Параллелограмм", 5, 6, 7);
            //parallelogram.Perimeter();
            //parallelogram.Area();
            //parallelogram.PrintFigure();

            //Trapezoid trapezoid = new Trapezoid("Трапеция", 5, 6, 4,7,6.5);
            //trapezoid.Perimeter();
            //trapezoid.Area();
            //trapezoid.PrintFigure();

            //Circle circle = new Circle("круг", 5);
            //circle.Perimeter();
            //circle.Area();
            //circle.PrintFigure();

            //Ellipse ellipse = new Ellipse("Эллипс", 5, 8);
            //ellipse.Perimeter();
            //ellipse.Area();
            //ellipse.PrintFigure();

            double result = 0;
            GeoFigure[] figures =
            {
               new Triangle("треугольник", 4, 4, 5),
               new Square("квадрат", 5),
               new Rectangle("прямоугольник", 5, 7),
               new Romb("ромб", 3, 4, 5),
               new Parallelogram("Параллелограмм", 5, 6, 7),
               new Trapezoid("Трапеция", 5, 6, 4,7,6.5),
               new Circle("круг", 5),
               new Ellipse("Эллипс", 5, 8)
            };
            foreach (GeoFigure item in figures)
            {
                item.PrintFigure();
                result += item.Area();

            }
            Console.WriteLine($" сумма площади фигур {result} см2\n");

            GeoFigure[] geos =
            {
                new Triangle("треугольник", 3, 4, 5),
               new Square("квадрат", 8),
               new Rectangle("прямоугольник", 3, 7)
            };

            SosFigure sos = new SosFigure(geos);

            Console.ReadKey();
                
            



            //SosFigure[] sosFigures = new SosFigure("составная фигура", params GeoFigure[] figures);
            

        }
    }
}
