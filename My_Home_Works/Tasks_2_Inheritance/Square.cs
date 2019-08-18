namespace Tasks_2_Inheritance
{
    using System;

    public class Square : Figure
    {
        public override void Draw()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("It's Square of a class!");
            Console.ResetColor();
        }
    }

}
