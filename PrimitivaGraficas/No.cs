using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitivaGraficas
{
    class No
    {
        private double yMax, xMin;
        private double increcx;

        public No(double yMax, double xMin, double increcx)
        {
            this.yMax = yMax;
            this.xMin = xMin;
            this.increcx = increcx;
        }

        public double getXmin()
        {
            return xMin;
        }

        public double getYmax()
        {
            return yMax;
        }

        public double getIncX()
        {
            return increcx;
        }
        public void setXmin(double x)
        {
            xMin = x;
        }
        public void setYmax(double y)
        {
            yMax = y;
        }
        public void setIncX(double inc)
        {
            increcx = inc;
        }
    }
}
