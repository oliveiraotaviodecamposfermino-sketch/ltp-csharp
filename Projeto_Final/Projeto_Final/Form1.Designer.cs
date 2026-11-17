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
            btnFechar = new Button();
            btnCadastrar = new Button();
            btnBuscar = new Button();
            pnlConteudo = new Panel();
            pnlTopo.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTopo
            // 
            pnlTopo.BackColor = Color.FromArgb(38, 18, 53);
            pnlTopo.Controls.Add(btnFechar);
            pnlTopo.Controls.Add(btnCadastrar);
            pnlTopo.Controls.Add(btnBuscar);
            pnlTopo.Dock = DockStyle.Top;
            pnlTopo.Location = new Point(0, 0);
            pnlTopo.Name = "pnlTopo";
            pnlTopo.Size = new Size(1100, 110);
            pnlTopo.TabIndex = 0;
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
            btnCadastrar.FlatAppearance.MouseOverBackColor = Color.MediumSlateBlue;
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCadastrar.ForeColor = Color.FromArgb(229, 229, 229);
            btnCadastrar.Image = Properties.Resources.image_gallery;
            btnCadastrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCadastrar.Location = new Point(12, 34);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(158, 39);
            btnCadastrar.TabIndex = 0;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatAppearance.MouseOverBackColor = Color.MediumSlateBlue;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = Color.FromArgb(229, 229, 229);
            btnBuscar.Image = Properties.Resources.search1;
            btnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscar.Location = new Point(176, 34);
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
            pnlConteudo.Dock = DockStyle.Fill;
            pnlConteudo.Location = new Point(0, 110);
            pnlConteudo.Name = "pnlConteudo";
            pnlConteudo.Size = new Size(1100, 540);
            pnlConteudo.TabIndex = 1;
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
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTopo;
        private Button btnCadastrar;
        private Panel pnlConteudo;
        private Button btnBuscar;
        private Button btnFechar;
    }
}
