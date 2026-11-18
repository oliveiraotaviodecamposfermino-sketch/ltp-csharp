namespace Projeto_Final
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlTopo = new Panel();
            btnFechar = new Button();
            pictureBox1 = new PictureBox();
            lblUsuario = new Label();
            txtUsuario = new TextBox();
            lblSenha = new Label();
            txtSenha = new TextBox();
            btnEntrar = new Button();
            pictureBox2 = new PictureBox();
            pnlTopo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pnlTopo
            // 
            pnlTopo.BackColor = Color.FromArgb(38, 18, 53);
            pnlTopo.Controls.Add(btnFechar);
            pnlTopo.Controls.Add(pictureBox1);
            pnlTopo.Dock = DockStyle.Top;
            pnlTopo.Location = new Point(0, 0);
            pnlTopo.Name = "pnlTopo";
            pnlTopo.Size = new Size(450, 110);
            pnlTopo.TabIndex = 0;
            // 
            // btnFechar
            // 
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFechar.Image = Properties.Resources.close;
            btnFechar.ImageAlign = ContentAlignment.MiddleRight;
            btnFechar.Location = new Point(404, 3);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(43, 39);
            btnFechar.TabIndex = 3;
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.logo_removebg_preview;
            pictureBox1.Location = new Point(127, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(195, 82);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 12F);
            lblUsuario.ForeColor = Color.FromArgb(229, 229, 229);
            lblUsuario.Location = new Point(97, 253);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(67, 21);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Usuário:";
            lblUsuario.Click += lblUsuario_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 11F);
            txtUsuario.Location = new Point(170, 253);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(180, 27);
            txtUsuario.TabIndex = 2;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Segoe UI", 12F);
            lblSenha.ForeColor = Color.FromArgb(229, 229, 229);
            lblSenha.Location = new Point(97, 297);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(56, 21);
            lblSenha.TabIndex = 3;
            lblSenha.Text = "Senha:";
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Segoe UI", 11F);
            txtSenha.Location = new Point(170, 297);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(180, 27);
            txtSenha.TabIndex = 4;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // btnEntrar
            // 
            btnEntrar.Cursor = Cursors.Hand;
            btnEntrar.FlatAppearance.BorderSize = 0;
            btnEntrar.FlatAppearance.MouseDownBackColor = Color.FromArgb(55, 35, 75);
            btnEntrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(55, 35, 75);
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEntrar.Image = Properties.Resources.log_in;
            btnEntrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEntrar.Location = new Point(158, 380);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(111, 40);
            btnEntrar.TabIndex = 5;
            btnEntrar.Text = "Entrar";
            btnEntrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.users;
            pictureBox2.Location = new Point(170, 126);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(123, 89);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 46);
            ClientSize = new Size(450, 550);
            Controls.Add(pictureBox2);
            Controls.Add(btnEntrar);
            Controls.Add(txtSenha);
            Controls.Add(lblSenha);
            Controls.Add(txtUsuario);
            Controls.Add(lblUsuario);
            Controls.Add(pnlTopo);
            ForeColor = Color.FromArgb(229, 229, 229);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLogin";
            pnlTopo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlTopo;
        private PictureBox pictureBox1;
        private Button btnFechar;
        private Label lblUsuario;
        private TextBox txtUsuario;
        private Label lblSenha;
        private TextBox txtSenha;
        private Button btnEntrar;
        private PictureBox pictureBox2;
    }
}