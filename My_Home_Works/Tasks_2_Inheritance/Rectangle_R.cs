namespace Tasks_2_Inheritance
{
    using System;

    public class Rectangle_R : Figure_Readonly
    {
        public Rectangle_R(double x, double y) : base(x, y) { }

        public override void Draw()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"Rectangle w/ points:\nX: {X}\nand\nY: {Y}");
            Console.ResetColor();
        }
    }
}
