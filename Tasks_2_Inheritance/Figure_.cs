namespace Tasks_2_Inheritance
{
    using System;

    public class Figure_
    {
        protected readonly double X, Y;

        public Figure_(double x, double y)
        {
            X = x;
            Y = y;
        }

        public virtual void Draw()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\nIt's a Figure is: \n");
            Console.ResetColor();
        }
    }

    public class Square_ : Figure_
    {
        public Square_(double x, double y) : base(x, y) { }

        public override void Draw()
        {
            base.Draw();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nSquare w/ points:\nX: {X}\nand\nY: {Y}");
            Console.ResetColor();
        }
    }

    public class Rectangle_V : Figure_
    {
        public Rectangle_V(double x, double y) : base(x, y) { }

        public override void Draw()
        {
            base.Draw();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"\nRectangle w/ points:\nX: {X}\nand\nY: {Y}");
            Console.ResetColor();
        }
    }
}
