/*
   2. Використовуючи попереднє завдання добавити в клас Figure readonly проперті X та Y. Також, в клас Figure добавити
   параметризований конструктор що установляє значення в цих пропертях. Поправити унаслідовані класи щоб вони
   коректно працювали викликаючи базовий конструктор.
*/
namespace Tasks_2_Inheritance
{
    public abstract class Figure_Readonly
    {
        protected readonly double X, Y;

        public Figure_Readonly(double x, double y)
        {
            if (x == 0 && y == 0)
            {
                return;
            }

            X = x;
            Y = y;
        }

        public abstract void Draw();
    }
}
