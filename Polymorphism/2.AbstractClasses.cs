namespace _5._2.AbstractClasses
{
    public abstract class shape
    {
        public int Width { get; set; }
        public int height { get; set; }
        public abstract void Draw();

        public void Copy()
        {
            System.Console.WriteLine("copy shape into Clipbord.");
        }
        public void Select()
        {
            System.Console.WriteLine("Select the shape.");
        }
    }
}
