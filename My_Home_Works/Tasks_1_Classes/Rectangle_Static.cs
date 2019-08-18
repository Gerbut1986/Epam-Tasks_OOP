/*
   Реалізувати завдання 1 та 3 використовуючи статичні класи. 
   Kоординати точок для класу Rectangle передавати параметрими в відповідні методи.
*/
namespace Tasks_1_Classes
{
    public static class Rectangle_Static
    {
        static Point leftUp, rightLow;

        public static void SetCoordinates(Point l, Point r)
        {
            leftUp.X = l.X;
            leftUp.Y = l.Y;
            rightLow.X = r.X;
            rightLow.Y = r.Y;
        }

        public static double Perimeter()
        {
            return AbsoluteNumber(leftUp.X - rightLow.X) * 2 +
                   AbsoluteNumber(leftUp.Y - rightLow.Y) * 2;
        }

        public static double Area()
        {
            return AbsoluteNumber(leftUp.X - rightLow.X) *
                   AbsoluteNumber(leftUp.Y - rightLow.Y);
        }

        static double AbsoluteNumber(double number)
        {
            return (number <= 0.0) ? 0.0 - number : number;
        }
    }
}
