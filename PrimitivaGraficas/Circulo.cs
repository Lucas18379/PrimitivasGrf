using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitivaGraficas
{
    class Circulo
    {
        private int cx, cy;
        private double raio;

        public Circulo()
        {
            raio = cx = cy = 0;
        }
        public Circulo(int cx, int cy, double raio)
        {
            this.cx = cx;
            this.cy = cy;
            this.raio = raio;
        }

        public int getCx()
        {
            return cx;
        }

        public void setCx(int cx)
        {
            this.cx = cx;
        }
        public int getCy()
        {
            return cy;
        }

        public void setCy(int cy)
        {
            this.cy = cy;
        }

        public double getRaio()
        {
            return raio;
        }

        public void setRaio(double raio)
        {
            this.raio = raio;
        }
    }
}
