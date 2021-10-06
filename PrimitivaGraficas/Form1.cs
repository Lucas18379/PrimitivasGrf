using primitivas_graficas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimitivaGraficas
{

    public partial class Form1 : Form
    {
        private int op;
        private Desenhar desenhar;
        private List<Reta> listaReta;
        private List<Poligono> listPoligono;
        private List<Circulo> listCirculo;
        private Poligono poligono;
        private Bitmap bmp;
        private DataTable dtPoligonos;
        private DataTable dtPontos;
        private bool flagPoligono;
        private int x1, y1, x2, y2, xi, yi;
        private const int
            scanline=-1,
            nada=0,
            floodfill=1,
            rEGeral=2,
            rDDA=3,
            rPMedio=4,
            cEGeral=5,
            cTrigo=6,
            cPMedio=7,
            elipse=8,
            poligono_=9;

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            double raio;
            x2 = e.X;
            y2 = e.Y;
            if (y2 < 0)
                y2 = 0;
            else if (y2 > bmp.Height)
                y2 = bmp.Height - 1;
            if (x2 < 0)
                x2 = 0;
            else if (x2 > bmp.Width)
                x2 = bmp.Width - 1;
            if (op == rEGeral)
            {
                desenhar.dLinEqGeral(bmp, x1, y1, x2, y2, btCor.BackColor);
            }
            else if (op == rDDA)
            {
                desenhar.dLinDDA(bmp, x1, y1, x2, y2, btCor.BackColor);
            }
            else if (op == rPMedio)
            {
                desenhar.dLinBresenham(bmp, x1, y1, x2, y2, btCor.BackColor);
            }
            else if (op == cEGeral)
            {

                raio = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
                desenhar.dCircleEqGeral(bmp, x1, y1, raio, btCor.BackColor);
            }
            else if (op == cTrigo)
            {
                raio = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
                desenhar.dCircleTrigonometry(bmp, x1, y1, raio, btCor.BackColor);
            }
            else if (op == cPMedio)
            {
                raio = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
                desenhar.dCirclePontoMedio(bmp, x1, y1, raio, btCor.BackColor);
            }
            else if (op == elipse)
            {
                raio = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
                desenhar.dElipsePontoMedio(bmp, x1, y1, Math.Abs(x1 - x2),
                    Math.Abs(y1 - y2), btCor.BackColor);
            }
            pictureBox.Refresh();
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Clicks >= 2)
                return;
            if (e.Button == MouseButtons.Right && poligono != null) 
            {
                xi = x1 = e.X;
                yi = y1 = e.Y;
                if (op == poligono_ && flagPoligono)
                {
                    poligono.addPonto(x1, y1);
                    novaReta();
                    int idxUltimo = poligono.Pontos.Count - 1;
                    desenhar.dLinBresenham(bmp, (int)poligono.getPonto(0).X,
                        (int)poligono.getPonto(0).Y, (int)poligono.getPonto(idxUltimo).X,
                        (int)poligono.getPonto(idxUltimo).Y, poligono.corBorda);
                    pictureBox.Refresh(); 
                    listPoligono.Add(poligono);
                    DataRow dr = dtPoligonos.NewRow();
                    dr["poligono"] = "Poligono " + listPoligono.Count;
                    dtPoligonos.Rows.Add(dr);
                    dgvPoligono.DataSource = dtPoligonos;
                    dtPontos.Clear();
                    dgvPoligono.ClearSelection();
                    dgvPoligono.Rows[listPoligono.Count - 1].Selected = true;
                    op = nada;
                    flagPoligono = false;
                    poligono = null;
                }
            }
            else if (e.Button == MouseButtons.Left) 
            {
                xi = x1 = e.X;
                yi = y1 = e.Y;

                x2 = e.X;
                y2 = e.Y;
                if (op == poligono_)
                {
                    if (poligono == null)
                        poligono = new Poligono(btCor.BackColor);
                    poligono.addPonto(x1, y1);
                    novaReta();
                }
                if (op == nada && listPoligono.Count > 0)
                    checkPoligono(x1, y1);
                switch (op) 
                {
                    case floodfill:
                        desenhar.floodFill(bmp, x1, y1, btCor.BackColor);
                        op = nada;
                        break;
                }
            }
        }

        private void corToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            btCor.BackColor = colorDialog1.Color;
        }

        private void btNovoPoligono_Click(object sender, EventArgs e)
        {
            op = poligono_;
            flagPoligono = false;
            x1 = y1 = x2 = y2 = 0;
        }

        private void dgvPontos_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvPoligono.SelectedRows != null && dgvPontos.SelectedRows != null)
                {

                    atualizaall();
                    Poligono poli = listPoligono[dgvPoligono.SelectedRows[0].Index];
                    int idx = dgvPontos.SelectedRows[0].Index;
                    desenhar.dCirclePontoMedio(bmp, (int)poli.Pontos[idx].X,
                        (int)poli.Pontos[idx].Y, 10, btCor.BackColor);
                    pictureBox.Refresh();
                }
            }
            catch (Exception) { }
        }

        private void atualizaall()
        {
           
            desenhar.paint(bmp, Color.FromArgb(255, 255, 255));
            foreach (Poligono p in listPoligono)
            {
                if (p.fundoAtivo())
                {
                    desenhar.scanLine(bmp, p, p.corFundo);
                    desenhar.dPoligono(bmp, p, p.corFundo);
                }
                else
                    desenhar.dPoligono(bmp, p, p.corBorda);
            }
            pictureBox.Refresh();
        }

        private void dgvPoligono_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPoligono.SelectedRows.Count > 0)
            {
                int idx = dgvPoligono.SelectedRows[0].Index;
                dtPontos.Clear();
                selecionarPoligono(idx);

            }
        }
        private void selecionarPoligono(int idx)
        {
            DataRow dr;
            foreach (Ponto p in listPoligono[idx].Pontos)
            {
                dr = dtPontos.NewRow();
                dr["X"] = p.X;
                dr["Y"] = p.Y;
                dtPontos.Rows.Add(dr);
            }
            for (int i = 0; i < listPoligono.Count; ++i)
            {
                if (i == idx)
                    listPoligono[i].corBorda = Color.FromArgb(255, 0, 0);
                else
                    listPoligono[i].corBorda = Color.FromArgb(0, 0, 0);
            }
            atualizaall();
        }

        private void floodFillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            op = floodfill;
        }

        private void scanLineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvPoligono.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um poligono", "",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                atualizaall();
                int idx = dgvPoligono.SelectedRows[0].Index;
                Poligono poli = listPoligono[idx];
                desenhar.scanLine(bmp, poli, btCor.BackColor);
                poli.corFundo = btCor.BackColor;
                poli.setFundo(true);
                pictureBox.Refresh();
            }
        }

        private void btTrans_Click(object sender, EventArgs e)
        {
            if (dgvPoligono.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um poligono", "",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                int idx = dgvPoligono.SelectedRows[0].Index;
                Poligono poli = listPoligono[idx];
                Color cor = poli.corBorda;
                int x = 0, y = 0;
                if (!int.TryParse(tbXtrans.Text, out x))
                    x = 0;
                if (!int.TryParse(tbYtrans.Text, out y))
                    y = 0;
                poli.translacao(x, y);

                atualizaall();
            }
        }

        private void btEsc_Click(object sender, EventArgs e)
        {    
            if (dgvPoligono.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um poligono", "",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                int idx = dgvPoligono.SelectedRows[0].Index;
                Poligono poli = listPoligono[idx];
                double x, y;
                if (!double.TryParse(tbXesc.Text, out x))
                    x = 1;
                if (!double.TryParse(tbYesc.Text, out y))
                    y = 1;

                poli.escala(x, y);
                atualizaall();
            }
        }

        private void btRot_Click(object sender, EventArgs e)
        {
            if (dgvPoligono.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um poligono", "",
                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                Poligono poli = listPoligono[dgvPoligono.SelectedRows[0].Index];
                Color cor = poli.corBorda;
                poli.rotacao(Convert.ToDouble(tbAng.Text), getPontoTransformacao(poli));
                poli.setFundo(false);
                atualizaall();
            }
        }

        private void btCis_Click(object sender, EventArgs e)
        {
            if (dgvPoligono.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um poligono", "",
                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                double vx = 0;
                if (tbXcis.Text.Length > 0 && !double.TryParse(tbXcis.Text, out vx))
                {
                    MessageBox.Show("Informe um valor válido para o cisalhamento em X",
                        "Primitivas Gráficas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    tbXcis.ForeColor = Color.Red;
                }
                else
                {
                    double vy = 0;
                    tbXcis.ForeColor = Color.Black;
                    if (tbYcis.Text.Length > 0 && !double.TryParse(tbYcis.Text, out vy))
                    {
                        MessageBox.Show("Informe um valor válido para o cisalhamento em Y",
                            "Primitivas Gráficas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        tbYcis.ForeColor = Color.Red;
                    }
                    else
                    {
                        tbYcis.ForeColor = Color.Black;
                        int idx = dgvPoligono.SelectedRows[0].Index;
                        Poligono poli = listPoligono[idx];
                        poli.cisalhamentoX(vx);
                        poli.cisalhamentoY(vy);
                        atualizaall();
                    }
                }

            }
        }

        private void btEsp_Click(object sender, EventArgs e)
        {
            if (dgvPoligono.SelectedRows == null)
                MessageBox.Show("Selecione um poligono", "",
                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                int idx = dgvPoligono.SelectedRows[0].Index;
                Poligono poli = listPoligono[idx];
                if (rbXesp.Checked)
                {
                    poli.espelhamentoX(getPontoTransformacao(poli));
                }
                else
                { 
                    poli.espelhamentoY(getPontoTransformacao(poli));
                }
                atualizaall();
            }
        }

        private void rbPontoA_CheckedChanged(object sender, EventArgs e)
        {
            tbXpontoA.Enabled = rbPontoA.Checked;
            tbYpontoA.Enabled = rbPontoA.Checked;
        }

        private void cbbPoligonosVP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbPoligonosVP.SelectedIndex >= 0)
            {
                selecionarPoligono(cbbPoligonosVP.SelectedIndex);
            }
        }

        private void btAplicarViewPort_Click(object sender, EventArgs e)
        {
            int alt, larg, idx;
            if ((idx = cbbPoligonosVP.SelectedIndex) < 0)
            {
                MessageBox.Show("Selecione um poligono", "",
                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (!int.TryParse(tbAlturaVP.Text, out alt) || !int.TryParse(tbLarguraVP.Text, out larg))
            {
                MessageBox.Show("Informe valores validos para as dimensões do ViewPort!!", "Primitivas Gráficas",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Poligono poli = listPoligono[idx];
                Form viewPort = new Form();
                viewPort.Width = larg + 50 < 100 ? 100 : larg + 50;
                viewPort.Height = alt + 80;
                PictureBox pbox = new PictureBox();
                pbox.Width = larg + 10;
                pbox.Height = alt + 10;
                pbox.Location = new Point(10, 10);
                viewPort.Controls.Add(pbox);
                Bitmap bmp2 = new Bitmap(larg + 1, alt + 1);
                desenhar.paint(bmp2, Color.FromArgb(255, 255, 255));
                Poligono poli2 = listPoligono[idx].getCopy();
                poli2.viewPort(larg, alt);
                desenhar.dPoligono(bmp2, poli2, Color.FromArgb(0, 0, 0));
                pbox.Image = bmp2;
                viewPort.ShowDialog();
            }
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == tpPoligonos)
            {
                dgvPoligono.ClearSelection();
                dtPontos.Clear();
            }
            else if (tabControl.SelectedTab == tpViewPort)
            {
                cbbPoligonosVP.SelectedIndex = -1;
                if (dgvPoligono.SelectedRows.Count > 0)
                {
                    int idx = dgvPoligono.SelectedRows[0].Index;
                    listPoligono[idx].corBorda = Color.FromArgb(0, 0, 0);
                    desenhar.dPoligono(bmp, listPoligono[idx], Color.FromArgb(0, 0, 0));
                    pictureBox.Refresh();
                }
            }
        }

        private void gbTranslacao_Enter(object sender, EventArgs e)
        {

        }

        private void tbXtrans_TextChanged(object sender, EventArgs e)
        {
            if (tbXtrans.Text != "" || tbYtrans.Text != "")
                btTrans.Enabled = true;
            else
                btTrans.Enabled = false;
        }

        private void tbXesc_TextChanged(object sender, EventArgs e)
        {
            if (tbXesc.Text != "" || tbYesc.Text != "")
                btEsc.Enabled = true;
            else
                btEsc.Enabled = false;
        }

        private void tbXcis_TextChanged(object sender, EventArgs e)
        {
            if (tbXcis.Text != "" || tbYcis.Text != "")
                btCis.Enabled = true;
            else
                btCis.Enabled = false; ;
        }

        private void tbAng_TextChanged(object sender, EventArgs e)
        {
            if (tbAng.Text != "" &&
                ((rbPontoA.Checked && (tbXpontoA.Text != "" || tbYpontoA.Text != ""))
                    || !rbPontoA.Checked))
                btRot.Enabled = true;
            else
                btRot.Enabled = false;
        }

        private void tbYpontoA_TextChanged(object sender, EventArgs e)
        {
            if (tbXcis.Text != "" || tbYcis.Text != "")
                btCis.Enabled = true;
            else
                btCis.Enabled = false;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void tbXpontoA_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelXVP_Click(object sender, EventArgs e)
        {

        }

        private void tbLarguraVP_TextChanged(object sender, EventArgs e)
        {

        }

        public void checkPoligono(int x, int y)
        {
            int contIntersec, i = listPoligono.Count - 1, xI, yI;
            bool inside = false;
       
            int xmin, ymin, xmax, ymax, idant = -1;
            double dx, dy, m, b; 
            if (dgvPoligono.SelectedRows != null && dgvPoligono.SelectedRows.Count > 0)
            {
                idant = dgvPoligono.SelectedRows[0].Index;
                dgvPoligono.CurrentCell = null;
                dtPontos.Rows.Clear();
                listPoligono[idant].corBorda = Color.FromArgb(0, 0, 0);
                desenhar.dPoligono(bmp, listPoligono[idant], Color.FromArgb(0, 0, 0));
                pictureBox.Refresh();
            }
            while (i >= 0 && !inside)
            {
                contIntersec = 0;

                if (i != idant)
                {
                    listPoligono[i].getMaximosEMinimos(out xmin, out ymin, out xmax, out ymax);
                    Ponto pmax = new Ponto(xmax, ymax);
                    Ponto pmin = new Ponto(xmin, ymin);
                    if (ddRectangle(x, y, pmin, pmax))
                    {
                        inside = true;
                        dgvPoligono.CurrentCell = dgvPoligono.Rows[i].Cells[0];
                    }
                }
                --i;
            }
        }
        private bool ddRectangle(int x, int y, Ponto pmin, Ponto pmax)
        {
            return x >= pmin.X && y >= pmin.Y && x <= pmax.X && y <= pmax.Y;
        }

        private void novaReta()
        {
            if (flagPoligono && poligono.Pontos.Count > 1)
            {
                int idxUltimo = poligono.Pontos.Count - 1;
                desenhar.dLinBresenham(bmp, (int)poligono.getPonto(idxUltimo - 1).X,
                    (int)poligono.getPonto(idxUltimo - 1).Y, (int)poligono.getPonto(idxUltimo).X,
                    (int)poligono.getPonto(idxUltimo).Y, poligono.corBorda);
                pictureBox.Refresh();
            }
            flagPoligono = true;
        }
        public Form1()
        {
            InitializeComponent();
            inicia();
        }
        public void inicia()
        {
            bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
            desenhar = new Desenhar();
            desenhar.paint(bmp, Color.FromArgb(255, 255, 255));
            pictureBox.Image = bmp;
            flagPoligono = false;
            op = 0;
            dtPoligonos = new DataTable();
            dtPontos = new DataTable();
            dtPontos.Columns.Add("X");
            dtPontos.Columns.Add("Y");
            dtPoligonos.Columns.Add("poligono");
            dgvPoligono.DataSource = dtPoligonos;
            dgvPontos.DataSource = dtPontos;
            cbbPoligonosVP.DataSource = dtPoligonos;
            cbbPoligonosVP.DisplayMember = "poligono";
            listPoligono = new List<Poligono>();
        }
        private void RetaequaçãoGeralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            op = rEGeral;
        }

        private void RetadDDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            op = rDDA;
        }

        private void RetapontoMedioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            op = rPMedio;
        }

        private void CirequaçãoGeralToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            op = cEGeral;
        }

        private void CirtrigonometriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            op = cTrigo;
        }

        private void CirpontoMedioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            op = cPMedio;
        }

        private void elipseToolMenuItem_Click(object sender, EventArgs e)
        {
            op = elipse;
        }

        private void limparToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inicia(); 
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if(op == poligono_ && poligono != null && poligono.Pontos.Count > 0)
            {
                List<Ponto> pontos = poligono.Pontos;
                int x1 = (int)pontos[pontos.Count - 1].X;
                int y1 = (int)pontos[pontos.Count - 1].Y;
                desenhar.dLinXor(bmp, x1, y1, x2, y2, Color.FromArgb(255, 255, 255));
                x2 = e.X;
                y2 = e.Y;
                desenhar.dLinXor(bmp, x1, y1, x2, y2, Color.FromArgb(255, 255, 255));
                pictureBox.Refresh();
            }
        }
        private Ponto getPontoTransformacao(Poligono poli)
        {
            double x, y;
            Ponto ponto;
            if (rbCenter.Checked)
                ponto = poli.getCentro();
            else if (rbOri.Checked)
                ponto = new Ponto(0, 0);
            else
            {
                if (!double.TryParse(tbXpontoA.Text, out x))
                {
                    x = 0;
                    tbXpontoA.Text = "0";
                }
                if (!double.TryParse(tbYpontoA.Text, out y))
                {
                    y = 0;
                    tbYpontoA.Text = "0";
                }
                ponto = new Ponto(x, y);
            }
            return ponto;
        }
    }
}
