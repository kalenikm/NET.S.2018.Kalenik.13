using System.Collections.Generic;

namespace Logic.Comparers
{
    public class PointComparer : IComparer<Point>
    {
        public int Compare(Point p1, Point p2)
        {
            return (p1.X + p1.Y).CompareTo(p2.X + p2.Y);
        }
    }
}