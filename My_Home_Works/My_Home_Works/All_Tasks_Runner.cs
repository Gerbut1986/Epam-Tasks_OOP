namespace My_Home_Works
{
    using System;
    using Tasks_1_Classes;
    using Tasks_2_Inheritance;

    class All_Tasks_Runner
    {
        double x = 0.0, y = 0.0;

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

            Console.WriteLine("\n\nPlease input coordinates of an lower right corner:\n");
            upLeft.Y = double.Parse(Console.ReadLine());
            Console.Write("X2: ");
            lowRight.X = double.Parse(Console.ReadLine());
            Console.Write("Y2: ");
            lowRight.Y = double.Parse(Console.ReadLine());

            Rectangle_Property rect2 = new Rectangle_Property(upLeft, lowRight);

            Console.WriteLine($"Area of a Rectangle is: {rect2.GetArea}");
            Console.WriteLine($"Perimeter of a Rectangle is: {rect2.GetPerimeter}");
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
            // Static of The Rectangle:
            Console.ForegroundColor = ConsoleColor.DarkYellow;
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

            Rectangle_Static.SetCoordinates(coordUp, coordLow);

            Console.ResetColor();
            Console.WriteLine("\nPerimeter of Rectangle is: {0}", Rectangle_Static.Perimeter());
            Console.WriteLine("\nArea of Rectangle is: {0}", Rectangle_Static.Area());
            Console.ResetColor();

            // Static of The Circle:
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("\n\nInput radius of the Circle: ");
            double radius = double.Parse(Console.ReadLine());

            Circle_Static.SetRadius(radius);

            Console.ResetColor();
            Console.WriteLine("\n\nLength of a Circle is - {0}", Circle_Static.Length_Circle);
            Console.WriteLine("\nand Area - {0}", Circle_Static.Area);
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

        public void Task_6()
        {
            Figure[] figures = new Figure[] { new Square(), new Rectangle_() };
            for (int i = 0; i < figures.Length; i++)
                figures[i].Draw();
        }

        public void Task_7()
        {
            Input("Rectangle and Square", ref x, ref y);
            Figure_Readonly[] figures = new Figure_Readonly[] { new Square_R(x, y), new Rectangle_R(x, y) };
            for (int i = 0; i < figures.Length; i++)
                figures[i].Draw();
        }

        public void Task_8()
        {
            Input("Figure(base of a class)", ref x, ref y);

            Figure_ figure = new Figure_(x, y);

            Input("Rectangle", ref x, ref y);

            Rectangle_V rect = new Rectangle_V(x, y);

            Input("Square", ref x, ref y);

            Square_ square = new Square_(x, y);

            figure.Draw();

            figure = rect;
            figure.Draw();

            figure = square;
            figure.Draw();
        }

        void Input(string figureName, ref double x, ref double y)
        {
            Console.Write($"Input X for {figureName}: ");
            x = double.Parse(Console.ReadLine());

            Console.Write("Input Y for {figureName}: ");
            y = double.Parse(Console.ReadLine());
        }
    }
}
