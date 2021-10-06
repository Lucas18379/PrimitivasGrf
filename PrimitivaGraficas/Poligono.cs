using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitivaGraficas
{
    class Poligono
    {
        private List<Ponto> ptsOriginais;
        private List<Ponto> ptsAtuais;
        private double[,] ma;
        private Color cBorda, cFundo;
        private bool flagfundo;
        public Poligono(Color b)
        {
            cBorda = b;
            cFundo = b;
            flagfundo = false;
            ptsOriginais = new List<Ponto>();
            ptsAtuais = new List<Ponto>();
            ma = novaMatIdentidade();
        }
        public Poligono(Color b, Color f)
        {
            cBorda = b;
            cFundo = f;
            flagfundo = true;
            ptsOriginais = new List<Ponto>();
            ptsAtuais = new List<Ponto>();
            ma = novaMatIdentidade();
        }
 
        public void getMaximosEMinimos(out int xmin, out int ymin, out int xmax, out int ymax)
        {
            xmin = xmax = (int)Pontos[0].X;
            ymin = ymax = (int)Pontos[0].Y;
            for (int i = 1; i < Pontos.Count; ++i)
            {
                if (Pontos[i].X > xmax)
                    xmax = (int)Pontos[i].X;
                else if (Pontos[i].X < xmin)
                    xmin = (int)Pontos[i].X;
                if (Pontos[i].Y > ymax)
                    ymax = (int)Pontos[i].Y;
                if (Pontos[i].X < ymin)
                    ymin = (int)Pontos[i].Y;
            }
        }

        private double[,] novaMatIdentidade()
        {
            double[,] mat = new double[3, 3];
            mat[0, 0] = mat[1, 1] = mat[2, 2] = 1;
            return mat;
        }

        public void viewPort(int width, int height)
        {
            double[,] mat = novaMatIdentidade();
            double du = width, dv = height;
            int xmax, ymax, xmin, ymin;
            getMaximosEMinimos(out xmin, out ymin, out xmax, out ymax);
            double dx = xmax - xmin, dy = ymax - ymin;
            double fex = du / dx, fey = dv / dy;
            mat[0, 0] = fex;
            mat[0, 2] = -xmin * fex;
            mat[1, 1] = fey;
            mat[1, 2] = -ymin * fey;
            multiplicar(mat);
            atualizaPontos();
        }

        internal List<Ponto> Pontos
        {
            get
            {
                return ptsAtuais;
            }
        }

        public Color corBorda
        {
            get
            {
                return cBorda;
            }
            set
            {
                cBorda = value;
            }
        }

        public bool fundoAtivo()
        {
            return flagfundo;
        }

        public void setFundo(bool f)
        {
            flagfundo = f;
        }

        public Color corFundo
        {
            get
            {
                return cFundo;
            }
            set
            {
                cFundo = value;
            }
        }


        public void addPonto(double x, double y)
        {
            ptsOriginais.Add(new Ponto(x, y));
            ptsAtuais.Add(new Ponto(x, y));
        }

        public Ponto getPonto(int idx)
        {
            return ptsOriginais[idx];
        }

        public int sizeList()
        {
            return ptsOriginais.Count;
        }
        public void translacao(double x, double y)
        { 
            double[,] trans = novaMatIdentidade();
            trans[0, 2] = x;
            trans[1, 2] = y;
            multiplicar(trans);
            atualizaPontos();
        }
        private void atualizaPontos()
        {
            for (int i = 0; i < ptsOriginais.Count; ++i)
            {
                double[,] ponto = new double[3, 1];
                ponto[0, 0] = ptsOriginais[i].X;
                ponto[1, 0] = ptsOriginais[i].Y;
                ponto[2, 0] = 1;
                ponto = multiplicarPontos(ponto);
                ptsAtuais[i] = new Ponto((int)Math.Round(ponto[0, 0]), (int)Math.Round(ponto[1, 0]));
            }
        }


        public void rotacao(double ang, Ponto ponto)
        {
            double rad = ang * Math.PI / 180;
            double[,] Rota = novaMatIdentidade();
            Rota[0, 0] = Math.Cos(rad);
            Rota[0, 1] = -Math.Sin(rad);
            Rota[1, 0] = Math.Sin(rad);
            Rota[1, 1] = Math.Cos(rad);
            translacao(-ponto.X, -ponto.Y);
            multiplicar(Rota);
            translacao(ponto.X, ponto.Y);
            atualizaPontos();
        }

        public void escala(double x, double y)
        {
            Ponto centro = getCentro();
            double[,] Escala = novaMatIdentidade();
            Escala[0, 0] = x;
            Escala[1, 1] = y;
            translacao(-centro.X, -centro.Y);
            multiplicar(Escala);
            translacao(centro.X, centro.Y);
            atualizaPontos();
        }
        private void multiplicar(double[,] mat)
        {
            double sum;
            double[,] aux = copia(ma, 3, 3);
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                {
                    sum = 0;
                    for (int k = 0; k < 3; k++)
                        sum += mat[i, k] * ma[k, j];
                    aux[i, j] = sum;
                }
            ma = aux;
        }

        private double[,] multiplicarPontos(double[,] mat)
        {
            double sum;
            double[,] aux = copia(mat, 3, 1);
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 1; j++)
                {
                    sum = 0;
                    for (int k = 0; k < 3; k++)
                        sum += ma[i, k] * mat[k, j];
                    aux[i, j] = sum;
                }
            return aux;
        }

        private double[,] copia(double[,] m, int l, int c)
        {
            double[,] mat = new double[l, c];
            for (int i = 0; i < l; ++i)
                for (int j = 0; j < c; ++j)
                    mat[i, j] = m[i, j];
            return mat;
        }

        public double[,] copiaMA()
        {
            return copia(ma, 3, 3);
        }

        private List<Ponto> copiaPoints()
        {
            List<Ponto> nova = new List<Ponto>();
            foreach (Ponto p in ptsAtuais)
                nova.Add(new Ponto(p.X, p.Y));
            return nova;
        }

        public Ponto getCentro()
        {
            double x = 0, y = 0;
            foreach (Ponto p in ptsAtuais)
            {
                x += p.X;
                y += p.Y;
            }
            x /= ptsAtuais.Count;
            y /= ptsAtuais.Count;
            return new Ponto(x, y);
        }

        public void cisalhamentoX(double v)
        {
            double[,] mat = novaMatIdentidade();
            mat[0, 1] = v;
            Ponto p = getCentro();
            translacao(-p.X, -p.Y);
            multiplicar(mat);
            translacao(p.X, p.Y);
            atualizaPontos();
        }

        public void espelhamentoX(Ponto p)
        {
            double[,] mat = novaMatIdentidade();
            mat[1, 1] = -1;
            translacao(-p.X, -p.Y);
            multiplicar(mat);
            translacao(p.X, p.Y);
            atualizaPontos();
        }

        public void espelhamentoY(Ponto p)
        {
            double[,] mat = novaMatIdentidade();
            mat[0, 0] = -1;
            translacao(-p.X, -p.Y);
            multiplicar(mat);
            translacao(p.X, p.Y);
            atualizaPontos();
        }

        public void cisalhamentoY(double v)
        {
            double[,] mat = novaMatIdentidade();
            mat[1, 0] = v;
            Ponto p = getCentro();
            translacao(-p.X, -p.Y);
            multiplicar(mat);
            translacao(p.X, p.Y);
            atualizaPontos();
        }

        public Poligono getCopy()
        {
            Poligono po = new Poligono(Color.FromArgb(0, 0, 0));
            po.corFundo = this.corFundo;
            foreach (Ponto p in Pontos)
            {
                po.addPonto(p.X, p.Y);
            }
            return po;
        }

        public ET gerarET(int height)
        {
            ET et = new ET(height);
            List<Ponto> pontos = ptsAtuais;
           
            double xMax, yMax, xMin, yMin, incx, dx, dy;
            int y;
            for (int i = 0; i + 1 < pontos.Count; ++i)
            { 
                if (pontos[i].Y >= pontos[i + 1].Y)
                {
                    xMax = pontos[i].X;
                    yMax = pontos[i].Y;
                    xMin = pontos[i + 1].X;
                    yMin = pontos[i + 1].Y;
                }
                else
                {
                    xMin = pontos[i].X;
                    yMin = pontos[i].Y;
                    xMax = pontos[i + 1].X;
                    yMax = pontos[i + 1].Y;
                }
                dx = xMax - xMin;
                dy = yMax - yMin;
                incx = dx / dy;
                y = (int)yMin;
                if (y < 0) y = 0;
                else if (y >= height) y = height - 1;
                if (et.getAET(y) == null)
                    et.inicia(y);
                et.getAET(y).add(new No(yMax, xMin, incx));
            }

            if (pontos[0].Y >= pontos[pontos.Count - 1].Y)
            {
                xMax = pontos[0].X;
                yMax = pontos[0].Y;
                xMin = pontos[pontos.Count - 1].X;
                yMin = pontos[pontos.Count - 1].Y;
            }
            else
            {
                xMin = pontos[0].X;
                yMin = pontos[0].Y;
                xMax = pontos[pontos.Count - 1].X;
                yMax = pontos[pontos.Count - 1].Y;
            }
            dx = xMax - xMin;
            dy = yMax - yMin;
            incx = dx / dy;
            y = (int)yMin;
            if (y < 0) y = 0;
            else if (y >= height) y = height - 1;
            if (et.getAET(y) == null)
                et.inicia(y);
            et.getAET(y).add(new No(yMax, xMin, incx));

            return et;
        }
    }
}
