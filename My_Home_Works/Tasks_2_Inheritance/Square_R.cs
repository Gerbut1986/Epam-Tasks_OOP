namespace Tasks_2_Inheritance
{
    using System;

    public class Square_R : Figure_Readonly
    {
        public Square_R(double x, double y) : base(x, y) { }

        public override void Draw()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"\nSquare w/ points:\nX: {X}\nand\nY: {Y}");
            Console.ResetColor();
        }
    }
}
