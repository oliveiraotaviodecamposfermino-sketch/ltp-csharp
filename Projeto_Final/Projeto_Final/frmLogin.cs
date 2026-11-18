using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Projeto_Final
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;  
            string senha = txtSenha.Text;

            if(usuario == "adm" && senha == "123")
            {
                Form1 formPrincipal = new Form1();
                this.Hide();
                formPrincipal.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos!", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSenha.Clear();
                txtSenha.Focus();
            }
        }
     }
 }

