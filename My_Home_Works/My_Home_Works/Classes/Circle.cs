using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Home_Works.Classes
{
    /*
     Не використовуючи System.Math реалізувати клас Circle з методами, що позволяють 
     обрахувати довжину кола та прощу круга. Радіус передається параметром в відповідний метод.
     Константи для підрахунків повинні знаходитись в класі Circle.
     */
    class Circle
    {
        const double Pi = 3.14159;
        double radius;

        public Circle(double radius = 0.0)
        {
            this.radius = radius;
        }

        public double Length_Circle()
        {
            return 2 * Pi * radius;
        }

        public double Area() 
        { 
            return Pi * radius * radius;
        }
    }
}
