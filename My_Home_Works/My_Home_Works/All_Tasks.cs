﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using My_Home_Works.Classes;

namespace My_Home_Works
{
    class All_Tasks
    {
        public void Task_1()
        {
            Point coordUp, coordLow;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Enter the upper and lower right corner coordinates: ");
            Console.Write("\nInput upper left:\n\nx1:");
            coordUp.X = double.Parse(Console.ReadLine());
            Console.Write("\ny1: ");
            coordUp.Y = double.Parse(Console.ReadLine()); 
            Console.Write("\nInput lower right:\nx2: ");
            coordLow.X = double.Parse(Console.ReadLine());
            Console.Write("\ny2: ");
            coordLow.Y = double.Parse(Console.ReadLine()); 

            Rectangle rect = new Rectangle(coordUp, coordLow);

            Console.ResetColor();
            Console.WriteLine("\nPerimeter of Rectangle is: {0}", rect.Perimeter());
            Console.WriteLine("\nArea of Rectangle is: {0}", rect.Area());
        }


        public void Task_2()
        {
             Point upLeft, lowRight;
            Console.WriteLine("Please input coordinates of an upper left corner:\n");
            Console.Write("X1: ");
            upLeft.X = double.Parse(Console.ReadLine());
            Console.Write("Y1: ");

            Console.WriteLine("Please input coordinates of an lower right corner:\n");
            upLeft.Y = double.Parse(Console.ReadLine());
            Console.Write("X2: ");
            lowRight.X = double.Parse(Console.ReadLine());
            Console.Write("Y2: ");
            lowRight.Y = double.Parse(Console.ReadLine());

            Rectangle_2 rect2 = new Rectangle_2(upLeft, lowRight);

            Console.WriteLine("Area of a Rectangle is: " + rect2.GetArea);
            Console.WriteLine("Perimeter of a Rectangle is: " + rect2.GetPerimeter);
        }

        public void Task_3()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Input radius of the Circle: ");
            double radius = double.Parse(Console.ReadLine());
            Circle circle = new Circle(radius);
            Console.ResetColor();
            Console.WriteLine("\n\nLength of a Circle is - {0}",  circle.Length_Circle());
            Console.WriteLine("\nand Area - {0}", circle.Area());
        }

        public void Task_4()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.ResetColor();
        }

        public void Task_5()
        {
            Console.WriteLine("Set 1st of Comlex Number:\n");
            Console.Write("Input the real number: ");
            double realNumb1 = double.Parse(Console.ReadLine());
            Console.Write("Input the imagionary number: ");
            double imagionary1 = double.Parse(Console.ReadLine());

            Console.WriteLine("\nSet 1st of Comlex Number:\n");
            Console.Write("Input the real number: ");
            double realNumb2 = double.Parse(Console.ReadLine());
            Console.Write("Input the imagionary number: ");
            double imagionary2 = double.Parse(Console.ReadLine());

            ComplexNumber complex1 = new ComplexNumber(realNumb1, imagionary1);
            ComplexNumber complex2 = new ComplexNumber(realNumb2, imagionary2);

            ComplexNumber mul = complex1 * complex2;
            ComplexNumber div = complex1 / complex2;

            Console.WriteLine("Multiply - {0}", mul);
            Console.WriteLine("Divide - {0}", div);
        }       
    }
}
