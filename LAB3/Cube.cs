using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    public class Cube
    {
        public double Edge { get;set; }

        public Cube(double edge)
        {
            if(edge > 0) Edge = edge;
        }
        public double Volume()
        {
            return Math.Round(Math.Pow(Edge, 3), 3);
        }
        public double SurfaceArea()
        {
            return Math.Round(Math.Pow(Edge, 2)*6, 3);
        }
        public void ChangeVolume(double changeNumber)
        {
            if(CheckEdge()&&changeNumber>0)
            {
                double volume = Volume()*changeNumber;
                double sqrt = Math.Pow(volume, 1.0/3.0);
                Edge = Math.Round(sqrt, 3);
            }
        }
        public bool CheckEdge()
        {
            return Edge > 0;
        }

    }
}
