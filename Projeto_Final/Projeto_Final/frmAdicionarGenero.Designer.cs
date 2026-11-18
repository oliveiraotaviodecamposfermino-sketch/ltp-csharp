namespace Projeto_Final
{
    partial class frmAdicionarGenero
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
            pnlTopoGenero = new Panel();
            label1 = new Label();
            btnFecharGenero = new Button();
            label2 = new Label();
            txtNovoGenero = new TextBox();
            btnSalvarGenero = new Button();
            pnlTopoGenero.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTopoGenero
            // 
            pnlTopoGenero.BackColor = Color.FromArgb(38, 18, 53);
            pnlTopoGenero.Controls.Add(btnFecharGenero);
            pnlTopoGenero.Controls.Add(label1);
            pnlTopoGenero.Dock = DockStyle.Top;
            pnlTopoGenero.Location = new Point(0, 0);
            pnlTopoGenero.Name = "pnlTopoGenero";
            pnlTopoGenero.Size = new Size(420, 50);
            pnlTopoGenero.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(229, 229, 229);
            label1.Location = new Point(18, 14);
            label1.Name = "label1";
            label1.Size = new Size(173, 20);
            label1.TabIndex = 0;
            label1.Text = "Adicionar Novo Gênero";
            // 
            // btnFecharGenero
            // 
            btnFecharGenero.Cursor = Cursors.Hand;
            btnFecharGenero.FlatAppearance.BorderSize = 0;
            btnFecharGenero.FlatStyle = FlatStyle.Flat;
            btnFecharGenero.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFecharGenero.Image = Properties.Resources.close;
            btnFecharGenero.Location = new Point(375, 7);
            btnFecharGenero.Name = "btnFecharGenero";
            btnFecharGenero.Size = new Size(35, 35);
            btnFecharGenero.TabIndex = 3;
            btnFecharGenero.UseVisualStyleBackColor = true;
            btnFecharGenero.Click += btnFecharGenero_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11F);
            label2.ForeColor = Color.FromArgb(229, 229, 229);
            label2.Location = new Point(35, 75);
            label2.Name = "label2";
            label2.Size = new Size(128, 18);
            label2.TabIndex = 1;
            label2.Text = "Nome do Gênero:";
            // 
            // txtNovoGenero
            // 
            txtNovoGenero.Font = new Font("Microsoft Sans Serif", 11F);
            txtNovoGenero.Location = new Point(35, 105);
            txtNovoGenero.Name = "txtNovoGenero";
            txtNovoGenero.Size = new Size(350, 24);
            txtNovoGenero.TabIndex = 2;
            // 
            // btnSalvarGenero
            // 
            btnSalvarGenero.BackColor = Color.MediumSlateBlue;
            btnSalvarGenero.Cursor = Cursors.Hand;
            btnSalvarGenero.FlatAppearance.BorderSize = 0;
            btnSalvarGenero.FlatStyle = FlatStyle.Flat;
            btnSalvarGenero.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvarGenero.ForeColor = Color.FromArgb(229, 229, 229);
            btnSalvarGenero.Location = new Point(35, 155);
            btnSalvarGenero.Name = "btnSalvarGenero";
            btnSalvarGenero.Size = new Size(350, 42);
            btnSalvarGenero.TabIndex = 3;
            btnSalvarGenero.Text = "Adicionar Gênero";
            btnSalvarGenero.UseVisualStyleBackColor = false;
            // 
            // frmAdicionarGenero
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 46);
            ClientSize = new Size(420, 240);
            Controls.Add(btnSalvarGenero);
            Controls.Add(txtNovoGenero);
            Controls.Add(label2);
            Controls.Add(pnlTopoGenero);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAdicionarGenero";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAdicionarGenero";
            pnlTopoGenero.ResumeLayout(false);
            pnlTopoGenero.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlTopoGenero;
        private Label label1;
        private Button btnFecharGenero;
        private Label label2;
        private TextBox txtNovoGenero;
        private Button btnSalvarGenero;
    }
}