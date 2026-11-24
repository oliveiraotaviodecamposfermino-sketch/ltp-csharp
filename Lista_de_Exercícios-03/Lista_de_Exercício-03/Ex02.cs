namespace Lista_de_Exercícios_03
{
    internal class Eletrodomestico
    {
        public string Nome;
        public double Potencia;
        public double tempoMedioAtivo;
    }

    internal class Ex02
    {
        static void addEletrodomestico(List<Eletrodomestico> listaEletros)
        {

            Eletrodomestico novoEletro = new Eletrodomestico();
            Console.WriteLine("\n*** Dados para o novo Eletro ***");
            Console.Write("Nome: ");
            novoEletro.Nome = Console.ReadLine();
            Console.Write("Potencia (kw): ");
            novoEletro.Potencia = double.Parse(Console.ReadLine());
            Console.Write("Tempo de uso (média diária): ");
            novoEletro.tempoMedioAtivo = double.Parse(Console.ReadLine());
            listaEletros.Add(novoEletro);

        }
        static void mostrarEletrodomesticos(List<Eletrodomestico> listaEletros)
        {
            Console.WriteLine("\n---Eletros Cadastrados---");
            for (int i = 0; i < listaEletros.Count; i++)
            {
                Console.WriteLine("Eletro " + (i + 1));
                Console.WriteLine($"Nome: {listaEletros[i].Nome}");
                Console.WriteLine($"Potencia: {listaEletros[i].Potencia}");
                Console.WriteLine($"Tempo: {listaEletros[i].tempoMedioAtivo}");
            }
        }
        static bool buscarEletrodomestico(List<Eletrodomestico> listaEletros, string nomeBusca)
        {
            bool encontrado = false;
            for (int i = 0; i < listaEletros.Count; i++)
            {
                if (listaEletros[i].Nome.ToUpper().Contains(nomeBusca.ToUpper()))
                {
                    Console.WriteLine("\n---Eletrodoméstico---");
                    Console.WriteLine($"Nome: {listaEletros[i].Nome}");
                    Console.WriteLine($"Potencia: {listaEletros[i].Potencia}");
                    Console.WriteLine($"Tempo: {listaEletros[i].tempoMedioAtivo}");
                    encontrado = true;
                }
            }
            return encontrado;
        }

        static bool buscarPorConsumo(List<Eletrodomestico> listaEletros, double valorX)
        {
            bool encontrado = false;
            for (int i = 0; i < listaEletros.Count; i++)
            {
                double consumo = listaEletros[i].Potencia * listaEletros[i].tempoMedioAtivo;
                if (consumo > valorX)
                {
                    Console.WriteLine("\n---Eletrodoméstico---");
                    Console.WriteLine($"Nome: {listaEletros[i].Nome}");
                    Console.WriteLine($"Potencia: {listaEletros[i].Potencia}");
                    Console.WriteLine($"Tempo: {listaEletros[i].tempoMedioAtivo}");
                    Console.WriteLine($"Consumo: {consumo}");
                    encontrado = true;
                }
            }
            return encontrado;
        }

        static void calcularConsumoCasa(List<Eletrodomestico> listaEletros)
        {
            Console.Write("\nValor do Kw em R$: ");
            double valorKw = double.Parse(Console.ReadLine());
            double totalDia = 0, totalMes = 0;
            foreach (Eletrodomestico e in listaEletros)
            {
                totalDia += e.Potencia * e.tempoMedioAtivo;
            }
            Console.WriteLine($"Total de Kw consumidos por dia: {totalDia:f2}");
            Console.WriteLine($" Gastos por dia: {totalDia * valorKw:f2}");
            totalMes = totalDia * 30;
            Console.WriteLine($"Total de Kw consumidos por mes: {totalMes:f2}");
            Console.WriteLine($" Gastos por mes: {totalMes * valorKw:f2}");
        }



        static int menu()
        {
            Console.WriteLine("=== CONTROLE DE CONSUMO DE ENERGIA RESIDENCIAL ===");
            Console.WriteLine("1 - Cadastrar Eletrodoméstico");
            Console.WriteLine("2 - Mostrar Eletrodomésticos");
            Console.WriteLine("3 - Buscar Eletrodoméstico pelo Nome");
            Console.WriteLine("4 - Buscar Eletrodomésticos que Gastam mais que X(kWh / dia)");
            Console.WriteLine("5 - Calcular Consumo Diário e Mensal da Casa (kW e R$)");
            Console.WriteLine("6 - Salvar Dados em Arquivo");
            Console.WriteLine("7 - Carregar Dados do Arquivo");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");
            return int.Parse(Console.ReadLine());
        }
        static void salvarDados(List<Eletrodomestico> listaEletros, string nomeArquivo)
        {
            StreamWriter writer = new StreamWriter(nomeArquivo);
            foreach (Eletrodomestico eletro in listaEletros)
            {

                writer.WriteLine($"{eletro.Nome};{eletro.Potencia};{eletro.tempoMedioAtivo}");
            }
            Console.WriteLine("Dados salvos com sucesso!");
            writer.Dispose();
        }
        static void carregarDados(List<Eletrodomestico> listaEletros, string nomeArquivo)
        {
            if (File.Exists(nomeArquivo))
            {
                string[] linhasDoArquivo = File.ReadAllLines(nomeArquivo);
                foreach (string linha in linhasDoArquivo)
                {
                    string[] campos = linha.Split(';');
                    Eletrodomestico eletro = new Eletrodomestico();
                    eletro.Nome = campos[0];
                    eletro.Potencia = double.Parse(campos[1]);
                    eletro.tempoMedioAtivo = double.Parse(campos[2]);
                    listaEletros.Add(eletro);
                }
                Console.WriteLine("\nDados carregados com sucesso!");
            }
            else
            {
                Console.WriteLine("\nArquivo não encontrado :(");
            }
        }

        public static void Executar()
        {
            List<Eletrodomestico> listaEletros = new List<Eletrodomestico>();
            carregarDados(listaEletros, "dadosEletros.txt");
            int opcao;
            do
            {
                opcao = menu();
                switch (opcao)
                {
                    case 1:
                        addEletrodomestico(listaEletros);
                        break;
                    case 2:
                        mostrarEletrodomesticos(listaEletros);
                        break;
                    case 3:
                        Console.Write("\nNome do Eletro: ");
                        string nomeDeBusca = Console.ReadLine();
                        bool retorno = buscarEletrodomestico(listaEletros, nomeDeBusca);
                        if (retorno == false)
                            Console.WriteLine("Eletro não encontrado");
                        break;
                    case 4:
                        Console.Write("Digite o valor mínimo de consumo (kWh/dia): ");
                        double valorX = double.Parse(Console.ReadLine());
                        bool encontrado = buscarPorConsumo(listaEletros, valorX);
                        if (!encontrado)
                            Console.WriteLine("Nenhum eletrodoméstico encontrado com o consumo especificado.");
                        break;
                    case 5:
                        calcularConsumoCasa(listaEletros);
                        break;
                    case 6:
                        salvarDados(listaEletros, "dadosEletros.txt");
                        break;

                    case 7:
                        listaEletros.Clear();
                        carregarDados(listaEletros, "dadosEletros.txt");
                        break;
                    case 0:
                        Console.WriteLine("Saindo e salvando...");
                        salvarDados(listaEletros, "dadosEletros.txt");
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            } while (opcao != 0);
        }
    }
}
