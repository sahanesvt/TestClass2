using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClass2
{
    public abstract class Shape
    {
        public virtual double Area { get; protected set; } = 0;
        public virtual double Perimeter { get; protected set; } = 0;

        public Shape() { }

    }

    public class Square : Shape
    {
        private double _width = 0;

        public double Width
        { get { return _width; }
          set
            {
                _width = value;
                calcProperties(_width);
            }
        }

        public Square() { }
        public Square(double width)
        {
            _width = width;
            calcProperties(_width);
        }

        private void area(double width)
        {
            Area = width * width;
        }

        private void perimeter(double width)
        {
            Perimeter = 4 * width;
        }

        private void calcProperties(double width)
        {
            area(width);
            perimeter(width);
        }
    }

    public class Circle : Shape
    {
        private double _radius = 0;

        public double Radius
        {
            get { return _radius; }
            set
            {
                _radius = value;
                calcProperties(_radius);
            }
        }

        public Circle() { }
        public Circle(double radius)
        {
            _radius = radius;
            calcProperties(Radius);
        }

        private void area(double radius)
        {
            Area = Math.Pow(radius,2)*Math.PI;
        }

        private void perimeter(double radius)
        {
            Perimeter = 2*radius*Math.PI;
        }

        private void calcProperties(double radius)
        {
            area(radius);
            perimeter(radius);
        }


    }

}
