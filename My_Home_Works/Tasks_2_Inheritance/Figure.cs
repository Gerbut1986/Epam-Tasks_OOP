#region Description:
/*
   1. Реалізувати базовий клас Figure з абстрактним методом Draw(). 
      Створити класи Square та Rectangle (унаслідовані від Figure) в яких перегружена імплементація методу Draw() 
      виводить на консоль назву класу в якому даний метод реалізований.
*/
#endregion
namespace Tasks_2_Inheritance
{
    public abstract class Figure
    {
        public abstract void Draw();
    }
}
