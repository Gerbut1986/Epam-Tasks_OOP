namespace My_Home_Works
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;
            do
            {
                choice = Menu();
                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        new All_Tasks_Runner().Task_1();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("\n\n\t\tPress any Key to continue...");
                        Console.ReadKey(true);
                        Console.ResetColor();
                        break;
                    case 2:
                        Console.Clear();
                        new All_Tasks_Runner().Task_2();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("\n\n\t\tPress any Key to continue...");
                        Console.ReadKey(true);
                        Console.ResetColor();
                        break;
                    case 3:
                        Console.Clear();
                        new All_Tasks_Runner().Task_3();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("\n\n\t\tPress any Key to continue...");
                        Console.ReadKey(true);
                        Console.ResetColor();
                        break;
                    case 4:
                        Console.Clear();
                        new All_Tasks_Runner().Task_4();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("\n\n\t\tPress any Key to continue...");
                        Console.ReadKey(true);
                        Console.ResetColor();
                        break;
                    case 5:
                        Console.Clear();
                        new All_Tasks_Runner().Task_5();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("\n\n\t\tPress any Key to continue...");
                        Console.ReadKey(true);
                        Console.ResetColor();
                        break;
                    case 6:
                        Console.Clear();
                        new All_Tasks_Runner().Task_6();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("\n\n\t\tPress any Key to continue...");
                        Console.ReadKey(true);
                        Console.ResetColor();
                        break;
                    case 7:
                        Console.Clear();
                        new All_Tasks_Runner().Task_7();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("\n\n\t\tPress any Key to continue...");
                        Console.ReadKey(true);
                        Console.ResetColor();
                        break;
                    case 8:
                        Console.Clear();
                        new All_Tasks_Runner().Task_8();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("\n\n\t\tPress any Key to continue...");
                        Console.ReadKey(true);
                        Console.ResetColor();
                        break;
                    case 0:break;
                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Incorrect inputing... Try again!");
                        Console.Write("\n\n\t\tPress any Key to continue..");
                        Console.ReadKey(true);
                        Console.ResetColor();
                        break;
                }
            } while (choice != 0);
        }

        static int Menu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n\t\t\t     The Topic - 'Classes'");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n1 - Task 1 (Rectangle with methods (Perimeter and Area) having 2 coordinates)");
            Console.WriteLine("\n2 - Task 2 (Auto - Implemented Properties instead the Methods)");
            Console.WriteLine("\n3 - Task 3 (Cirkle whith method)");
            Console.WriteLine("\n4 - Task 4 (1 - 3 tasks using static classes)");
            Console.WriteLine("\n5 - Task 5 (Comlex numbers to overload operators: '*' and '/'))");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n\t\t\t   The Topic - 'Inheritance'");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n6 - Task 6 (Base of a class Figure with method Draw())");
            Console.WriteLine("\n7 - Task 7 (Base of a class Figure use readonly properties)");
            Console.WriteLine("\n8 - Task 8 (Class Figure use virtual method instead abstract)");
            Console.WriteLine("\n0 - Exit"); 
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\t\t\t   Please make your choice..");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("\n\t\t\t\t      ");

            int choice = int.Parse(Console.ReadLine());
            Console.ResetColor();

            return choice;
        }
    }
}
