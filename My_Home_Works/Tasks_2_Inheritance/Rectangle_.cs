namespace Tasks_2_Inheritance
{
    using System;

    public class Rectangle_ : Figure
    {
        public override void Draw()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\nIt's Rectangle of a class!");
            Console.ResetColor();
        }
    }
}
