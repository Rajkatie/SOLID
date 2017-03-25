namespace LSP._6_before
{
    public class Square : Rectangle
    {
        public Square(int height, int width) : base(height, width)
        {
        }

        public override int Height
        {
            get => base.Height;
            set => base.Height = base.Width= value;
               
        }

        public override int Width
        {
            get => base.Width;
            set => base.Width = base.Height= value;
        }

      

    }
}
