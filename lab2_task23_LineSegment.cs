using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_task23
{
    class LineSegment
    {
        double x, y;

        public LineSegment(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public bool InSegment(double z)
        {
            if (x < y)
            {
                return z >= x && z <= y;
            }
            return z >= y && z <= x;
        }

        public static double operator !(LineSegment obj)
        {
            return Math.Abs(obj.x - obj.y);
        }

        public static LineSegment operator ++(LineSegment obj)
        {
            return new LineSegment(obj.x + 1, obj.y + 1);
        }

        public static explicit operator int(LineSegment obj)
        {
            return (int)obj.x;
        }

        public static implicit operator double(LineSegment obj)
        {
            return obj.y;
        }

        public static LineSegment operator +(LineSegment obj, int d)
        {
            return new LineSegment(obj.x + d, obj.y + d);
        }

        public static LineSegment operator +(int d, LineSegment obj)
        {
            return new LineSegment(obj.x + d, obj.y + d);
        }

        public static bool operator <(LineSegment obj, int z)
        {
            return obj.InSegment(z);
        }

        public static bool operator >(LineSegment obj, int z)
        {
            return obj.InSegment(z);
        }

        public override string ToString()
        {
            return $"x: {x}, y: {y}";
        }
    }
}
