using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Parallelogram:GeoFigure
    {
        public double _sideA { get; set; }  // сторона А
        public double _sideB { get; set; }  // сторона В


        public Parallelogram(string figure, double sideA , double height) : base(figure) // для площади
        {
            _sideA = sideA;
            _height = height; // прописуем в конструктор тут а объявляем в Figure 
        }


        //public Parallelogram(string figure, double sideA, double sideB) : base(figure) // для периметра ругается
        //{
        //    _sideA = sideA;
        //    _sideB = sideB;
        //}

        public Parallelogram(string figure, double sideA, double height , double sideB) : base(figure) //для всего
        {
            _sideA = sideA;
            _sideB = sideB;
            _height = height;
        }
       

        public override double Area()
        {
            return Square = _sideA * _height;
        }

        public override double Perimeter()
        {
            return _perimeter = 2 * (_sideA + _sideB);
        }

        public override void Print()
        {
            Console.WriteLine($"Площадь параллелограмма {Area()} \n периметр параллелограмма {Perimeter()} \n");
        }
    }
}
