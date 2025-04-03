using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class Point
    {
        double x;
        double y;

        private Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public static Point CartesianPoint(double x, double y)
        {
            return new Point(x, y);
        }

        public static Point PolarPoint(double rho, double theta)
        {
            return new Point(rho*Math.Cos(theta), rho*Math.Sin(theta);
        }
    }
}
