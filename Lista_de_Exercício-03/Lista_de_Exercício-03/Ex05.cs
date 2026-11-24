namespace Lista_de_Exercício_03
{
    internal class Nasc
    {
        public int mes;
        public int ano;
    }
    internal class CabecaGado
    {
        public string codigo = "";
        public double leite;
        public double alim;
        public Nasc nasc = new Nasc();
        public char abate = 'N'; // 'S' ou 'N'
    }
    internal class Ex05
    {
        static int calcularIdadeEmAnos(Nasc nasc)
        {
            DateTime hoje = DateTime.Now;
            int idade = hoje.Year - nasc.ano;
            if (hoje.Month < nasc.mes)
            {
                idade--;
            }
            return idade;
        }

        static void definirAbate(CabecaGado gado)
        {
            int idade = calcularIdadeEmAnos(gado.nasc);
            if (idade > 5 || gado.leite < 40)
            {
                gado.abate = 'S';
            }
            else
            {
                gado.abate = 'N';
            }
        }

        static void lerBaseDados(List<CabecaGado> listaGado)
        {
            Console.WriteLine("\nQuantas cabeças de gado deseja cadastrar (N)? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                CabecaGado gado = new CabecaGado();
                Console.WriteLine($"\n---Dados da Cabeça de Gado {i + 1}---");

                Console.Write("Código: ");
                gado.codigo = Console.ReadLine();

                Console.Write("Leite produzido por semana (litros): ");
                gado.leite = double.Parse(Console.ReadLine());

                Console.Write("Alimento ingerido por semana (kg): ");
                gado.alim = double.Parse(Console.ReadLine());

                Console.Write("Mês de nascimento (1 a 12): ");
                gado.nasc.mes = int.Parse(Console.ReadLine());

                Console.Write("Ano de nascimento: ");
                gado.nasc.ano = int.Parse(Console.ReadLine());

                definirAbate(gado);
                listaGado.Add(gado);
            }

            Console.WriteLine("\nBase de dados carregada na memória e status de abate calculado!");
        }

        static double totalLeiteSemana(List<CabecaGado> listaGado)
        {
            double total = 0;
            foreach (CabecaGado g in listaGado)
            {
                total += g.leite;
            }
            return total;
        }

        static double totalAlimentoSemana(List<CabecaGado> listaGado)
        {
            double total = 0;
            foreach (CabecaGado g in listaGado)
            {
                total += g.alim;
            }
            return total;
        }

        static void listarParaAbate(List<CabecaGado> listaGado)
        {
            bool encontrou = false;
            Console.WriteLine("\n---Animais Encaminhados para o Abate ('S')---");

            foreach (CabecaGado g in listaGado)
            {
                definirAbate(g);
                if (char.ToUpper(g.abate) == 'S')
                {
                    int idade = calcularIdadeEmAnos(g.nasc);
                    Console.WriteLine($"Código: {g.codigo} | Nascimento: {g.nasc.mes:D2}/{g.nasc.ano} ({idade} anos) | Leite: {g.leite:f2} L/sem | Alimento: {g.alim:f2} kg/sem | Abate: {g.abate}");
                    encontrou = true;
                }
            }

            if (!encontrou)
            {
                Console.WriteLine("\nNenhuma cabeça de gado marcada para o abate no momento.");
            }
        }

        static void salvarDados(List<CabecaGado> listaGado, string nomeArquivo)
        {
            using StreamWriter writer = new StreamWriter(nomeArquivo);
            foreach (CabecaGado g in listaGado)
            {
                writer.WriteLine($"{g.codigo};{g.leite};{g.alim};{g.nasc.mes};{g.nasc.ano};{g.abate}");
            }
            Console.WriteLine("Dados salvos com sucesso!");
        }

        static void carregarDados(List<CabecaGado> listaGado, string nomeArquivo)
        {
            if (File.Exists(nomeArquivo))
            {
                string[] linhas = File.ReadAllLines(nomeArquivo);
                foreach (string linha in linhas)
                {
                    if (string.IsNullOrWhiteSpace(linha)) continue;

                    string[] campos = linha.Split(';');
                    CabecaGado g = new CabecaGado();
                    g.codigo = campos[0];
                    g.leite = double.Parse(campos[1]);
                    g.alim = double.Parse(campos[2]);
                    g.nasc.mes = int.Parse(campos[3]);
                    g.nasc.ano = int.Parse(campos[4]);
                    g.abate = string.IsNullOrEmpty(campos[5]) ? 'N' : campos[5][0];
                    definirAbate(g);
                    listaGado.Add(g);
                }
                Console.WriteLine("\nDados carregados com sucesso!");
            }
            else
            {
                Console.WriteLine("\nArquivo não encontrado :(");
            }
        }

        static int menu()
        {
            Console.WriteLine("=== CONTROLE DE FAZENDA DE GADO ===");
            Console.WriteLine("1 - Cadastrar base de dados");
            Console.WriteLine("2 - Total de leite produzido na semana");
            Console.WriteLine("3 - Total de alimento consumido na semana");
            Console.WriteLine("4 - Listar animais para o Abate");
            Console.WriteLine("5 - Salvar dados em arquivo");
            Console.WriteLine("6 - Carregar dados do arquivo");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");
            return int.Parse(Console.ReadLine());
        }
        public static void Executar()
        {
            List<CabecaGado> listaGado = new List<CabecaGado>();
            carregarDados(listaGado, "gado.txt");

            int opcao;
            do
            {
                opcao = menu();
                switch (opcao)
                {
                    case 1:
                        lerBaseDados(listaGado);
                        break;
                    case 2:
                        Console.WriteLine($"\nTotal de leite produzido na semana: {totalLeiteSemana(listaGado):f2} litros");
                        break;
                    case 3:
                        Console.WriteLine($"\nTotal de alimento consumido na semana: {totalAlimentoSemana(listaGado):f2} kg");
                        break;
                    case 4:
                        listarParaAbate(listaGado);
                        break;
                    case 5:
                        salvarDados(listaGado, "gado.txt");
                        break;
                    case 6:
                        listaGado.Clear();
                        carregarDados(listaGado, "gado.txt");
                        break;
                    case 0:
                        Console.WriteLine("Saindo e salvando...");
                        salvarDados(listaGado, "gado.txt");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

                Console.ReadKey();
                Console.Clear();
            } while (opcao != 0);
        }
    }
}
