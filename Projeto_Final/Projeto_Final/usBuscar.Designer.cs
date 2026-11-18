namespace Projeto_Final
{
    partial class usBuscar
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usBuscar));
            pnlTopo = new Panel();
            lblTitulo = new Label();
            btnBuscar = new Button();
            dataGridView1 = new DataGridView();
            btnBuscarNome = new Button();
            btnAlterar = new Button();
            pnlTopo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pnlTopo
            // 
            pnlTopo.BackColor = Color.FromArgb(38, 18, 53);
            pnlTopo.Controls.Add(lblTitulo);
            pnlTopo.Controls.Add(btnBuscar);
            pnlTopo.Dock = DockStyle.Top;
            pnlTopo.Location = new Point(0, 0);
            pnlTopo.Name = "pnlTopo";
            pnlTopo.Size = new Size(1100, 80);
            pnlTopo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.Dock = DockStyle.Left;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(229, 229, 229);
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Padding = new Padding(24, 0, 0, 0);
            lblTitulo.Size = new Size(300, 80);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Buscar";
            lblTitulo.TextAlign = ContentAlignment.MiddleLeft;
            lblTitulo.Click += lblTitulo_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBuscar.BackColor = Color.MediumSlateBlue;
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatAppearance.MouseOverBackColor = Color.FromArgb(110, 95, 190);
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = Color.FromArgb(229, 229, 229);
            btnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscar.Location = new Point(950, 20);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(130, 40);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(247, 245, 250);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(232, 228, 240);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(38, 18, 53);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeight = 42;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(40, 40, 40);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(215, 205, 235);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(38, 18, 53);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.FromArgb(220, 220, 225);
            dataGridView1.Location = new Point(55, 194);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 36;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(990, 402);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnBuscarNome
            // 
            btnBuscarNome.BackColor = Color.FromArgb(38, 18, 53);
            btnBuscarNome.Cursor = Cursors.Hand;
            btnBuscarNome.FlatAppearance.BorderSize = 0;
            btnBuscarNome.FlatAppearance.MouseDownBackColor = Color.FromArgb(55, 35, 75);
            btnBuscarNome.FlatAppearance.MouseOverBackColor = Color.FromArgb(55, 35, 75);
            btnBuscarNome.FlatStyle = FlatStyle.Flat;
            btnBuscarNome.Image = (Image)resources.GetObject("btnBuscarNome.Image");
            btnBuscarNome.Location = new Point(55, 114);
            btnBuscarNome.Name = "btnBuscarNome";
            btnBuscarNome.Size = new Size(64, 64);
            btnBuscarNome.TabIndex = 2;
            btnBuscarNome.UseVisualStyleBackColor = false;
            btnBuscarNome.Click += btnBuscarNome_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.BackColor = Color.FromArgb(38, 18, 53);
            btnAlterar.Cursor = Cursors.Hand;
            btnAlterar.FlatAppearance.BorderSize = 0;
            btnAlterar.FlatAppearance.MouseDownBackColor = Color.FromArgb(55, 35, 75);
            btnAlterar.FlatAppearance.MouseOverBackColor = Color.FromArgb(55, 35, 75);
            btnAlterar.FlatStyle = FlatStyle.Flat;
            btnAlterar.Image = Properties.Resources.alterar_branco_40;
            btnAlterar.Location = new Point(134, 114);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(64, 64);
            btnAlterar.TabIndex = 3;
            btnAlterar.UseVisualStyleBackColor = false;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // usBuscar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 46);
            Controls.Add(btnAlterar);
            Controls.Add(btnBuscarNome);
            Controls.Add(dataGridView1);
            Controls.Add(pnlTopo);
            Name = "usBuscar";
            Size = new Size(1100, 650);
            Load += usBuscar_Load;
            pnlTopo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTopo;
        private Label lblTitulo;
        private Button btnBuscar;
        private DataGridView dataGridView1;
        private Button btnBuscarNome;
        private Button btnAlterar;
    }
}
