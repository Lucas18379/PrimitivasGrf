namespace PrimitivaGraficas
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.novaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equaçãoGeralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dDAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pontoMedioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circunferenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equaçãoGeralToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.trigonometriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pontoMedioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.elipseToolMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limparToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preencherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.floodFillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scanLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.corToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tpPoligonos = new System.Windows.Forms.TabPage();
            this.btNovoPoligono = new System.Windows.Forms.Button();
            this.dgvPontos = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPoligono = new System.Windows.Forms.DataGridView();
            this.colPoligono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpTrans2D = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rbPontoA = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.rbCenter = new System.Windows.Forms.RadioButton();
            this.tbYpontoA = new System.Windows.Forms.TextBox();
            this.tbXpontoA = new System.Windows.Forms.TextBox();
            this.rbOri = new System.Windows.Forms.RadioButton();
            this.gbEspelhamento = new System.Windows.Forms.GroupBox();
            this.rbYesp = new System.Windows.Forms.RadioButton();
            this.rbXesp = new System.Windows.Forms.RadioButton();
            this.btEsp = new System.Windows.Forms.Button();
            this.gbCisalhamento = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btCis = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbXcis = new System.Windows.Forms.TextBox();
            this.tbYcis = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btEsc = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbXesc = new System.Windows.Forms.TextBox();
            this.tbYesc = new System.Windows.Forms.TextBox();
            this.gbRotacao = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btRot = new System.Windows.Forms.Button();
            this.tbAng = new System.Windows.Forms.TextBox();
            this.gbTranslacao = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btTrans = new System.Windows.Forms.Button();
            this.tbYtrans = new System.Windows.Forms.TextBox();
            this.tbXtrans = new System.Windows.Forms.TextBox();
            this.tpViewPort = new System.Windows.Forms.TabPage();
            this.labelXVP = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btAplicarViewPort = new System.Windows.Forms.Button();
            this.tbAlturaVP = new System.Windows.Forms.TextBox();
            this.tbLarguraVP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbPoligonosVP = new System.Windows.Forms.ComboBox();
            this.btCor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tpPoligonos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPontos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoligono)).BeginInit();
            this.tpTrans2D.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbEspelhamento.SuspendLayout();
            this.gbCisalhamento.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbRotacao.SuspendLayout();
            this.gbTranslacao.SuspendLayout();
            this.tpViewPort.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaToolStripMenuItem,
            this.limparToolStripMenuItem,
            this.preencherToolStripMenuItem,
            this.corToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(905, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // novaToolStripMenuItem
            // 
            this.novaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.retaToolStripMenuItem,
            this.circunferenciaToolStripMenuItem,
            this.elipseToolMenuItem});
            this.novaToolStripMenuItem.Name = "novaToolStripMenuItem";
            this.novaToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.novaToolStripMenuItem.Text = "Nova";
            // 
            // retaToolStripMenuItem
            // 
            this.retaToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.retaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.equaçãoGeralToolStripMenuItem,
            this.dDAToolStripMenuItem,
            this.pontoMedioToolStripMenuItem});
            this.retaToolStripMenuItem.Name = "retaToolStripMenuItem";
            this.retaToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.retaToolStripMenuItem.Text = "Reta";
            // 
            // equaçãoGeralToolStripMenuItem
            // 
            this.equaçãoGeralToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.equaçãoGeralToolStripMenuItem.Name = "equaçãoGeralToolStripMenuItem";
            this.equaçãoGeralToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.equaçãoGeralToolStripMenuItem.Text = "Equação Geral";
            this.equaçãoGeralToolStripMenuItem.Click += new System.EventHandler(this.RetaequaçãoGeralToolStripMenuItem_Click);
            // 
            // dDAToolStripMenuItem
            // 
            this.dDAToolStripMenuItem.Name = "dDAToolStripMenuItem";
            this.dDAToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dDAToolStripMenuItem.Text = "DDA";
            this.dDAToolStripMenuItem.Click += new System.EventHandler(this.RetadDDAToolStripMenuItem_Click);
            // 
            // pontoMedioToolStripMenuItem
            // 
            this.pontoMedioToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pontoMedioToolStripMenuItem.Name = "pontoMedioToolStripMenuItem";
            this.pontoMedioToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pontoMedioToolStripMenuItem.Text = "Ponto Médio";
            this.pontoMedioToolStripMenuItem.Click += new System.EventHandler(this.RetapontoMedioToolStripMenuItem_Click);
            // 
            // circunferenciaToolStripMenuItem
            // 
            this.circunferenciaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.equaçãoGeralToolStripMenuItem1,
            this.trigonometriaToolStripMenuItem,
            this.pontoMedioToolStripMenuItem1});
            this.circunferenciaToolStripMenuItem.Name = "circunferenciaToolStripMenuItem";
            this.circunferenciaToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.circunferenciaToolStripMenuItem.Text = "Circunferência";
            // 
            // equaçãoGeralToolStripMenuItem1
            // 
            this.equaçãoGeralToolStripMenuItem1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.equaçãoGeralToolStripMenuItem1.Name = "equaçãoGeralToolStripMenuItem1";
            this.equaçãoGeralToolStripMenuItem1.Size = new System.Drawing.Size(153, 22);
            this.equaçãoGeralToolStripMenuItem1.Text = "Equação Geral";
            this.equaçãoGeralToolStripMenuItem1.Click += new System.EventHandler(this.CirequaçãoGeralToolStripMenuItem1_Click);
            // 
            // trigonometriaToolStripMenuItem
            // 
            this.trigonometriaToolStripMenuItem.Name = "trigonometriaToolStripMenuItem";
            this.trigonometriaToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.trigonometriaToolStripMenuItem.Text = "Trigonometria";
            this.trigonometriaToolStripMenuItem.Click += new System.EventHandler(this.CirtrigonometriaToolStripMenuItem_Click);
            // 
            // pontoMedioToolStripMenuItem1
            // 
            this.pontoMedioToolStripMenuItem1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pontoMedioToolStripMenuItem1.Name = "pontoMedioToolStripMenuItem1";
            this.pontoMedioToolStripMenuItem1.Size = new System.Drawing.Size(153, 22);
            this.pontoMedioToolStripMenuItem1.Text = "Ponto Medio";
            this.pontoMedioToolStripMenuItem1.Click += new System.EventHandler(this.CirpontoMedioToolStripMenuItem1_Click);
            // 
            // elipseToolMenuItem
            // 
            this.elipseToolMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.elipseToolMenuItem.Name = "elipseToolMenuItem";
            this.elipseToolMenuItem.Size = new System.Drawing.Size(155, 22);
            this.elipseToolMenuItem.Text = "Elipse";
            this.elipseToolMenuItem.Click += new System.EventHandler(this.elipseToolMenuItem_Click);
            // 
            // limparToolStripMenuItem
            // 
            this.limparToolStripMenuItem.Name = "limparToolStripMenuItem";
            this.limparToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.limparToolStripMenuItem.Text = "Limpar";
            this.limparToolStripMenuItem.Click += new System.EventHandler(this.limparToolStripMenuItem_Click);
            // 
            // preencherToolStripMenuItem
            // 
            this.preencherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.floodFillToolStripMenuItem,
            this.scanLineToolStripMenuItem});
            this.preencherToolStripMenuItem.Name = "preencherToolStripMenuItem";
            this.preencherToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.preencherToolStripMenuItem.Text = "Preencher";
            // 
            // floodFillToolStripMenuItem
            // 
            this.floodFillToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.floodFillToolStripMenuItem.Name = "floodFillToolStripMenuItem";
            this.floodFillToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.floodFillToolStripMenuItem.Text = "FloodFill";
            this.floodFillToolStripMenuItem.Click += new System.EventHandler(this.floodFillToolStripMenuItem_Click);
            // 
            // scanLineToolStripMenuItem
            // 
            this.scanLineToolStripMenuItem.Name = "scanLineToolStripMenuItem";
            this.scanLineToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.scanLineToolStripMenuItem.Text = "ScanLine";
            this.scanLineToolStripMenuItem.Click += new System.EventHandler(this.scanLineToolStripMenuItem_Click);
            // 
            // corToolStripMenuItem
            // 
            this.corToolStripMenuItem.Name = "corToolStripMenuItem";
            this.corToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.corToolStripMenuItem.Text = "Cor";
            this.corToolStripMenuItem.Click += new System.EventHandler(this.corToolStripMenuItem_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(13, 28);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(640, 456);
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tpPoligonos);
            this.tabControl.Controls.Add(this.tpTrans2D);
            this.tabControl.Controls.Add(this.tpViewPort);
            this.tabControl.Location = new System.Drawing.Point(659, 28);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(234, 456);
            this.tabControl.TabIndex = 2;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tpPoligonos
            // 
            this.tpPoligonos.Controls.Add(this.btNovoPoligono);
            this.tpPoligonos.Controls.Add(this.dgvPontos);
            this.tpPoligonos.Controls.Add(this.dgvPoligono);
            this.tpPoligonos.Location = new System.Drawing.Point(4, 22);
            this.tpPoligonos.Name = "tpPoligonos";
            this.tpPoligonos.Padding = new System.Windows.Forms.Padding(3);
            this.tpPoligonos.Size = new System.Drawing.Size(226, 430);
            this.tpPoligonos.TabIndex = 0;
            this.tpPoligonos.Text = "Poligonos";
            this.tpPoligonos.UseVisualStyleBackColor = true;
            // 
            // btNovoPoligono
            // 
            this.btNovoPoligono.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btNovoPoligono.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNovoPoligono.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNovoPoligono.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btNovoPoligono.Location = new System.Drawing.Point(71, 6);
            this.btNovoPoligono.Name = "btNovoPoligono";
            this.btNovoPoligono.Size = new System.Drawing.Size(90, 35);
            this.btNovoPoligono.TabIndex = 11;
            this.btNovoPoligono.Text = "Novo";
            this.btNovoPoligono.UseVisualStyleBackColor = false;
            this.btNovoPoligono.Click += new System.EventHandler(this.btNovoPoligono_Click);
            // 
            // dgvPontos
            // 
            this.dgvPontos.AllowUserToAddRows = false;
            this.dgvPontos.AllowUserToDeleteRows = false;
            this.dgvPontos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPontos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y});
            this.dgvPontos.Location = new System.Drawing.Point(6, 241);
            this.dgvPontos.Name = "dgvPontos";
            this.dgvPontos.ReadOnly = true;
            this.dgvPontos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPontos.Size = new System.Drawing.Size(214, 183);
            this.dgvPontos.TabIndex = 13;
            this.dgvPontos.SelectionChanged += new System.EventHandler(this.dgvPontos_SelectionChanged);
            // 
            // X
            // 
            this.X.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.X.DataPropertyName = "x";
            this.X.HeaderText = "X";
            this.X.Name = "X";
            this.X.ReadOnly = true;
            this.X.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Y
            // 
            this.Y.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Y.DataPropertyName = "y";
            this.Y.HeaderText = "Y";
            this.Y.Name = "Y";
            this.Y.ReadOnly = true;
            this.Y.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvPoligono
            // 
            this.dgvPoligono.AllowUserToAddRows = false;
            this.dgvPoligono.AllowUserToDeleteRows = false;
            this.dgvPoligono.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPoligono.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPoligono});
            this.dgvPoligono.Location = new System.Drawing.Point(6, 47);
            this.dgvPoligono.Name = "dgvPoligono";
            this.dgvPoligono.ReadOnly = true;
            this.dgvPoligono.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPoligono.Size = new System.Drawing.Size(214, 188);
            this.dgvPoligono.TabIndex = 12;
            this.dgvPoligono.SelectionChanged += new System.EventHandler(this.dgvPoligono_SelectionChanged);
            // 
            // colPoligono
            // 
            this.colPoligono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPoligono.DataPropertyName = "poligono";
            this.colPoligono.HeaderText = "Poligonos";
            this.colPoligono.Name = "colPoligono";
            this.colPoligono.ReadOnly = true;
            this.colPoligono.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tpTrans2D
            // 
            this.tpTrans2D.Controls.Add(this.groupBox1);
            this.tpTrans2D.Controls.Add(this.gbEspelhamento);
            this.tpTrans2D.Controls.Add(this.gbCisalhamento);
            this.tpTrans2D.Controls.Add(this.groupBox2);
            this.tpTrans2D.Controls.Add(this.gbRotacao);
            this.tpTrans2D.Controls.Add(this.gbTranslacao);
            this.tpTrans2D.Location = new System.Drawing.Point(4, 22);
            this.tpTrans2D.Name = "tpTrans2D";
            this.tpTrans2D.Padding = new System.Windows.Forms.Padding(3);
            this.tpTrans2D.Size = new System.Drawing.Size(226, 430);
            this.tpTrans2D.TabIndex = 1;
            this.tpTrans2D.Text = "Transformações 2D";
            this.tpTrans2D.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.rbPontoA);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.rbCenter);
            this.groupBox1.Controls.Add(this.tbYpontoA);
            this.groupBox1.Controls.Add(this.tbXpontoA);
            this.groupBox1.Controls.Add(this.rbOri);
            this.groupBox1.Location = new System.Drawing.Point(13, 313);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 95);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Em relação A:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(117, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Y:";
            // 
            // rbPontoA
            // 
            this.rbPontoA.AutoSize = true;
            this.rbPontoA.Location = new System.Drawing.Point(140, 19);
            this.rbPontoA.Name = "rbPontoA";
            this.rbPontoA.Size = new System.Drawing.Size(53, 17);
            this.rbPontoA.TabIndex = 2;
            this.rbPontoA.Text = "Ponto";
            this.rbPontoA.UseVisualStyleBackColor = true;
            this.rbPontoA.CheckedChanged += new System.EventHandler(this.rbPontoA_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(30, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "X:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // rbCenter
            // 
            this.rbCenter.AutoSize = true;
            this.rbCenter.Checked = true;
            this.rbCenter.Location = new System.Drawing.Point(16, 19);
            this.rbCenter.Name = "rbCenter";
            this.rbCenter.Size = new System.Drawing.Size(56, 17);
            this.rbCenter.TabIndex = 1;
            this.rbCenter.TabStop = true;
            this.rbCenter.Text = "Centro";
            this.rbCenter.UseVisualStyleBackColor = true;
            // 
            // tbYpontoA
            // 
            this.tbYpontoA.Enabled = false;
            this.tbYpontoA.Location = new System.Drawing.Point(140, 64);
            this.tbYpontoA.MaxLength = 5;
            this.tbYpontoA.Name = "tbYpontoA";
            this.tbYpontoA.Size = new System.Drawing.Size(29, 20);
            this.tbYpontoA.TabIndex = 21;
            this.tbYpontoA.TextChanged += new System.EventHandler(this.tbYpontoA_TextChanged);
            // 
            // tbXpontoA
            // 
            this.tbXpontoA.Enabled = false;
            this.tbXpontoA.Location = new System.Drawing.Point(50, 64);
            this.tbXpontoA.MaxLength = 5;
            this.tbXpontoA.Name = "tbXpontoA";
            this.tbXpontoA.Size = new System.Drawing.Size(29, 20);
            this.tbXpontoA.TabIndex = 20;
            this.tbXpontoA.TextChanged += new System.EventHandler(this.tbXpontoA_TextChanged);
            // 
            // rbOri
            // 
            this.rbOri.AutoSize = true;
            this.rbOri.Location = new System.Drawing.Point(78, 19);
            this.rbOri.Name = "rbOri";
            this.rbOri.Size = new System.Drawing.Size(58, 17);
            this.rbOri.TabIndex = 0;
            this.rbOri.Text = "Origem";
            this.rbOri.UseVisualStyleBackColor = true;
            // 
            // gbEspelhamento
            // 
            this.gbEspelhamento.Controls.Add(this.rbYesp);
            this.gbEspelhamento.Controls.Add(this.rbXesp);
            this.gbEspelhamento.Controls.Add(this.btEsp);
            this.gbEspelhamento.Location = new System.Drawing.Point(14, 236);
            this.gbEspelhamento.Name = "gbEspelhamento";
            this.gbEspelhamento.Size = new System.Drawing.Size(200, 71);
            this.gbEspelhamento.TabIndex = 27;
            this.gbEspelhamento.TabStop = false;
            this.gbEspelhamento.Text = "Espelhamento";
            // 
            // rbYesp
            // 
            this.rbYesp.AutoSize = true;
            this.rbYesp.Location = new System.Drawing.Point(6, 42);
            this.rbYesp.Name = "rbYesp";
            this.rbYesp.Size = new System.Drawing.Size(76, 17);
            this.rbYesp.TabIndex = 13;
            this.rbYesp.Text = "Vertical (Y)";
            this.rbYesp.UseVisualStyleBackColor = true;
            // 
            // rbXesp
            // 
            this.rbXesp.AutoSize = true;
            this.rbXesp.Checked = true;
            this.rbXesp.Location = new System.Drawing.Point(6, 19);
            this.rbXesp.Name = "rbXesp";
            this.rbXesp.Size = new System.Drawing.Size(88, 17);
            this.rbXesp.TabIndex = 12;
            this.rbXesp.TabStop = true;
            this.rbXesp.Text = "Horizontal (X)";
            this.rbXesp.UseVisualStyleBackColor = true;
            // 
            // btEsp
            // 
            this.btEsp.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btEsp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEsp.ForeColor = System.Drawing.Color.White;
            this.btEsp.Location = new System.Drawing.Point(124, 24);
            this.btEsp.Name = "btEsp";
            this.btEsp.Size = new System.Drawing.Size(69, 26);
            this.btEsp.TabIndex = 11;
            this.btEsp.Text = "Aplicar";
            this.btEsp.UseVisualStyleBackColor = false;
            this.btEsp.Click += new System.EventHandler(this.btEsp_Click);
            // 
            // gbCisalhamento
            // 
            this.gbCisalhamento.Controls.Add(this.label2);
            this.gbCisalhamento.Controls.Add(this.btCis);
            this.gbCisalhamento.Controls.Add(this.label7);
            this.gbCisalhamento.Controls.Add(this.tbXcis);
            this.gbCisalhamento.Controls.Add(this.tbYcis);
            this.gbCisalhamento.Location = new System.Drawing.Point(14, 186);
            this.gbCisalhamento.Name = "gbCisalhamento";
            this.gbCisalhamento.Size = new System.Drawing.Size(200, 44);
            this.gbCisalhamento.TabIndex = 24;
            this.gbCisalhamento.TabStop = false;
            this.gbCisalhamento.Text = "Cisalhamento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Y:";
            // 
            // btCis
            // 
            this.btCis.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btCis.Enabled = false;
            this.btCis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCis.ForeColor = System.Drawing.Color.White;
            this.btCis.Location = new System.Drawing.Point(123, 14);
            this.btCis.Name = "btCis";
            this.btCis.Size = new System.Drawing.Size(69, 23);
            this.btCis.TabIndex = 11;
            this.btCis.Text = "Aplicar";
            this.btCis.UseVisualStyleBackColor = false;
            this.btCis.Click += new System.EventHandler(this.btCis_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "X:";
            // 
            // tbXcis
            // 
            this.tbXcis.Location = new System.Drawing.Point(27, 17);
            this.tbXcis.MaxLength = 5;
            this.tbXcis.Name = "tbXcis";
            this.tbXcis.Size = new System.Drawing.Size(29, 20);
            this.tbXcis.TabIndex = 9;
            this.tbXcis.TextChanged += new System.EventHandler(this.tbXcis_TextChanged);
            // 
            // tbYcis
            // 
            this.tbYcis.Location = new System.Drawing.Point(85, 17);
            this.tbYcis.MaxLength = 5;
            this.tbYcis.Name = "tbYcis";
            this.tbYcis.Size = new System.Drawing.Size(29, 20);
            this.tbYcis.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btEsc);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbXesc);
            this.groupBox2.Controls.Add(this.tbYesc);
            this.groupBox2.Location = new System.Drawing.Point(14, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 50);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Escala";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Y:";
            // 
            // btEsc
            // 
            this.btEsc.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btEsc.Enabled = false;
            this.btEsc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEsc.ForeColor = System.Drawing.Color.White;
            this.btEsc.Location = new System.Drawing.Point(124, 15);
            this.btEsc.Name = "btEsc";
            this.btEsc.Size = new System.Drawing.Size(69, 23);
            this.btEsc.TabIndex = 11;
            this.btEsc.Text = "Aplicar";
            this.btEsc.UseVisualStyleBackColor = false;
            this.btEsc.Click += new System.EventHandler(this.btEsc_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "X:";
            // 
            // tbXesc
            // 
            this.tbXesc.Location = new System.Drawing.Point(27, 17);
            this.tbXesc.MaxLength = 5;
            this.tbXesc.Name = "tbXesc";
            this.tbXesc.Size = new System.Drawing.Size(29, 20);
            this.tbXesc.TabIndex = 9;
            this.tbXesc.TextChanged += new System.EventHandler(this.tbXesc_TextChanged);
            // 
            // tbYesc
            // 
            this.tbYesc.Location = new System.Drawing.Point(85, 17);
            this.tbYesc.MaxLength = 5;
            this.tbYesc.Name = "tbYesc";
            this.tbYesc.Size = new System.Drawing.Size(29, 20);
            this.tbYesc.TabIndex = 10;
            // 
            // gbRotacao
            // 
            this.gbRotacao.Controls.Add(this.label9);
            this.gbRotacao.Controls.Add(this.btRot);
            this.gbRotacao.Controls.Add(this.tbAng);
            this.gbRotacao.Location = new System.Drawing.Point(14, 136);
            this.gbRotacao.Name = "gbRotacao";
            this.gbRotacao.Size = new System.Drawing.Size(200, 44);
            this.gbRotacao.TabIndex = 26;
            this.gbRotacao.TabStop = false;
            this.gbRotacao.Text = "Rotação";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Angulo (graus):";
            // 
            // btRot
            // 
            this.btRot.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btRot.Enabled = false;
            this.btRot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRot.ForeColor = System.Drawing.Color.White;
            this.btRot.Location = new System.Drawing.Point(124, 12);
            this.btRot.Name = "btRot";
            this.btRot.Size = new System.Drawing.Size(69, 23);
            this.btRot.TabIndex = 17;
            this.btRot.Text = "Aplicar";
            this.btRot.UseVisualStyleBackColor = false;
            this.btRot.Click += new System.EventHandler(this.btRot_Click);
            // 
            // tbAng
            // 
            this.tbAng.Location = new System.Drawing.Point(84, 15);
            this.tbAng.MaxLength = 5;
            this.tbAng.Name = "tbAng";
            this.tbAng.Size = new System.Drawing.Size(29, 20);
            this.tbAng.TabIndex = 15;
            this.tbAng.TextChanged += new System.EventHandler(this.tbAng_TextChanged);
            // 
            // gbTranslacao
            // 
            this.gbTranslacao.Controls.Add(this.label4);
            this.gbTranslacao.Controls.Add(this.label3);
            this.gbTranslacao.Controls.Add(this.btTrans);
            this.gbTranslacao.Controls.Add(this.tbYtrans);
            this.gbTranslacao.Controls.Add(this.tbXtrans);
            this.gbTranslacao.Location = new System.Drawing.Point(13, 22);
            this.gbTranslacao.Name = "gbTranslacao";
            this.gbTranslacao.Size = new System.Drawing.Size(200, 52);
            this.gbTranslacao.TabIndex = 22;
            this.gbTranslacao.TabStop = false;
            this.gbTranslacao.Text = "Translação";
            this.gbTranslacao.Enter += new System.EventHandler(this.gbTranslacao_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Y:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "X:";
            // 
            // btTrans
            // 
            this.btTrans.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btTrans.Enabled = false;
            this.btTrans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTrans.ForeColor = System.Drawing.Color.White;
            this.btTrans.Location = new System.Drawing.Point(124, 19);
            this.btTrans.Name = "btTrans";
            this.btTrans.Size = new System.Drawing.Size(69, 23);
            this.btTrans.TabIndex = 5;
            this.btTrans.Text = "Aplicar";
            this.btTrans.UseVisualStyleBackColor = false;
            this.btTrans.Click += new System.EventHandler(this.btTrans_Click);
            // 
            // tbYtrans
            // 
            this.tbYtrans.Location = new System.Drawing.Point(85, 20);
            this.tbYtrans.MaxLength = 5;
            this.tbYtrans.Name = "tbYtrans";
            this.tbYtrans.Size = new System.Drawing.Size(29, 20);
            this.tbYtrans.TabIndex = 4;
            // 
            // tbXtrans
            // 
            this.tbXtrans.Location = new System.Drawing.Point(27, 20);
            this.tbXtrans.MaxLength = 5;
            this.tbXtrans.Name = "tbXtrans";
            this.tbXtrans.Size = new System.Drawing.Size(29, 20);
            this.tbXtrans.TabIndex = 3;
            this.tbXtrans.TextChanged += new System.EventHandler(this.tbXtrans_TextChanged);
            // 
            // tpViewPort
            // 
            this.tpViewPort.Controls.Add(this.labelXVP);
            this.tpViewPort.Controls.Add(this.label10);
            this.tpViewPort.Controls.Add(this.btAplicarViewPort);
            this.tpViewPort.Controls.Add(this.tbAlturaVP);
            this.tpViewPort.Controls.Add(this.tbLarguraVP);
            this.tpViewPort.Controls.Add(this.label1);
            this.tpViewPort.Controls.Add(this.cbbPoligonosVP);
            this.tpViewPort.Location = new System.Drawing.Point(4, 22);
            this.tpViewPort.Name = "tpViewPort";
            this.tpViewPort.Padding = new System.Windows.Forms.Padding(3);
            this.tpViewPort.Size = new System.Drawing.Size(226, 430);
            this.tpViewPort.TabIndex = 2;
            this.tpViewPort.Text = "ViewPort";
            this.tpViewPort.UseVisualStyleBackColor = true;
            // 
            // labelXVP
            // 
            this.labelXVP.AutoSize = true;
            this.labelXVP.Location = new System.Drawing.Point(31, 61);
            this.labelXVP.Name = "labelXVP";
            this.labelXVP.Size = new System.Drawing.Size(46, 13);
            this.labelXVP.TabIndex = 13;
            this.labelXVP.Text = "Largura:";
            this.labelXVP.Click += new System.EventHandler(this.labelXVP_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(37, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Altura:";
            // 
            // btAplicarViewPort
            // 
            this.btAplicarViewPort.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btAplicarViewPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAplicarViewPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAplicarViewPort.ForeColor = System.Drawing.Color.White;
            this.btAplicarViewPort.Location = new System.Drawing.Point(71, 123);
            this.btAplicarViewPort.Name = "btAplicarViewPort";
            this.btAplicarViewPort.Size = new System.Drawing.Size(89, 36);
            this.btAplicarViewPort.TabIndex = 11;
            this.btAplicarViewPort.Text = "Aplicar";
            this.btAplicarViewPort.UseVisualStyleBackColor = false;
            this.btAplicarViewPort.Click += new System.EventHandler(this.btAplicarViewPort_Click);
            // 
            // tbAlturaVP
            // 
            this.tbAlturaVP.Location = new System.Drawing.Point(80, 84);
            this.tbAlturaVP.Name = "tbAlturaVP";
            this.tbAlturaVP.Size = new System.Drawing.Size(53, 20);
            this.tbAlturaVP.TabIndex = 10;
            // 
            // tbLarguraVP
            // 
            this.tbLarguraVP.Location = new System.Drawing.Point(80, 58);
            this.tbLarguraVP.Name = "tbLarguraVP";
            this.tbLarguraVP.Size = new System.Drawing.Size(53, 20);
            this.tbLarguraVP.TabIndex = 9;
            this.tbLarguraVP.TextChanged += new System.EventHandler(this.tbLarguraVP_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Poligono:";
            // 
            // cbbPoligonosVP
            // 
            this.cbbPoligonosVP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPoligonosVP.FormattingEnabled = true;
            this.cbbPoligonosVP.Location = new System.Drawing.Point(80, 16);
            this.cbbPoligonosVP.Name = "cbbPoligonosVP";
            this.cbbPoligonosVP.Size = new System.Drawing.Size(121, 21);
            this.cbbPoligonosVP.TabIndex = 7;
            this.cbbPoligonosVP.SelectedIndexChanged += new System.EventHandler(this.cbbPoligonosVP_SelectedIndexChanged);
            // 
            // btCor
            // 
            this.btCor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btCor.Location = new System.Drawing.Point(232, 1);
            this.btCor.Name = "btCor";
            this.btCor.Size = new System.Drawing.Size(29, 23);
            this.btCor.TabIndex = 3;
            this.btCor.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 496);
            this.Controls.Add(this.btCor);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "PrimitivasGraficas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tpPoligonos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPontos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoligono)).EndInit();
            this.tpTrans2D.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbEspelhamento.ResumeLayout(false);
            this.gbEspelhamento.PerformLayout();
            this.gbCisalhamento.ResumeLayout(false);
            this.gbCisalhamento.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbRotacao.ResumeLayout(false);
            this.gbRotacao.PerformLayout();
            this.gbTranslacao.ResumeLayout(false);
            this.gbTranslacao.PerformLayout();
            this.tpViewPort.ResumeLayout(false);
            this.tpViewPort.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem novaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elipseToolMenuItem;
        private System.Windows.Forms.ToolStripMenuItem circunferenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equaçãoGeralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dDAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pontoMedioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equaçãoGeralToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem trigonometriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pontoMedioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem limparToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ToolStripMenuItem preencherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem floodFillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scanLineToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tpPoligonos;
        private System.Windows.Forms.TabPage tpTrans2D;
        private System.Windows.Forms.TabPage tpViewPort;
        private System.Windows.Forms.Button btNovoPoligono;
        private System.Windows.Forms.DataGridView dgvPontos;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.DataGridView dgvPoligono;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPoligono;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rbPontoA;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton rbCenter;
        private System.Windows.Forms.TextBox tbYpontoA;
        private System.Windows.Forms.TextBox tbXpontoA;
        private System.Windows.Forms.RadioButton rbOri;
        private System.Windows.Forms.GroupBox gbEspelhamento;
        private System.Windows.Forms.RadioButton rbYesp;
        private System.Windows.Forms.RadioButton rbXesp;
        private System.Windows.Forms.Button btEsp;
        private System.Windows.Forms.GroupBox gbCisalhamento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btCis;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbXcis;
        private System.Windows.Forms.TextBox tbYcis;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btEsc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbXesc;
        private System.Windows.Forms.TextBox tbYesc;
        private System.Windows.Forms.GroupBox gbRotacao;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btRot;
        private System.Windows.Forms.TextBox tbAng;
        private System.Windows.Forms.GroupBox gbTranslacao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btTrans;
        private System.Windows.Forms.TextBox tbYtrans;
        private System.Windows.Forms.TextBox tbXtrans;
        private System.Windows.Forms.Label labelXVP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btAplicarViewPort;
        private System.Windows.Forms.TextBox tbAlturaVP;
        private System.Windows.Forms.TextBox tbLarguraVP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbPoligonosVP;
        private System.Windows.Forms.ToolStripMenuItem corToolStripMenuItem;
        private System.Windows.Forms.Button btCor;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

