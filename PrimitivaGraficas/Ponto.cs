using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitivaGraficas
{
    class Ponto
    {
        private double x, y;
        public Ponto()
        {
            X = Y = 0;
        }
        public Ponto(double x, double y)
        {
            X = x;
            Y = y;
        }
        public double Y
        {
            get
            {
                return y;
            }

            set
            {
                y = value;
            }
        }

        public double X
        {
            get
            {
                return x;
            }

            set
            {
                x = value;
            }
        }

    }

}

