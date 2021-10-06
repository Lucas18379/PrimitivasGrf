using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitivaGraficas
{
    class ET
    {
        private AET[] et;
        private int TF, quant;
        public ET(int tf)
        {
            TF = tf;
            quant = 0;
            et = new AET[TF];
        }

        public AET getAET(int pos)
        {
            if (pos >= TF)
            {
                bool v = 1 == 1;
            }
            else
                return et[pos];
            return null;
        }

        public int getTF()
        {
            return TF;
        }

        public int getQuantidade()
        {
            return quant;
        }

        public void inicia(int pos)
        {
            et[pos] = new AET();
            quant++;
        }

        public void addNo(int pos, No n)
        {
            if (et[pos] == null)
                inicia(pos);
            et[pos].add(n);
        }

    }
}

