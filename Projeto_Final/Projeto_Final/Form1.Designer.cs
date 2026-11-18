namespace Projeto_Final
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlTopo = new Panel();
            pictureBoxImagemTopo = new PictureBox();
            marcador = new Panel();
            btnFechar = new Button();
            btnCadastrar = new Button();
            btnBuscar = new Button();
            pnlConteudo = new Panel();
            tabTelas = new TabControl();
            tabCadastrar = new TabPage();
            txtObservacao = new TextBox();
            lblObservacao = new Label();
            nudNota = new NumericUpDown();
            btnSalvarJogo = new Button();
            lblNota = new Label();
            nudAno = new NumericUpDown();
            lblAno = new Label();
            txtDesenvolvedora = new TextBox();
            lblDesenvolvedora = new Label();
            btnAddGenero = new Button();
            cmbGenero = new ComboBox();
            lblGenero = new Label();
            cmbPlataforma = new ComboBox();
            lblPlataforma = new Label();
            txtNome = new TextBox();
            lblNome = new Label();
            tabBuscar = new TabPage();
            usBuscar1 = new usBuscar();
            label2 = new Label();
            tabAlterar = new TabPage();
            btnSalvarAlteracao = new Button();
            txtAlteraObservacao = new TextBox();
            label1 = new Label();
            nudAlteraNota = new NumericUpDown();
            label3 = new Label();
            nudAlteraAno = new NumericUpDown();
            label4 = new Label();
            txtAlteraDesenvolvedora = new TextBox();
            label5 = new Label();
            cbmAlteraGenero = new ComboBox();
            label6 = new Label();
            cbmAlteraPlataforma = new ComboBox();
            label7 = new Label();
            txtAlteraNome = new TextBox();
            label8 = new Label();
            pnlTopo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagemTopo).BeginInit();
            pnlConteudo.SuspendLayout();
            tabTelas.SuspendLayout();
            tabCadastrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudNota).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAno).BeginInit();
            tabBuscar.SuspendLayout();
            tabAlterar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudAlteraNota).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAlteraAno).BeginInit();
            SuspendLayout();
            // 
            // pnlTopo
            // 
            pnlTopo.BackColor = Color.FromArgb(38, 18, 53);
            pnlTopo.Controls.Add(pictureBoxImagemTopo);
            pnlTopo.Controls.Add(marcador);
            pnlTopo.Controls.Add(btnFechar);
            pnlTopo.Controls.Add(btnCadastrar);
            pnlTopo.Controls.Add(btnBuscar);
            pnlTopo.Dock = DockStyle.Top;
            pnlTopo.Location = new Point(0, 0);
            pnlTopo.Name = "pnlTopo";
            pnlTopo.Size = new Size(1100, 110);
            pnlTopo.TabIndex = 0;
            // 
            // pictureBoxImagemTopo
            // 
            pictureBoxImagemTopo.BackColor = Color.Transparent;
            pictureBoxImagemTopo.ErrorImage = null;
            pictureBoxImagemTopo.Image = Properties.Resources.logo_removebg_preview;
            pictureBoxImagemTopo.Location = new Point(642, 12);
            pictureBoxImagemTopo.Name = "pictureBoxImagemTopo";
            pictureBoxImagemTopo.Size = new Size(314, 78);
            pictureBoxImagemTopo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxImagemTopo.TabIndex = 12;
            pictureBoxImagemTopo.TabStop = false;
            // 
            // marcador
            // 
            marcador.BackColor = Color.MediumSlateBlue;
            marcador.Location = new Point(12, 80);
            marcador.Name = "marcador";
            marcador.Size = new Size(167, 10);
            marcador.TabIndex = 3;
            // 
            // btnFechar
            // 
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFechar.Image = Properties.Resources.close;
            btnFechar.ImageAlign = ContentAlignment.MiddleRight;
            btnFechar.Location = new Point(1045, 12);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(43, 39);
            btnFechar.TabIndex = 2;
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Cursor = Cursors.Hand;
            btnCadastrar.FlatAppearance.BorderSize = 0;
            btnCadastrar.FlatAppearance.MouseDownBackColor = Color.FromArgb(55, 35, 75);
            btnCadastrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(55, 35, 75);
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCadastrar.ForeColor = Color.FromArgb(229, 229, 229);
            btnCadastrar.Image = Properties.Resources.image_gallery;
            btnCadastrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCadastrar.Location = new Point(12, 35);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(167, 39);
            btnCadastrar.TabIndex = 0;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatAppearance.MouseDownBackColor = Color.FromArgb(55, 35, 75);
            btnBuscar.FlatAppearance.MouseOverBackColor = Color.FromArgb(55, 35, 75);
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = Color.FromArgb(229, 229, 229);
            btnBuscar.Image = Properties.Resources.search1;
            btnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscar.Location = new Point(185, 35);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(138, 39);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // pnlConteudo
            // 
            pnlConteudo.BackColor = Color.FromArgb(30, 30, 46);
            pnlConteudo.Controls.Add(tabTelas);
            pnlConteudo.Dock = DockStyle.Fill;
            pnlConteudo.Location = new Point(0, 110);
            pnlConteudo.Name = "pnlConteudo";
            pnlConteudo.Size = new Size(1100, 540);
            pnlConteudo.TabIndex = 1;
            // 
            // tabTelas
            // 
            tabTelas.Appearance = TabAppearance.FlatButtons;
            tabTelas.Controls.Add(tabCadastrar);
            tabTelas.Controls.Add(tabBuscar);
            tabTelas.Controls.Add(tabAlterar);
            tabTelas.Dock = DockStyle.Fill;
            tabTelas.ItemSize = new Size(50, 20);
            tabTelas.Location = new Point(0, 0);
            tabTelas.Name = "tabTelas";
            tabTelas.SelectedIndex = 0;
            tabTelas.Size = new Size(1100, 540);
            tabTelas.SizeMode = TabSizeMode.Fixed;
            tabTelas.TabIndex = 0;
            // 
            // tabCadastrar
            // 
            tabCadastrar.BackColor = Color.FromArgb(30, 30, 46);
            tabCadastrar.Controls.Add(txtObservacao);
            tabCadastrar.Controls.Add(lblObservacao);
            tabCadastrar.Controls.Add(nudNota);
            tabCadastrar.Controls.Add(btnSalvarJogo);
            tabCadastrar.Controls.Add(lblNota);
            tabCadastrar.Controls.Add(nudAno);
            tabCadastrar.Controls.Add(lblAno);
            tabCadastrar.Controls.Add(txtDesenvolvedora);
            tabCadastrar.Controls.Add(lblDesenvolvedora);
            tabCadastrar.Controls.Add(btnAddGenero);
            tabCadastrar.Controls.Add(cmbGenero);
            tabCadastrar.Controls.Add(lblGenero);
            tabCadastrar.Controls.Add(cmbPlataforma);
            tabCadastrar.Controls.Add(lblPlataforma);
            tabCadastrar.Controls.Add(txtNome);
            tabCadastrar.Controls.Add(lblNome);
            tabCadastrar.Location = new Point(4, 24);
            tabCadastrar.Name = "tabCadastrar";
            tabCadastrar.Padding = new Padding(3);
            tabCadastrar.Size = new Size(1092, 512);
            tabCadastrar.TabIndex = 0;
            tabCadastrar.Text = "Cadastrar";
            tabCadastrar.Click += tabCadastrar_Click;
            // 
            // txtObservacao
            // 
            txtObservacao.BackColor = Color.FromArgb(42, 42, 60);
            txtObservacao.BorderStyle = BorderStyle.FixedSingle;
            txtObservacao.ForeColor = Color.FromArgb(229, 229, 229);
            txtObservacao.Location = new Point(352, 318);
            txtObservacao.Multiline = true;
            txtObservacao.Name = "txtObservacao";
            txtObservacao.ScrollBars = ScrollBars.Vertical;
            txtObservacao.Size = new Size(450, 85);
            txtObservacao.TabIndex = 13;
            // 
            // lblObservacao
            // 
            lblObservacao.AutoSize = true;
            lblObservacao.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblObservacao.ForeColor = Color.FromArgb(229, 229, 229);
            lblObservacao.Location = new Point(199, 318);
            lblObservacao.Name = "lblObservacao";
            lblObservacao.Size = new Size(95, 21);
            lblObservacao.TabIndex = 12;
            lblObservacao.Text = "Observação:";
            // 
            // nudNota
            // 
            nudNota.BackColor = Color.FromArgb(42, 42, 60);
            nudNota.BorderStyle = BorderStyle.FixedSingle;
            nudNota.DecimalPlaces = 1;
            nudNota.ForeColor = Color.FromArgb(229, 229, 229);
            nudNota.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            nudNota.Location = new Point(352, 279);
            nudNota.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudNota.Name = "nudNota";
            nudNota.Size = new Size(120, 23);
            nudNota.TabIndex = 7;
            // 
            // btnSalvarJogo
            // 
            btnSalvarJogo.BackColor = Color.FromArgb(30, 30, 46);
            btnSalvarJogo.FlatAppearance.BorderSize = 0;
            btnSalvarJogo.FlatAppearance.MouseDownBackColor = Color.FromArgb(55, 35, 75);
            btnSalvarJogo.FlatAppearance.MouseOverBackColor = Color.FromArgb(55, 35, 75);
            btnSalvarJogo.FlatStyle = FlatStyle.Flat;
            btnSalvarJogo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalvarJogo.ForeColor = Color.FromArgb(229, 229, 229);
            btnSalvarJogo.Image = Properties.Resources.download;
            btnSalvarJogo.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvarJogo.Location = new Point(450, 430);
            btnSalvarJogo.Name = "btnSalvarJogo";
            btnSalvarJogo.Size = new Size(181, 62);
            btnSalvarJogo.TabIndex = 7;
            btnSalvarJogo.Text = "Salvar Jogo";
            btnSalvarJogo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalvarJogo.UseVisualStyleBackColor = false;
            // 
            // lblNota
            // 
            lblNota.AutoSize = true;
            lblNota.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNota.ForeColor = Color.FromArgb(229, 229, 229);
            lblNota.Location = new Point(199, 279);
            lblNota.Name = "lblNota";
            lblNota.Size = new Size(47, 21);
            lblNota.TabIndex = 11;
            lblNota.Text = "Nota:";
            // 
            // nudAno
            // 
            nudAno.BackColor = Color.FromArgb(42, 42, 60);
            nudAno.BorderStyle = BorderStyle.FixedSingle;
            nudAno.ForeColor = Color.FromArgb(229, 229, 229);
            nudAno.Location = new Point(352, 242);
            nudAno.Maximum = new decimal(new int[] { 2026, 0, 0, 0 });
            nudAno.Minimum = new decimal(new int[] { 1970, 0, 0, 0 });
            nudAno.Name = "nudAno";
            nudAno.Size = new Size(120, 23);
            nudAno.TabIndex = 5;
            nudAno.Value = new decimal(new int[] { 2026, 0, 0, 0 });
            // 
            // lblAno
            // 
            lblAno.AutoSize = true;
            lblAno.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAno.ForeColor = Color.FromArgb(229, 229, 229);
            lblAno.Location = new Point(199, 242);
            lblAno.Name = "lblAno";
            lblAno.Size = new Size(147, 21);
            lblAno.TabIndex = 9;
            lblAno.Text = "Ano de lançamento:";
            // 
            // txtDesenvolvedora
            // 
            txtDesenvolvedora.BackColor = Color.FromArgb(42, 42, 60);
            txtDesenvolvedora.BorderStyle = BorderStyle.FixedSingle;
            txtDesenvolvedora.ForeColor = Color.FromArgb(229, 229, 229);
            txtDesenvolvedora.Location = new Point(352, 205);
            txtDesenvolvedora.Name = "txtDesenvolvedora";
            txtDesenvolvedora.Size = new Size(450, 23);
            txtDesenvolvedora.TabIndex = 4;
            // 
            // lblDesenvolvedora
            // 
            lblDesenvolvedora.AutoSize = true;
            lblDesenvolvedora.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDesenvolvedora.ForeColor = Color.FromArgb(229, 229, 229);
            lblDesenvolvedora.Location = new Point(199, 205);
            lblDesenvolvedora.Name = "lblDesenvolvedora";
            lblDesenvolvedora.Size = new Size(125, 21);
            lblDesenvolvedora.TabIndex = 7;
            lblDesenvolvedora.Text = "Desenvolvedora:";
            // 
            // btnAddGenero
            // 
            btnAddGenero.Cursor = Cursors.Hand;
            btnAddGenero.FlatAppearance.BorderSize = 0;
            btnAddGenero.FlatAppearance.MouseDownBackColor = Color.FromArgb(55, 35, 75);
            btnAddGenero.FlatAppearance.MouseOverBackColor = Color.FromArgb(55, 35, 75);
            btnAddGenero.FlatStyle = FlatStyle.Flat;
            btnAddGenero.Image = Properties.Resources.more__1_;
            btnAddGenero.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddGenero.Location = new Point(808, 163);
            btnAddGenero.Name = "btnAddGenero";
            btnAddGenero.Size = new Size(27, 23);
            btnAddGenero.TabIndex = 6;
            btnAddGenero.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddGenero.UseVisualStyleBackColor = true;
            btnAddGenero.Click += btnAddGenero_Click;
            // 
            // cmbGenero
            // 
            cmbGenero.BackColor = Color.FromArgb(42, 42, 60);
            cmbGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGenero.FlatStyle = FlatStyle.Flat;
            cmbGenero.ForeColor = Color.FromArgb(229, 229, 229);
            cmbGenero.FormattingEnabled = true;
            cmbGenero.Location = new Point(352, 163);
            cmbGenero.Name = "cmbGenero";
            cmbGenero.Size = new Size(450, 23);
            cmbGenero.TabIndex = 2;
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGenero.ForeColor = Color.FromArgb(229, 229, 229);
            lblGenero.Location = new Point(199, 163);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(64, 21);
            lblGenero.TabIndex = 4;
            lblGenero.Text = "Gênero:";
            // 
            // cmbPlataforma
            // 
            cmbPlataforma.BackColor = Color.FromArgb(42, 42, 60);
            cmbPlataforma.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPlataforma.FlatStyle = FlatStyle.Flat;
            cmbPlataforma.ForeColor = Color.FromArgb(229, 229, 229);
            cmbPlataforma.FormattingEnabled = true;
            cmbPlataforma.Location = new Point(352, 120);
            cmbPlataforma.Name = "cmbPlataforma";
            cmbPlataforma.Size = new Size(450, 23);
            cmbPlataforma.TabIndex = 1;
            cmbPlataforma.SelectedIndexChanged += cmbPlataforma_SelectedIndexChanged;
            // 
            // lblPlataforma
            // 
            lblPlataforma.AutoSize = true;
            lblPlataforma.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPlataforma.ForeColor = Color.FromArgb(229, 229, 229);
            lblPlataforma.Location = new Point(199, 120);
            lblPlataforma.Name = "lblPlataforma";
            lblPlataforma.Size = new Size(89, 21);
            lblPlataforma.TabIndex = 2;
            lblPlataforma.Text = "Plataforma:";
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.FromArgb(42, 42, 60);
            txtNome.BorderStyle = BorderStyle.FixedSingle;
            txtNome.ForeColor = Color.FromArgb(229, 229, 229);
            txtNome.Location = new Point(352, 80);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(450, 23);
            txtNome.TabIndex = 0;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNome.ForeColor = Color.FromArgb(229, 229, 229);
            lblNome.Location = new Point(199, 80);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(56, 21);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            // 
            // tabBuscar
            // 
            tabBuscar.BackColor = Color.FromArgb(30, 30, 46);
            tabBuscar.Controls.Add(usBuscar1);
            tabBuscar.Controls.Add(label2);
            tabBuscar.Location = new Point(4, 24);
            tabBuscar.Name = "tabBuscar";
            tabBuscar.Padding = new Padding(3);
            tabBuscar.Size = new Size(1092, 512);
            tabBuscar.TabIndex = 1;
            tabBuscar.Text = "Buscar";
            // 
            // usBuscar1
            // 
            usBuscar1.BackColor = Color.FromArgb(30, 30, 46);
            usBuscar1.Dock = DockStyle.Fill;
            usBuscar1.Location = new Point(3, 3);
            usBuscar1.Name = "usBuscar1";
            usBuscar1.Size = new Size(1086, 506);
            usBuscar1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(229, 229, 229);
            label2.Location = new Point(70, 52);
            label2.Name = "label2";
            label2.Size = new Size(0, 21);
            label2.TabIndex = 1;
            // 
            // tabAlterar
            // 
            tabAlterar.BackColor = Color.FromArgb(30, 30, 46);
            tabAlterar.Controls.Add(btnSalvarAlteracao);
            tabAlterar.Controls.Add(txtAlteraObservacao);
            tabAlterar.Controls.Add(label1);
            tabAlterar.Controls.Add(nudAlteraNota);
            tabAlterar.Controls.Add(label3);
            tabAlterar.Controls.Add(nudAlteraAno);
            tabAlterar.Controls.Add(label4);
            tabAlterar.Controls.Add(txtAlteraDesenvolvedora);
            tabAlterar.Controls.Add(label5);
            tabAlterar.Controls.Add(cbmAlteraGenero);
            tabAlterar.Controls.Add(label6);
            tabAlterar.Controls.Add(cbmAlteraPlataforma);
            tabAlterar.Controls.Add(label7);
            tabAlterar.Controls.Add(txtAlteraNome);
            tabAlterar.Controls.Add(label8);
            tabAlterar.Location = new Point(4, 24);
            tabAlterar.Name = "tabAlterar";
            tabAlterar.Padding = new Padding(3);
            tabAlterar.Size = new Size(1092, 512);
            tabAlterar.TabIndex = 2;
            tabAlterar.Text = "Alterar";
            // 
            // btnSalvarAlteracao
            // 
            btnSalvarAlteracao.BackColor = Color.FromArgb(30, 30, 46);
            btnSalvarAlteracao.FlatAppearance.BorderSize = 0;
            btnSalvarAlteracao.FlatAppearance.MouseDownBackColor = Color.FromArgb(55, 35, 75);
            btnSalvarAlteracao.FlatAppearance.MouseOverBackColor = Color.FromArgb(55, 35, 75);
            btnSalvarAlteracao.FlatStyle = FlatStyle.Flat;
            btnSalvarAlteracao.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalvarAlteracao.ForeColor = Color.FromArgb(229, 229, 229);
            btnSalvarAlteracao.Image = Properties.Resources.download;
            btnSalvarAlteracao.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvarAlteracao.Location = new Point(409, 437);
            btnSalvarAlteracao.Name = "btnSalvarAlteracao";
            btnSalvarAlteracao.Size = new Size(189, 43);
            btnSalvarAlteracao.TabIndex = 28;
            btnSalvarAlteracao.Text = "Salvar Alteração";
            btnSalvarAlteracao.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalvarAlteracao.UseVisualStyleBackColor = false;
            btnSalvarAlteracao.Click += btnSalvarAlteracao_Click;
            // 
            // txtAlteraObservacao
            // 
            txtAlteraObservacao.BackColor = Color.FromArgb(42, 42, 60);
            txtAlteraObservacao.BorderStyle = BorderStyle.FixedSingle;
            txtAlteraObservacao.ForeColor = Color.FromArgb(229, 229, 229);
            txtAlteraObservacao.Location = new Point(398, 333);
            txtAlteraObservacao.Multiline = true;
            txtAlteraObservacao.Name = "txtAlteraObservacao";
            txtAlteraObservacao.ScrollBars = ScrollBars.Vertical;
            txtAlteraObservacao.Size = new Size(450, 85);
            txtAlteraObservacao.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(229, 229, 229);
            label1.Location = new Point(245, 333);
            label1.Name = "label1";
            label1.Size = new Size(95, 21);
            label1.TabIndex = 26;
            label1.Text = "Observação:";
            // 
            // nudAlteraNota
            // 
            nudAlteraNota.BackColor = Color.FromArgb(42, 42, 60);
            nudAlteraNota.BorderStyle = BorderStyle.FixedSingle;
            nudAlteraNota.DecimalPlaces = 1;
            nudAlteraNota.ForeColor = Color.FromArgb(229, 229, 229);
            nudAlteraNota.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            nudAlteraNota.Location = new Point(398, 294);
            nudAlteraNota.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudAlteraNota.Name = "nudAlteraNota";
            nudAlteraNota.Size = new Size(120, 23);
            nudAlteraNota.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(229, 229, 229);
            label3.Location = new Point(245, 294);
            label3.Name = "label3";
            label3.Size = new Size(47, 21);
            label3.TabIndex = 25;
            label3.Text = "Nota:";
            // 
            // nudAlteraAno
            // 
            nudAlteraAno.BackColor = Color.FromArgb(42, 42, 60);
            nudAlteraAno.BorderStyle = BorderStyle.FixedSingle;
            nudAlteraAno.ForeColor = Color.FromArgb(229, 229, 229);
            nudAlteraAno.Location = new Point(398, 257);
            nudAlteraAno.Maximum = new decimal(new int[] { 2026, 0, 0, 0 });
            nudAlteraAno.Minimum = new decimal(new int[] { 1970, 0, 0, 0 });
            nudAlteraAno.Name = "nudAlteraAno";
            nudAlteraAno.Size = new Size(120, 23);
            nudAlteraAno.TabIndex = 21;
            nudAlteraAno.Value = new decimal(new int[] { 2026, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(229, 229, 229);
            label4.Location = new Point(245, 257);
            label4.Name = "label4";
            label4.Size = new Size(147, 21);
            label4.TabIndex = 24;
            label4.Text = "Ano de lançamento:";
            // 
            // txtAlteraDesenvolvedora
            // 
            txtAlteraDesenvolvedora.BackColor = Color.FromArgb(42, 42, 60);
            txtAlteraDesenvolvedora.BorderStyle = BorderStyle.FixedSingle;
            txtAlteraDesenvolvedora.ForeColor = Color.FromArgb(229, 229, 229);
            txtAlteraDesenvolvedora.Location = new Point(398, 220);
            txtAlteraDesenvolvedora.Name = "txtAlteraDesenvolvedora";
            txtAlteraDesenvolvedora.Size = new Size(450, 23);
            txtAlteraDesenvolvedora.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(229, 229, 229);
            label5.Location = new Point(245, 220);
            label5.Name = "label5";
            label5.Size = new Size(125, 21);
            label5.TabIndex = 23;
            label5.Text = "Desenvolvedora:";
            // 
            // cbmAlteraGenero
            // 
            cbmAlteraGenero.BackColor = Color.FromArgb(42, 42, 60);
            cbmAlteraGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            cbmAlteraGenero.FlatStyle = FlatStyle.Flat;
            cbmAlteraGenero.ForeColor = Color.FromArgb(229, 229, 229);
            cbmAlteraGenero.FormattingEnabled = true;
            cbmAlteraGenero.Location = new Point(398, 178);
            cbmAlteraGenero.Name = "cbmAlteraGenero";
            cbmAlteraGenero.Size = new Size(450, 23);
            cbmAlteraGenero.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(229, 229, 229);
            label6.Location = new Point(245, 178);
            label6.Name = "label6";
            label6.Size = new Size(64, 21);
            label6.TabIndex = 20;
            label6.Text = "Gênero:";
            // 
            // cbmAlteraPlataforma
            // 
            cbmAlteraPlataforma.BackColor = Color.FromArgb(42, 42, 60);
            cbmAlteraPlataforma.DropDownStyle = ComboBoxStyle.DropDownList;
            cbmAlteraPlataforma.FlatStyle = FlatStyle.Flat;
            cbmAlteraPlataforma.ForeColor = Color.FromArgb(229, 229, 229);
            cbmAlteraPlataforma.FormattingEnabled = true;
            cbmAlteraPlataforma.Location = new Point(398, 135);
            cbmAlteraPlataforma.Name = "cbmAlteraPlataforma";
            cbmAlteraPlataforma.Size = new Size(450, 23);
            cbmAlteraPlataforma.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(229, 229, 229);
            label7.Location = new Point(245, 135);
            label7.Name = "label7";
            label7.Size = new Size(89, 21);
            label7.TabIndex = 18;
            label7.Text = "Plataforma:";
            // 
            // txtAlteraNome
            // 
            txtAlteraNome.BackColor = Color.FromArgb(42, 42, 60);
            txtAlteraNome.BorderStyle = BorderStyle.FixedSingle;
            txtAlteraNome.ForeColor = Color.FromArgb(229, 229, 229);
            txtAlteraNome.Location = new Point(398, 95);
            txtAlteraNome.Name = "txtAlteraNome";
            txtAlteraNome.Size = new Size(450, 23);
            txtAlteraNome.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(229, 229, 229);
            label8.Location = new Point(245, 95);
            label8.Name = "label8";
            label8.Size = new Size(56, 21);
            label8.TabIndex = 15;
            label8.Text = "Nome:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 18);
            ClientSize = new Size(1100, 650);
            Controls.Add(pnlConteudo);
            Controls.Add(pnlTopo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            pnlTopo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagemTopo).EndInit();
            pnlConteudo.ResumeLayout(false);
            tabTelas.ResumeLayout(false);
            tabCadastrar.ResumeLayout(false);
            tabCadastrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudNota).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAno).EndInit();
            tabBuscar.ResumeLayout(false);
            tabBuscar.PerformLayout();
            tabAlterar.ResumeLayout(false);
            tabAlterar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudAlteraNota).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAlteraAno).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTopo;
        private Button btnCadastrar;
        private Panel pnlConteudo;
        private Button btnBuscar;
        private Button btnFechar;
        private TabControl tabTelas;
        private TabPage tabCadastrar;
        private TabPage tabBuscar;
        private TabPage tabAlterar;
        private Label lblNome;
        private Label label2;
        private Panel marcador;
        private TextBox txtNome;
        private ComboBox cmbPlataforma;
        private Label lblPlataforma;
        private Button btnAddGenero;
        private ComboBox cmbGenero;
        private Label lblGenero;
        private TextBox txtDesenvolvedora;
        private Label lblDesenvolvedora;
        private NumericUpDown numericUpDown2;
        private Label lblNota;
        private NumericUpDown nudAno;
        private Label lblAno;
        private Button btnSalvarJogo;
        private NumericUpDown nudNota;
        private PictureBox pictureBoxImagemTopo;
        private usBuscar usBuscar1;
        private TextBox txtObservacao;
        private Label lblObservacao;
        private TextBox txtAlteraObservacao;
        private Label label1;
        private NumericUpDown nudAlteraNota;
        private Label label3;
        private NumericUpDown nudAlteraAno;
        private Label label4;
        private TextBox txtAlteraDesenvolvedora;
        private Label label5;
        private ComboBox cbmAlteraGenero;
        private Label label6;
        private ComboBox cbmAlteraPlataforma;
        private Label label7;
        private TextBox txtAlteraNome;
        private Label label8;
        private Button btnSalvarAlteracao;
    }
}
