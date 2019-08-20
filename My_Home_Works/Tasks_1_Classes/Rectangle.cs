/*
Не використовуючи System.Math реалізувати клас Rectangle з методами, що позволяють обрахувати
периметр та прощу прямокутника. Кординати лівого верхнього та правого нижнього кута передаються
параметрими в констуктор класу Rectangle.
 */
namespace Tasks_1_Classes
{
    public struct Point
    {
        public double X, Y;
    }

    //public class Rectangle
    //{
    //    Size WH;
    //    double P, S;

    //    public Rectangle(Point leftUp, Point rightLow)
    //    {

    //    }

    //    public double Perimeter => P;
    //    public double Area => S;

    //    public void SetNewSquare(Point lt, Point rb)
    //    {

    //    }
    //}

    public class Rectangle
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
