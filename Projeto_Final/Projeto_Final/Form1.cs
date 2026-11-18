namespace Projeto_Final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            MoverMarcador(btnBuscar);
            tabTelas.SelectedTab = tabBuscar;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            MoverMarcador(btnCadastrar);
            tabTelas.SelectedTab = tabCadastrar;
        }

        public void AbrirAbaAlterar()
        {
            // Muda para a aba de alteração
            tabTelas.SelectedTab = tabAlterar;
        }

        // Método para mover o marcador para o botão clicado
        private void MoverMarcador(Button botao)
        {
            marcador.Width = botao.Width;
            marcador.Left = botao.Left;
            marcador.Top = botao.Bottom;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MoverMarcador(btnCadastrar);// Começa com o marcador embaixo do botão Cadastrar
            tabTelas.SelectedTab = tabCadastrar;
        }

        private void tabCadastrar_Click(object sender, EventArgs e)
        {

        }

        private void cmbPlataforma_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvarAlteracao_Click(object sender, EventArgs e)
        {

        }

        private void btnAddGenero_Click(object sender, EventArgs e)
        {
            frmAdicionarGenero formGenero = new frmAdicionarGenero();
            this.Hide();
            formGenero.ShowDialog();
            this.Close();
        }
    }
}
