namespace My_Home_Works
{
    using System;
    using System.Linq;
    using Tasks_1_Classes;
    using Tasks_2_Inheritance;
    using Tasks_3_Collections;
    using System.Collections.Generic;

    class All_Tasks_Runner
    {
        List<Person> persons = new List<Person>();
        List<ConsoleColor> colors;
        List<string> str_elem;
        double x = 0.0, y = 0.0;
        Random rand;

        public All_Tasks_Runner()
        {
            rand = new Random();
            colors = ColorRand();
        }

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
            Rectangle rect = null;
            Console.WriteLine("Enter the upper and lower right corner coordinates: ");
            Console.Write("Input x1 y1 x2 y2 separated by spaces: ");
            try
            {
                input = Console.ReadLine().Split(new char[] { ' ' }, 4);
                rect = new Rectangle(new Point { X = double.Parse(input[0]), Y = double.Parse(input[1]) },
                                          new Point { X = double.Parse(input[2]), Y = double.Parse(input[3]) });
                Console.ResetColor();
                Console.WriteLine("\nPerimeter of Rectangle is: {0}", rect.Perimeter());
                Console.WriteLine("\nArea of Rectangle is: {0}", rect.Area());
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Title = "Exception..";
                Console.WriteLine(ex.Message);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\n\n\t\t\t\t\t      Press any Key to continue...");
                Console.ReadKey(true);
                Console.ResetColor();
            }
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
                Console.Write("\n\n\t\t\t\t\t      Press any Key to continue..");
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
            Console.WriteLine("\n\nLength of a Circle is - {0}", circle.Length_Circle());
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
                Console.Write("\n\n\t\t\t\t\t      Press any Key to continue..");
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
                Console.Write("\n\n\t\t\t\t\t      Press any Key to continue..");
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
                Console.Write("\n\n\t\t\t\t\t      Press any Key to continue..");
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
            persons.Add(new Person { Name = "Alex", Age = 39, PhoneNumbers = new string[] { "380971234567", "380662345566", "3805431322243" } });
            persons.Add(new Person { Name = "Ivan", Age = 32, PhoneNumbers = new string[] { "380754309875", "3803467899300", "3804564565465" } });
            persons.Add(new Person { Name = "Dmitry", Age = 52, PhoneNumbers = new string[] { "380673245569", "38012345677", "3803453647567" } });
            persons.Add(new Person { Name = "Vladimir", Age = 43, PhoneNumbers = new string[] { "380971234567", "38033489006", "3865756755675" } });
            persons.Add(new Person { Name = "Yulia", Age = 33, PhoneNumbers = new string[] { "38043564556", "380756453543", "380234456457" } });
            persons.Add(new Person { Name = "Diana", Age = 27, PhoneNumbers = new string[] { "38099999999", "38077734343", "380766644487" } });

            OutputPersons();

            Console.ResetColor();
        }

        List<ConsoleColor> ColorRand()
        {
            List<ConsoleColor> colors = new List<ConsoleColor>
            {
               ConsoleColor.Blue,ConsoleColor.Cyan,ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
               ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,ConsoleColor.DarkYellow,
               ConsoleColor.Gray,ConsoleColor.Green,ConsoleColor.Magenta,ConsoleColor.White,
               ConsoleColor.Yellow
            };

            return colors;
        }

        public void Task_11()
        {
            Person[] twoPerson = InputPerson();

            try
            {
                persons.AddRange(twoPerson);
                Console.ForegroundColor = ColorRand()[rand.Next(0, 13)];
                Console.WriteLine(new string('-', 120)); 
                Console.WriteLine("\t\t\t\t\t     Current list of Numbers Phones is:\n");
                Console.WriteLine(new string('-', 120));

                for (int i = 0; i < persons.Count; i++)
                {
                    foreach (var number in persons[i].PhoneNumbers)
                    {
                        Console.ForegroundColor = ColorRand()[rand.Next(0, 13)];
                        Console.WriteLine($"\n\n\t\t\t\t\t\t      {number}\n");
                    }
                }
            }
            catch
            {
                Console.Clear();
                Console.ForegroundColor = ColorRand()[rand.Next(0, 13)];
                Console.Write("\n The List of Person has not yet been created..\n First you need to complete Task_10\n");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("\n Click 10 on the main menu..");
                Console.ForegroundColor = ColorRand()[rand.Next(0, 13)];
                Console.Write("\n\n\t\t\t\t\t      Press any Key to continue...");
                Console.ReadKey(true);
                Console.ResetColor();
            }
        }

        Person[] InputPerson(int quantity = 2) // Auto-param with the ability to accept the number of person
        {
            string name;
            int age;
            Person[] tmp = new Person[quantity];
            string[] phones = new string[rand.Next(3, 5)];
            Console.ForegroundColor = colors[rand.Next(0, 13)];
            Console.WriteLine($"\n\t\t\t     Add {tmp.Length} Person to the list\n");

            for (int i = 0; i < tmp.Length; i++)
            {
                string suffix = i == 0 ? "st" : "nd";
                Console.ForegroundColor = colors[rand.Next(0, 13)];
                Console.Write(new string('-', 120));
                Console.WriteLine($"\n {i + 1}{suffix} person:\n");
                Console.WriteLine(new string('-', 120));
                Console.ForegroundColor = colors[rand.Next(0, 13)];
                Console.Write("\n Name: ");
                name = Console.ReadLine();
                Console.ForegroundColor = colors[rand.Next(0, 13)];
                Console.Write("\n Age: ");
                age = int.Parse(Console.ReadLine());
                Console.ForegroundColor = colors[rand.Next(0, 13)];
                Console.Write($"\n and {phones.Length} Phone numbers: ");
                for (int j = 0; j < phones.Length; j++)
                {
                    Console.ForegroundColor = colors[rand.Next(0, 13)];
                    Console.Write($"\n\n {j + 1} number: ");
                    phones[j] = Console.ReadLine();
                }

                tmp[i] = new Person { Name = name, Age = age, PhoneNumbers = phones };
            }

            return tmp;
        }

        void OutputPersons()
        {
            Console.Clear();
            Console.WriteLine(new string('-', 120));
            Console.WriteLine("\t\t\t\t\t      Current list of a Person is:\n");
            Console.WriteLine(new string('-', 120));
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\t\t\t\t\t\t   {0,-13} {1,5}\n", "Name:", "Age:");

            Console.WriteLine(new string('-', 120));
            Console.ForegroundColor = ConsoleColor.Green;

            for (int i = 0; i < persons.Count; i++)
            {
                Console.ForegroundColor = colors[rand.Next(0, 13)];
                Console.WriteLine("\t\t\t\t\t\t   {0,-13} {1,3}\n", persons[i].Name, persons[i].Age);
            }
        }

        public void Task_12()
        {
            int max = 0;
            str_elem = new List<string>();
            Console.ForegroundColor = colors[rand.Next(0, 13)];
            Console.Write("\nEnter a maximum list size limit from 100 to ..[your max]: ");

            try
            {
                max = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.Title = "Your input was a string..";
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\n\n\t\t\t\t\t       Press any Key to continue...");
                Console.ReadKey(true);
                Console.ResetColor();
            }

            str_elem.AddRange(Words_Rand(Count_List_Rand(max)));

            int choice = 0;
            do
            {
                Console.Clear();
                Console.ForegroundColor = colors[rand.Next(0, 13)];
                Console.WriteLine("\n1 - Show All List");
                Console.WriteLine("\n2 - Remove All Duplicate Items From The List");
                Console.WriteLine("\n3 - Remove All Items Starting with 'Z'");
                Console.WriteLine("\n4 - Sort All the List by DESCEND");
                Console.WriteLine("\n5 - Number of List Items");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("\nPlease Make your choice...");

                try
                {
                    choice = int.Parse(Console.ReadLine());
                    Console.ResetColor();
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\n\n{ex.Message}");
                    Console.Title = "Your input was a string..";
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("\n\n\t\t\t\t\t      Press any Key to continue...");
                    Console.ReadKey(true);
                    Console.ResetColor();
                }
                Console.ResetColor();

                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        Console.ForegroundColor = colors[rand.Next(0, 13)];
                        ShowAllList();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("\n\n\t\t\t\t\t      Press any Key to continue...");
                        Console.ReadKey(true);
                        Console.ResetColor();
                        break;
                    case 2:
                        Console.Clear();
                        Console.ForegroundColor = colors[rand.Next(0, 13)];
                        Console.WriteLine("\nAll elements w/o 'Z':");
                        HashSet<string> myHash = DeleteDuplicate();
                        foreach (var i in myHash)
                        {
                            Console.ForegroundColor = colors[rand.Next(0, 13)];
                            Console.WriteLine(i);
                        }
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("\n\n\t\t\t\t\t      Press any Key to continue...");
                        Console.ReadKey(true);
                        Console.ResetColor();
                        break;
                    case 3:
                        Console.Clear();
                        Console.ForegroundColor = colors[rand.Next(0, 13)];
                        List_w_o_W();
                        Console.ForegroundColor = colors[rand.Next(0, 13)];
                        Console.WriteLine("\nAll elements starting with 'Z':");
                        ShowAllList();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("\n\n\t\t\t\t\t      Press any Key to continue...");
                        Console.ReadKey(true);
                        Console.ResetColor();
                        break;
                    case 4:
                        Console.Clear();
                        Console.ForegroundColor = colors[rand.Next(0, 13)];
                        Console.WriteLine("\nSorted by descending:");
                        
                        // Classic sort use method of the List:
                        // str_elem.Sort();
                        // foreach (string str in str_elem)
                        //    Console.WriteLine(str);
                        
                        // Using LINQ:
                        var sorted = Desc_Sort(str_elem);
                        foreach (string str in sorted)
                            Console.WriteLine(str);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("\n\n\t\t\t\t\t      Press any Key to continue...");
                        Console.ReadKey(true);
                        Console.ResetColor();
                        break;
                    case 5:
                        Console.Clear();
                        Console.ForegroundColor = colors[rand.Next(0, 13)];
                        Console.Write($"\nCount of the List is: {ListCount}");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("\n\n\t\t\t\t\t      Press any Key to continue...");
                        Console.ReadKey(true);
                        Console.ResetColor();
                        break;
                    case 0:
                        Console.Clear();
                        Console.Beep();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("\n\n\t\t\t\t\t      Press any Key to come back in Main menu...");
                        Console.ReadKey(true);
                        Console.ResetColor();
                        break;
                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Incorrect inputing... Try again!");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("\n\n\t\t\t\t\t      Press any Key to continue...");
                        Console.ReadKey(true);
                        Console.ResetColor();
                        break;
                }
            } while (choice != 0);
        }

        void DisplayPage(int pageNumber)
        {
            const int numb_elem = 5;
            int num = 0;

            do
            {
                foreach (string str in str_elem)
                    Console.WriteLine(str);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\t\t\t\t\t      Page - {pageNumber}");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\n\n\t\t\t\t\t      Press any Key to continue...");
                Console.ReadKey(true);

            } while (numb_elem != 0);
        }

        IEnumerable<string> Desc_Sort(List<string> words) => from word in words orderby word.Substring(0, 1) descending select word;


        HashSet<string> DeleteDuplicate()
        {
            var duplicateRemove = new HashSet<string>(str_elem);

            return duplicateRemove;
        }

        public void List_w_o_W() 
        {
            for (var i = str_elem.Count - 1; i >= 0; i--)
            {
                if (str_elem[i].StartsWith("W"))
                    str_elem.RemoveAt(i); // Removing an entire row
                    //fileList[i] = String.Empty; // Leave the line, but make it empty
            }
        }

        public int ListCount => str_elem.Count;

        void ShowAllList()
        {
            for (int i = 0; i < str_elem.Count; i++)
            {
                Console.ForegroundColor = colors[rand.Next(0, 13)];
                Console.Write($"\n{i + 1} Element: ");
                Console.WriteLine(str_elem[i]);
            }          
        }
        int Count_List_Rand(int max) => rand.Next(100, max);

        string[] Words_Rand(int n)
        {
            string[] words = new string[n];

            for (int i = 0; i < words.Length; i++)
                words[i] += Symbols_Rand();

            return words;
        }

        string Symbols_Rand(int letters = 4)
        {
            char[] symbols = new char[letters];

            for (int i = 0; i < symbols.Length; i++)
                symbols[i] += ((char)rand.Next('a', 'w'));

            return new string(symbols).ToUpper();
        }
    }
}
