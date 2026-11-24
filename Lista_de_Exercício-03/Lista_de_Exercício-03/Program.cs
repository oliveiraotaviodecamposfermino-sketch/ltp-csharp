namespace Lista_de_Exercício_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao;

            do
            {
                Console.WriteLine("=== Lista 3 ====");
                Console.WriteLine("1 - Cadastro de Bandas");
                Console.WriteLine("2 - Cadastro de Eletrodomésticos");
                Console.WriteLine("3 - Cadastro de Livros");
                Console.WriteLine("4 - Cadastro de Jogos");
                Console.WriteLine("5 - Cadastro de Gados");
                Console.WriteLine("0 - Salvar e Sair");
                Console.Write("Escolha: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1: Ex01.Executar(); break;
                    case 2: Ex02.Executar(); break;
                    case 3: Ex03.Executar(); break;
                    case 4: Ex04.Executar(); break;
                    case 5: Ex05.Executar(); break;
                }

            } while (opcao != 0);
        }
    }
}
