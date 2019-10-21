namespace _1.MethodOverriding
{
    partial class Program
    {
        public class Circle : Shape
        {
            public override void Draw()
            {
                System.Console.WriteLine("Draw a circle");
            }
        }
        public class Rectangle : Shape
        {
            public override void Draw()
            {
                System.Console.WriteLine("Draw a rectangle");
            }
        }
        public class Triangle : Shape
        {
            public override void Draw()
            {
                System.Console.WriteLine("Draw a Triangle");
            }
        }
        public class Shape
        {
            public int Width { get; set; }
            public int Hight { get; set; }
            public Position Position { get; set; }
            public ShapeType Type { get; set; }

            public virtual void Draw()
            {

            }
        }
    }
}
