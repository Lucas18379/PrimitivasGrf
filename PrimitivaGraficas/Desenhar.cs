using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading.Tasks;
using System.IO;
using PrimitivaGraficas;

namespace primitivas_graficas
{
    class Desenhar
    {
        double pi = Math.PI;
        private double abs(double a)
        {
            return Math.Abs(a);
        }

        private int abs(int a)
        {
            return Math.Abs(a);
        }

        private unsafe void swap(int* x, int* y)
        { 
            *x ^= *y;
            *y ^= *x;
            *x ^= *y;
        }

        private void swap(ref int a, ref int b)
        {
            a ^= b;
            b ^= a;
            a ^= b;
        }

        private bool inImage(BitmapData bmp, int x, int y)
        {
            return x >= 0 && x < bmp.Width && y >= 0 && y < bmp.Height;
        }

        public void floodFill(Bitmap bmp, int x, int y, Color cor)
        {
            Stack<int> pilha = new Stack<int>();
            
            BitmapData data = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            unsafe
            {
                byte* aux = gotoxy(data, x, y);
                int fundoB = *aux, fundoG = *(aux + 1), fundoR = *(aux + 2);
                int[] dx = { -1, 0, 0, 1 };
                int[] dy = { 0, -1, 1, 0 };
                int i;
                pilha.Push(x);
                pilha.Push(y);
                while (pilha.Count > 0)
                {
                    y = pilha.Pop();
                    x = pilha.Pop();
                    aux = gotoxy(data, x, y);
                    *(aux++) = cor.B; 
                    *(aux++) = cor.G;
                    *aux = cor.R;
                    for (i = 0; i < 4; ++i)
                    {
                        if (inImage(data, x + dx[i], y + dy[i]))
                        {
                            aux = gotoxy(data, x + dx[i], y + dy[i]);
                            if (*aux == fundoB && *(aux + 1) == fundoG && *(aux + 2) == fundoR)
                            {
                                pilha.Push(x + dx[i]);
                                pilha.Push(y + dy[i]);
                            }
                        }
                    }
                }
            }

            bmp.UnlockBits(data);
        }

        public void scanLine(Bitmap bmp, Poligono poli, Color cor)
        {
            int height = bmp.Height;
            
            ET et = poli.gerarET(height);
            AET aet = new AET();

            BitmapData data = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            unsafe
            {
                List<No> lista;
                int y = 0, cont = 0, qtaet, qtet;
                while (y < et.getTF() && et.getAET(y) == null)
                    ++y;
                while (y < bmp.Height && ((qtaet = aet.getList().Count) > 0 ||
                    cont < (qtet = et.getQuantidade())))
                {
                    if (et.getAET(y) != null)
                        aet.add(et.getAET(y).getList());
                    aet.rand();

                    for (int i = 0; i < aet.getList().Count; ++i)
                        if (aet.getList()[i].getYmax() <= y)
                            aet.getList().Remove(aet.getList()[i]);
 
                    lista = aet.getList();
                    for (int i = 0, x, x2; i + 1 < lista.Count; i += 2)
                    {

                        x = (int)Math.Round(lista[i].getXmin());
                        x2 = (int)Math.Round(lista[i + 1].getXmin());
                        while (x <= x2)
                        {
                            if (inImage(data, x, y))
                            {
                                writePixel(data, x, y, cor);
                                ++x;
                            }
                        }
                    }
                    ++y;
                    for (int i = 0; i < aet.getList().Count; ++i)
                        aet.getList()[i].setXmin(aet.getList()[i].getXmin() +
                            aet.getList()[i].getIncX());
                    //}
                }
            }
            bmp.UnlockBits(data);

        }
        public void paint(Bitmap bmp, Color cor)
        {

            BitmapData bmpData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            unsafe
            {
                int height = bmp.Height;
                int width = bmp.Width;
                byte* aux;

                for (int y = 0, x; y < height; ++y)
                    for (x = 0; x < width; ++x)
                    {
                        aux = gotoxy(x, y, bmpData);
                        *aux = (byte)cor.B;
                        *(aux + 1) = (byte)cor.G;
                        *(aux + 2) = (byte)cor.R;
                    }
            }

            bmp.UnlockBits(bmpData);
        }
        public void dLinEqGeral(Bitmap bmp, int x1, int y1, int x2, int y2, Color cor)
        {

            BitmapData bmpdata = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            unsafe
            {
                double dx = x2 - x1;
                double dy = y2 - y1;
                double m = dx != 0 ? dy / dx : 0;
                int comp = (int)(abs(dx) > abs(dy) ? abs(dx) : abs(dy));
                int x, y, i, sinal;
                if (m == 0)
                {
                    if (dx == 0)
                    {
                        sinal = dy >= 0 ? 1 : -1;
                        for (y = y1, i = 0; i <= comp; ++i, y += sinal)
                            writePixel(bmpdata, x1, y, cor);
                    }
                    else
                    {
                        sinal = dx >= 0 ? 1 : -1;
                        for (x = x1, i = 0; i <= comp; ++i, x += sinal)
                            writePixel(bmpdata, x, y1, cor);
                    }
                } 
                else if (abs(dx) >= abs(dy))
                {
                    sinal = dx >= 0 ? 1 : -1;
                    for (x = x1, i = 0; i <= comp; ++i, x += sinal)
                    {
                        y = (int)Math.Round(y1 + (x - x1) * m);
                        writePixel(bmpdata, x, y, cor);
                    }
                }
                else
                {
                    sinal = dy >= 0 ? 1 : -1;
                    for (y = y1, i = 0; i <= comp; ++i, y += sinal)
                    {
                        x = (int)Math.Round(x1 + (y - y1) / m);
                        writePixel(bmpdata, x, y, cor);
                    }
                }
            }
            bmp.UnlockBits(bmpdata);
        }

        public void dLinDDA(Bitmap bmp, int x1, int y1, int x2, int y2, Color cor)
        {

            BitmapData bmpData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            unsafe
            {
                int comp, i;
                double x, y, xinc, yinc;
                comp = abs(x2 - x1) > abs(y2 - y1) ? abs(x2 - x1) : abs(y2 - y1);
                xinc = (double)(x2 - x1) / comp;
                yinc = (double)(y2 - y1) / comp;

                x = x1; y = y1;
                i = 0;
                while (i <= comp)
                {   
                    writePixel(bmpData, (int)Math.Round(x), (int)(Math.Round(y)), cor);
                    x += xinc;
                    y += yinc;
                    ++i;
                }
            }
            bmp.UnlockBits(bmpData);
        } 

        public void dLinXor(Bitmap bmp, int x1, int y1, int x2, int y2, Color cor)
        {

            BitmapData bmpData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            unsafe
            {
                bresenhamXor(bmpData, x1, y1, x2, y2, cor);
            }
            bmp.UnlockBits(bmpData);
        }

        private unsafe void bresenhamXor(BitmapData data, int x1, int y1, int x2, int y2, Color cor)
        {

            int dx = x2 - x1, x, y;
            int dy = y2 - y1;
            int declive = 1;

            int incE, incNE, d;
            if (abs(dx) > abs(dy))
            { 
                if (x1 > x2)
                { 
                    bresenhamXor(data, x2, y2, x1, y1, cor);
                    return;
                }
                if (y1 > y2)
                {   
                    declive = -1;
                    dy = -dy;
                }
                
                incE = 2 * dy;
                incNE = 2 * (dy - dx);
                d = incNE;

                y = y1;
                for (x = x1; x <= x2; ++x)
                {
                    if (inImage(data, x, y))
                        writePixelXor(data, x, y, cor);
                    if (d < 0) 
                        d += incE;
                    else
                    {   
                        d += incNE;
                        y += declive;
                    }
                }
            } 
            else
            { 
                if (y1 > y2)
                { 
                    bresenhamXor(data, x2, y2, x1, y1, cor);
                    return;
                }
                if (x1 > x2)
                {   
                    declive = -1;
                    dx = -dx;
                }
                
                incE = 2 * dx;
                incNE = 2 * (dx - dy);
                d = incNE;

                x = x1;
                for (y = y1; y <= y2; ++y)
                {
                    if (inImage(data, x, y))
                        writePixelXor(data, x, y, cor);
                    if (d < 0) 
                        d += incE;
                    else
                    {   
                        d += incNE;
                        x += declive;
                    }
                }
            } 
        }
        public void dLinBresenham(Bitmap bmp, int x1, int y1, int x2, int y2, Color cor)
        {   
            BitmapData bmpdata = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            unsafe
            {
                bresenham(bmpdata, x1, y1, x2, y2, cor);
            }

            bmp.UnlockBits(bmpdata);
        }

        private unsafe void bresenham(BitmapData data, int x1, int y1, int x2, int y2, Color cor)
        {

            int dx = x2 - x1, x, y;
            int dy = y2 - y1;
            int declive = 1;

            int incE, incNE, d;
            if (abs(dx) > abs(dy))
            {
                if (x1 > x2)
                { 
                    bresenham(data, x2, y2, x1, y1, cor);
                    return;
                }
                if (y1 > y2)
                {  
                    declive = -1;
                    dy = -dy;
                }

                incE = 2 * dy;
                incNE = 2 * (dy - dx);
                d = incNE;

                y = y1;
                for (x = x1; x <= x2; ++x)
                {
                    if (inImage(data, x, y))
                        writePixel(data, x, y, cor);
                    if (d < 0) 
                        d += incE;
                    else
                    {   
                        d += incNE;
                        y += declive;
                    }
                }
            } 
            else
            {
                if (y1 > y2)
                { 
                    bresenham(data, x2, y2, x1, y1, cor);
                    return;
                }
                if (x1 > x2)
                {   
                    declive = -1;
                    dx = -dx;
                }

                incE = 2 * dx;
                incNE = 2 * (dx - dy);
                d = incNE;

                x = x1;
                for (y = y1; y <= y2; ++y)
                {
                    if (inImage(data, x, y))
                        writePixel(data, x, y, cor);
                    if (d < 0) 
                        d += incE;
                    else
                    { 
                        d += incNE;
                        x += declive;
                    }
                }
            }
        }

        public void dCircleEqGeral(Bitmap bmp, int cx, int cy, double raio, Color cor)
        {

            BitmapData data = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            unsafe
            {
                double x = 0, y = raio;
                double limite = raio / Math.Sqrt(2);
                for (x = 0, y = raio; x <= limite; ++x)
                {
                    writeSimetria8(data, cx, cy, (int)x, (int)y, cor);
                    y = Math.Sqrt(Math.Pow(raio, 2) - Math.Pow(x, 2));
                }

            }

            bmp.UnlockBits(data);

        }

        public void dCircleTrigonometry(Bitmap bmp, int cx, int cy, double raio, Color cor)
        {

            BitmapData data = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            unsafe
            {
                double x = 0, y = raio;
                double limite = raio / Math.Sqrt(2);
                writeSimetria8(data, cx, cy, (int)x, (int)y, cor);
                for (double ang = 90; ang >= 45; --ang)
                {
                    x = raio * Math.Cos(ang * 180 / pi);
                    y = raio * Math.Sin(ang * 180 / pi);
                    writeSimetria8(data, cx, cy, (int)x, (int)y, cor);
                }

            }

            bmp.UnlockBits(data);
        }

        public void dCirclePontoMedio(Bitmap bmp, int cx, int cy, double raio, Color cor)
        {
            
            BitmapData data = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            unsafe
            {
                int x, y;
                double d = 1 - raio;
                for (x = 0, y = (int)raio; y >= x; ++x)
                {
                    writeSimetria8(data, cx, cy, x, y, cor);
                    if (d < 0)
                        d += 2 * x + 3;
                    else
                    {
                        d += 2 * (x - y) + 5;
                        --y;
                    }
                }

            }

            bmp.UnlockBits(data);
        }


        public void dElipsePontoMedio(Bitmap bmp, int cx, int cy, int dx, int dy, Color cor)
        {
            BitmapData data = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            unsafe
            {
                int x, y;
                double d1, d2;

                x = 0;
                y = dy;
                d1 = dy * dx - dx * dx * dy + dx * dx / 4.0;

                writeSimetria4(data, cx, cy, x, y, cor);
                while (dx * dx * (y - 0.5) > dy * dy * (x + 1))
                {
                    //1
                    if (d1 < 0)
                    {
                        d1 += dy * dy * (2 * x + 3);
                        ++x;
                    }
                    else
                    {
                        d1 = d1 + dy * dy * (2 * x + 3) + dx * dx * (-2 * y + 2);
                        x++;
                        y--;
                    }
                    writeSimetria4(data, cx, cy, x, y, cor);
                }

                d2 = dy * dy * (x + 0.5) * (x + 0.5) + dx * dx * (y - 1) * (y - 1) - dx * dx * dy * dy;
                while (y > 0)
                {
                    //2
                    if (d2 < 0)
                    {
                        d2 = d2 + dy * dy * (2 * x + 2) + dx * dx * (-2 * y + 3);
                        x++;
                        y--;
                    }
                    else
                    {
                        d2 = d2 + dx * dx * (-2 * y + 3);
                        y--;
                    }
                    writeSimetria4(data, cx, cy, x, y, cor);
                }

            }

            bmp.UnlockBits(data);
        }


        private unsafe void writeSimetria4(BitmapData data, int cx, int cy, int dx, int dy, Color cor)
        {
            if (inImage(data, cx + dx, cy - dy)) // 1o Quadrante
                writePixel(data, cx + dx, cy - dy, cor);
            if (inImage(data, cx - dx, cy - dy)) // 2o Quadrante
                writePixel(data, cx - dx, cy - dy, cor);
            if (inImage(data, cx - dx, cy + dy)) // 3o Quadrante
                writePixel(data, cx - dx, cy + dy, cor);
            if (inImage(data, cx + dx, cy + dy)) // 4o Quadrante
                writePixel(data, cx + dx, cy + dy, cor);
        }

        private unsafe void writeSimetria8(BitmapData data, int cx, int cy, int dx, int dy, Color cor)
        {
            if (inImage(data, cx + dy, cy - dx)) // 1o Octante
                writePixel(data, cx + dy, cy - dx, cor);
            if (inImage(data, cx + dx, cy - dy)) // 2o Octante
                writePixel(data, cx + dx, cy - dy, cor);
            if (inImage(data, cx - dx, cy - dy)) // 3o Octante
                writePixel(data, cx - dx, cy - dy, cor);
            if (inImage(data, cx - dy, cy - dx)) // 4o Octante
                writePixel(data, cx - dy, cy - dx, cor);
            if (inImage(data, cx - dy, cy + dx)) // 5o Octante
                writePixel(data, cx - dy, cy + dx, cor);
            if (inImage(data, cx - dx, cy + dy)) // 6o Octante
                writePixel(data, cx - dx, cy + dy, cor);
            if (inImage(data, cx + dx, cy + dy)) // 7o Octante
                writePixel(data, cx + dx, cy + dy, cor);
            if (inImage(data, cx + dy, cy + dx)) // 8o Octante
                writePixel(data, cx + dy, cy + dx, cor);
        }

        private void unlock(Bitmap bmp, BitmapData data)
        {
            bmp.UnlockBits(data);
        }


        private unsafe byte* gotoxy(BitmapData bmp, int x, int y)
        {
            byte* aux = (byte*)bmp.Scan0.ToPointer();
            aux += y * bmp.Stride; // lin
            aux += 3 * x; // col
            return aux;
        }

        private unsafe byte* gotoxy(int x, int y, BitmapData bmp)
        {
            return gotoxy(bmp, x, y);
        }

        private unsafe void writePixel(BitmapData bmp, int x, int y, Color cor)
        {
            byte* aux = gotoxy(x, y, bmp);
            *aux = cor.B;
            *(aux + 1) = cor.G;
            *(aux + 2) = cor.R;
        }
        private unsafe void writePixelXor(BitmapData bmp, int x, int y, Color cor)
        {
            byte* aux = gotoxy(x, y, bmp);
            *aux ^= cor.B;
            *(aux + 1) ^= cor.G;
            *(aux + 2) ^= cor.R;
        }
        public void writePixel(Bitmap bmp, int x, int y, Color cor)
        {   
            BitmapData bmpdata = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            unsafe
            {
                byte* aux = gotoxy(x, y, bmpdata);
                *aux = (byte)cor.B;
                *(aux + 1) = (byte)cor.G;
                *(aux + 2) = (byte)cor.R;
            }
            
            bmp.UnlockBits(bmpdata);
        }
        public void dPoligono(Bitmap bmp, Poligono poligono, Color cor)
        {
            if (poligono.Pontos == null)
            {
                bool f = 1 == 1;
            }
            List<Ponto> pontos = poligono.Pontos;
            for (int i = 0; i + 1 < pontos.Count; ++i)
            {
                dLinBresenham(bmp, (int)pontos[i].X, (int)pontos[i].Y,
                    (int)pontos[i + 1].X, (int)pontos[i + 1].Y, poligono.corBorda);
            }
            dLinBresenham(bmp, (int)pontos[pontos.Count - 1].X, (int)pontos[pontos.Count - 1].Y,
                (int)pontos[0].X, (int)pontos[0].Y, cor);
        }
    } 
}
