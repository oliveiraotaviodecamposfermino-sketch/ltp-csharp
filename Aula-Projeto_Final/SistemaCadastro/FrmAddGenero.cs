using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaCadastro
{
    public partial class FrmAddGenero : Form
    {
        public FrmAddGenero()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Sistema formSistema = new Sistema();
            formSistema.ShowDialog();
            this.Close();
            
        }

        private void BtnConfirmaCadastro_Click(object sender, EventArgs e)
        {
            ConectaBanco con = new ConectaBanco();
            bool retorno = con.insereGenero(txtaddgenero.Text);
            if (retorno == false)
                MessageBox.Show(con.mensagem);
            else
            {
                MessageBox.Show("Gênero cadastrado com sucesso!");
                txtaddgenero.Clear();
                txtaddgenero.Focus();
            }
        }


    }
}
