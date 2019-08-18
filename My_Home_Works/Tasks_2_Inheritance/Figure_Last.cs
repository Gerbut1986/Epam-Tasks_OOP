namespace Tasks_2_Inheritance
{
    using System;

    public class Figure_Last : IDrawable
    {
        protected readonly double X, Y;

        public Figure_Last() { }

        public Figure_Last(double x, double y)
        {
            X = x;
            Y = y;
        }

        public virtual void Draw() { }

        public void DrawAll(params IDrawable[] array)
        {
            for(int i = 0; i < array.Length; i++)
                array[i].Draw();
        }
    }

    public class Square_L : Figure_Last
    {
        public Square_L(double x, double y) : base(x, y) { }

        public override void Draw()
        {
            base.Draw();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nSquare w/ points:\nX: {X}\nand\nY: {Y}");
            Console.ResetColor();
        }
    }

    public class Rectangle_L : Figure_Last
    {
        public Rectangle_L(double x, double y) : base(x, y) { }

        public override void Draw()
        {
            base.Draw();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"\nRectangle w/ points:\nX: {X}\nand\nY: {Y}");
            Console.ResetColor();
        }
    }
}
