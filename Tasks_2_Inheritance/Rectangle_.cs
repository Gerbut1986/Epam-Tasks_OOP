namespace Tasks_2_Inheritance
{
    using System;

    public class Rectangle_ : Figure
    {
        public override void Draw()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\nIt's a Draw() method of a Rectangle!");
            Console.ResetColor();
        }
    }
}
