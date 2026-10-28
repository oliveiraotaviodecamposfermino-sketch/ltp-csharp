namespace HelloWindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double peso = double.Parse(txtPeso.Text);
            double altura = double.Parse(txtAltura.Text);
            double imc = peso / (altura * altura);
            
            string interpretacao;

            if (imc < 18.5)
            {
                interpretacao = "Abaixo do peso";
            }
            else if (imc > 18.5 && imc < 25)
            {
                interpretacao = "Peso normal";
            }
            else if (imc > 25 && imc < 29.9)
            {
                interpretacao = "Sobrepeso";
            }
            else if (imc > 30 && imc < 34.9)
            {
                interpretacao = "Obesidade grau I";
            }
            else if (imc > 35 && imc < 39.9)
            {
                interpretacao = "Obesidade grau II";
            }
            else
            {
                interpretacao = "Obesidade grau III ou mais";
            }

            lblResultado.Text = $"IMC Calculado: {imc:F2} - {interpretacao}";


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
