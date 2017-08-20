namespace lesson_class.lessons.lesson13
{
    public class CustomPoint
    {
        public int X;

        public int Y;

        public CustomPoint(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Offset(int x, int y)
        {
            X += x;
            Y += y;
        }

        public bool Equals(CustomPoint point)
        {
            return (X == point.X && Y == point.Y);
        }
    }
}