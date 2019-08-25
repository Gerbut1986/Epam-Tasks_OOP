using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Home_Works.Classes
{
    /*
    Не використовуючи System.Math реалізувати клас Rectangle з методами, що позволяють обрахувати
    периметр та прощу прямокутника. Кординати лівого верхнього та правого нижнього кута передаються
    параметрими в констуктор класу Rectangle.
     */
    struct Point
    {
        public double X, Y;
    }

    class Rectangle
    {
        Point leftUp, rightLow;

        public Rectangle(Point leftUp, Point rightLow)
        {
            this.leftUp.X = leftUp.X;
            this.leftUp.Y = leftUp.Y;
            this.rightLow.X = rightLow.X;
            this.rightLow.Y = rightLow.Y;
        }

        public double Perimeter()
        {
            return AbsoluteNumber(leftUp.X - rightLow.X) * 2 +
                   AbsoluteNumber(leftUp.Y - rightLow.Y) * 2;
        }

        public double Area()
        {
            return AbsoluteNumber(leftUp.X - rightLow.X) *
                   AbsoluteNumber(leftUp.Y - rightLow.Y);
        }

        double AbsoluteNumber(double number)
        {
            return (number <= 0.0) ? 0.0 - number : number;
        }
    }
}
