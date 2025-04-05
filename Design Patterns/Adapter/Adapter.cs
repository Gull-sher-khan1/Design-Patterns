using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Hole
    {
        public double Radius { get; set; }

        public Hole(double radius) 
        {
            this.Radius = radius;
        }

        public bool fits(Shape sh)
        {
            return this.Radius >= sh.GetRadius();
        }
    }

    public interface Shape
    {
        double GetRadius();
    }

    public class Cylinder : Shape 
    {
        private double Radius { get; set; }
        private double Height { get; set; }

        public Cylinder(double radius, double height)
        {
            Radius = radius;
            Height = height;
        }

        public double GetRadius()
        {
            return Radius;
        }
    }

    public class SquarePrism
    {
        public double Length { get; set; }
        public double Height { get; set; }

        public SquarePrism(double length, double height)
        {
            Length = length;
            Height = height;
        }
    }

    public class SquarePrismAdapter: Shape
    {
        private SquarePrism _sp;

        public SquarePrismAdapter(SquarePrism sp)
        {
            _sp = sp;
        }

        public double GetRadius()
        {
            return _sp.Length / Math.Sqrt(2);
        }
    }
}
