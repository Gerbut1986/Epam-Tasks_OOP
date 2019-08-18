#region Description:
/*
 Реалізувати клас ComplexNumber. 
 Перегрузити операції множення та ділення для комплексних чисел.
 Розділити створений клас на логічні регіони (#region).
 */
#endregion
namespace Tasks_1_Classes
{
    public class ComplexNumber
    {
        #region Fields (Real and Imagionary of a part of the Complex number):
        double realNumb, imagionary;
        #endregion

        #region Properties to get access to fields:
        public double RealNumber
        {
            get { return realNumb; }
            set { realNumb = value; }
        }
        public double Imagionary { get { return imagionary; } set { imagionary = value; } }
        #endregion

        #region Constructor w/ parameters:
        public ComplexNumber(double realNumb = 0.0, double imagionary = 0.0)
        {
            this.realNumb = realNumb;
            this.imagionary = imagionary;
        }
        #endregion

        #region Overload of operators:
        public static ComplexNumber operator *(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(c1.realNumb * c2.realNumb, c1.imagionary * c2.imagionary);
        }

        public static ComplexNumber operator /(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(c1.realNumb / c2.realNumb, c1.imagionary / c2.imagionary);
        }
        #endregion

        #region The Represent an object(output):
        public override string ToString()
        {

            return string.Format(" ({0}, {1})", realNumb, imagionary);
        }
        #endregion
    }
}