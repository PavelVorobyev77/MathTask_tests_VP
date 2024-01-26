using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathTaskClassLibrary
{
    public class Geometry
    {
        public int RectangleArea(int a, int b)
        {
            return a * b;
        }

        public double CylinderVolume(double radius, double height)
        {
            return Math.PI * Math.Pow(radius, 2) * height; //V = π * r^2 * h
        }

        public double CircleDiameter(double radius)
        {
            return 2 * radius; //D = 2 * r
        }

        public double CircleRadius(double area)
        {
            return Math.Sqrt(area / Math.PI); //r = √(S / π)
        }

        public double PyramidVolume(double baseArea, double height)
        {
            return baseArea * height / 3; //V = (1/3) * S * h
        }
        public double CircleCircumference(double radius)
        {
            return 2 * Math.PI * radius; //C = 2 * π * r
        }

    }
}
