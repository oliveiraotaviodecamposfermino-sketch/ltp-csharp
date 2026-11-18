using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Projeto_Final
{
    public partial class usBuscar : UserControl
    {
        public usBuscar()
        {
            InitializeComponent();
            ConfigurarDataGridView();
        }

        private void ConfigurarDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.AddRange(
                new DataGridViewTextBoxColumn { Name = "colTitulo", HeaderText = "Título", FillWeight = 22 },
                new DataGridViewTextBoxColumn { Name = "colAnoLancamento", HeaderText = "Ano de lançamento", FillWeight = 14 },
                new DataGridViewTextBoxColumn { Name = "colDesenvolvedora", HeaderText = "Desenvolvedora", FillWeight = 20 },
                new DataGridViewTextBoxColumn { Name = "colDescricao", HeaderText = "Descrição", FillWeight = 30 },
                new DataGridViewTextBoxColumn { Name = "colGenero", HeaderText = "Gênero", FillWeight = 14 });

            dataGridView1.ColumnHeadersVisible = true;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersHeight = 42;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(232, 228, 240);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(38, 18, 53);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.DefaultCellStyle.BackColor = Color.White;
            dataGridView1.DefaultCellStyle.ForeColor = Color.FromArgb(40, 40, 40);
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(215, 205, 235);
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.FromArgb(38, 18, 53);
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(247, 245, 250);
            dataGridView1.GridColor = Color.FromArgb(220, 220, 225);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void usBuscar_Load(object sender, EventArgs e)
        {

        }

        private void pictureBoxImagemTopo_Click(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarNome_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
