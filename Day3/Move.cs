using System.Drawing;

namespace Day3
{
    public class Move
    {
        public Move(Point point, long steps)
        {
            Point = point;
            Steps = steps;
        }

        public Point Point { get; set; }

        public long Steps { get; set; }
    }
}
