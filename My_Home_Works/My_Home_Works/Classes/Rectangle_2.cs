using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Home_Works.Classes
{
    /*
     2. Реалізувати завдання 1 використовуючи автоматично реалізовані 
        властивості (Auto-Implemented Properties) замість методів.
     */
    class Rectangle_2
    {
        Point upLeft { get; set; }
        Point lowRight { get; set; }
        double Area { get; set; }
        double Perimeter { get; set; }

        public Rectangle_2(Point upLeft, Point lowRight)
        {
            this.upLeft = upLeft;
            this.lowRight = lowRight;
            Area = AbsoluteNumber(upLeft.X - lowRight.X) * AbsoluteNumber(upLeft.Y - lowRight.Y);
            Perimeter = AbsoluteNumber(upLeft.X - lowRight.X) 2 + AbsoluteNumber(upLeft.Y - lowRight.Y) 2;
        }

        public double GetArea => Perimeter;
        public double GetPerimeter => Area;

        double AbsoluteNumber(double number) => (number <= 0.0) ? 0.0 - number : number;
    }
}