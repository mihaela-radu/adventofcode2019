using System;

namespace Day3
{
    public class Coordinate : IEquatable<Coordinate>
    {
        public Coordinate(int x, int y)
        {
            X = x;
            Y = y;
        }
        public int X { get; set; }

        public int Y { get; set; }

        public override bool Equals(object obj)
        {
            return Equals(obj as Coordinate);
        }

        public bool Equals(Coordinate other)
        {
            if (other == null) { return false; }
            if (object.ReferenceEquals(this, other)) { return true; }

            return X == other.X && Y == other.Y;
        }

        public override int GetHashCode() => X.GetHashCode() + Y.GetHashCode();

        public override string ToString() => X + "," + Y;
    }
}
