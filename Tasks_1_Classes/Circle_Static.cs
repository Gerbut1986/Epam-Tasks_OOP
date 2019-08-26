/*
   Реалізувати завдання 1 та 3 використовуючи статичні класи. 
   Kоординати точок для класу Rectangle передавати параметрими в відповідні методи.
*/
namespace Tasks_1_Classes
{
    public static class Circle_Static
    {
        const double Pi = 3.14159;
        static double radius;

        public static void SetRadius(double r = 0.0) => radius = r;

        public static double Length_Circle => 2 * Pi * radius;

        public static double Area => Pi * radius * radius;
    }
}
