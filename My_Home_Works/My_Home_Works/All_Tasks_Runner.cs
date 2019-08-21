namespace My_Home_Works
{
    using System;
    using Tasks_1_Classes;
    using Tasks_2_Inheritance;
    using Tasks_3_Collections;
    using System.Collections.Generic;

    class All_Tasks_Runner
    {
        double x = 0.0, y = 0.0;

        public void Task_1()
        {   //
            // Input each coordinates:
            //
            //Point coordUp, coordLow;
            //Console.ForegroundColor = ConsoleColor.Magenta;
            //Console.WriteLine("Enter the upper and lower right corner coordinates: ");
            //Console.Write("\nInput upper left:\n\nx1:");
            //coordUp.X = double.Parse(Console.ReadLine());
            //Console.Write("\ny1: ");
            //coordUp.Y = double.Parse(Console.ReadLine()); 
            //Console.Write("\nInput lower right:\nx2: ");
            //coordLow.X = double.Parse(Console.ReadLine());
            //Console.Write("\ny2: ");
            //coordLow.Y = double.Parse(Console.ReadLine()); 

            //Rectangle rect = new Rectangle(coordUp, coordLow);

            //
            // Input in one line separated by spaces:
            //
            string[] input = null;
            Console.WriteLine("Enter the upper and lower right corner coordinates: ");
            Console.Write("Input x1 y1 x2 y2 separated by spaces: ");
            try
            {
                input = Console.ReadLine().Split(new char[] { ' ' }, 4);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Title = "Exception..";
                Console.WriteLine(ex.Message);
                Console.Write("\n\n\t\tPress any Key to continue...");
                Console.ReadKey(true);
                Console.ResetColor();
            }

            Rectangle rect = new Rectangle(new Point { X = double.Parse(input[0]), Y = double.Parse(input[1]) }, 
                                           new Point { X = double.Parse(input[2]), Y = double.Parse(input[3]) });
            Console.ResetColor();
            Console.WriteLine("\nPerimeter of Rectangle is: {0}", rect.Perimeter());
            Console.WriteLine("\nArea of Rectangle is: {0}", rect.Area());
        }


        public void Task_2()
        {
            Point upLeft, lowRight;
            upLeft.X = upLeft.Y = lowRight.X = lowRight.Y = 0.0;


            try
            {
                Console.WriteLine("Please input coordinates of an upper left corner:\n");
                Console.Write("X1: ");
                upLeft.X = double.Parse(Console.ReadLine());
                Console.Write("Y1: ");

                Console.WriteLine("\n\nPlease input coordinates of an lower right corner:\n");
                upLeft.Y = double.Parse(Console.ReadLine());
                Console.Write("\nX2: ");
                lowRight.X = double.Parse(Console.ReadLine());
                Console.Write("Y2: ");
                lowRight.Y = double.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.Title = "Your input was a string..";
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\n\n\t\tPress any Key to continue..");
                Console.ReadKey(true);
                Console.ResetColor();
            }

            Rectangle_Property rect2 = new Rectangle_Property(upLeft, lowRight);

            Console.WriteLine($"\n\nArea of a Rectangle is: {rect2.GetArea}");
            Console.WriteLine($"Perimeter of a Rectangle is: {rect2.GetPerimeter}");
        }

        public void Task_3()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Input radius of the Circle: ");
            double radius = 0.0;
            try
            {
                radius = double.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.Title = "Your input was a string..";
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\n\n\t\tPress any Key to continue..");
                Console.ReadKey(true);
                Console.ResetColor();
            }
            Circle circle = new Circle(radius);
            Console.ResetColor();
            Console.WriteLine("\n\nLength of a Circle is - {0}",  circle.Length_Circle());
            Console.WriteLine("\nand Area - {0}", circle.Area());
        }

        public void Task_4()
        {
            Point coordUp, coordLow;
            coordUp.X = coordUp.Y = coordLow.X = coordLow.Y = 0.0;

            try
            {
                // Static of The Rectangle:
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
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.Title = "Your input was a string..";
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\n\n\t\tPress any Key to continue..");
                Console.ReadKey(true);
                Console.ResetColor();
            }

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
            double realNumb1, realNumb2, imagionary1, imagionary2;
            realNumb1 = realNumb2 = imagionary1 = imagionary2 = 0.0;

            try
            {
                Console.WriteLine("Set 1st of Comlex Number:\n");
                Console.Write("Input the real number: ");
                realNumb1 = double.Parse(Console.ReadLine());
                Console.Write("Input the imagionary number: ");
                imagionary1 = double.Parse(Console.ReadLine());

                Console.WriteLine("\nSet 1st of Comlex Number:\n");
                Console.Write("Input the real number: ");
                realNumb2 = double.Parse(Console.ReadLine());
                Console.Write("Input the imagionary number: ");
                imagionary2 = double.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.Title = "Your input was a string..";
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\n\n\t\tPress any Key to continue..");
                Console.ReadKey(true);
                Console.ResetColor();
            }

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

            //figure.Draw();

            figure = rect;
            figure.Draw();

            figure = square;
            figure.Draw();
        }

        void Input(string figureName, ref double x, ref double y)
        {
            try
            {
                Console.Write($"\nInput X for {figureName}: ");
                x = double.Parse(Console.ReadLine());

                Console.Write($"Input Y for {figureName}: ");
                y = double.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.Title = "Your input was a string..";
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\n\n\t\tPress any Key to continue..");
                Console.ReadKey(true);
                Console.ResetColor();
            }
        }

        public void Task_9()
        {
            Figure_Last figure = new Figure_Last();

            Input("Rectangle", ref x, ref y);
            Rectangle_L rect = new Rectangle_L(x, y);

            Input("Square", ref x, ref y);
            Square_L square = new Square_L(x, y);

            figure.DrawAll(rect, square);
        }

        public void Task_10()
        {
            Random rand = new Random();
            List<Person> persons = new List<Person>();
            persons.Add(new Person { Name = "Alex", Age = 39, PhoneNumbers = new string[] { "380971234567", "380662345566", "3805431322243" } });
            persons.Add(new Person { Name = "Ivan", Age = 32, PhoneNumbers = new string[] { "380754309875", "3803467899300", "3804564565465" } });
            persons.Add(new Person { Name = "Dmitry", Age = 52, PhoneNumbers = new string[] { "380673245569", "38012345677", "3803453647567" } });
            persons.Add(new Person { Name = "Vladimir", Age = 43, PhoneNumbers = new string[] { "380971234567", "38033489006", "3865756755675" } });
            persons.Add(new Person { Name = "Yulia", Age = 33, PhoneNumbers = new string[] { "38043564556", "380756453543", "380234456457" } });
            persons.Add(new Person { Name = "Diana", Age = 27, PhoneNumbers = new string[] { "38099999999", "38077734343", "380766644487" } });

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" {0,-13} {1,5}\n", "Name:", "Age:");
            Console.ForegroundColor = ConsoleColor.Green;
            var colors = ColorRand();

            for (int i = 0; i < persons.Count; i++)
            {
                Console.ForegroundColor = colors[rand.Next(0, 6)];
                Console.WriteLine(" {0,-13} {1,3}\n", persons[i].Name, persons[i].Age);
            }

            Console.ResetColor();
        }

        List<ConsoleColor> ColorRand()
        {
            List<ConsoleColor> colors = new List<ConsoleColor>();
            colors.Add(ConsoleColor.Blue);
            colors.Add(ConsoleColor.Red);
            colors.Add(ConsoleColor.Green);
            colors.Add(ConsoleColor.Magenta);
            colors.Add(ConsoleColor.Yellow);
            colors.Add(ConsoleColor.Cyan);

            return colors;
        }
    }
}
