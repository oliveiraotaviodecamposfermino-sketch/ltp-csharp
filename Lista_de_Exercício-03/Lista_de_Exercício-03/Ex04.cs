namespace Lista_de_Exercício_03
{
    internal class Emprestimo
    {
        public string data = "";
        public string nomePessoa = "";
        public char emprestado = 'N';
    }

    internal class Jogo
    {
        public string titulo = "";
        public string console = "";
        public int ano;
        public int ranking;
        public Emprestimo emprestimo = new Emprestimo();
    }

    internal class Ex04
    {
        static string lerTextoLimitado(string rotulo, int limite)
        {
            Console.Write($"{rotulo} (até {limite} letras): ");
            string texto = Console.ReadLine();
            if (texto.Length > limite)
            {
                texto = texto.Substring(0, limite);
            }
            return texto;
        }

        static void exibirJogo(Jogo j)
        {
            Console.WriteLine($"Título: {j.titulo}");
            Console.WriteLine($"Console: {j.console}");
            Console.WriteLine($"Ano: {j.ano}");
            Console.WriteLine($"Ranking: {j.ranking}");
            Console.WriteLine($"Emprestado: {j.emprestimo.emprestado}");
            if (char.ToUpper(j.emprestimo.emprestado) == 'S')
            {
                Console.WriteLine($"Emprestado para: {j.emprestimo.nomePessoa}");
                Console.WriteLine($"Data do empréstimo: {j.emprestimo.data}");
            }
            Console.WriteLine("-----------------------------");
        }

        static void cadastrarJogos(List<Jogo> listaJogos)
        {
            Console.WriteLine("\nQuantos jogos deseja cadastrar ? ");
            int n = int.Parse(Console.ReadLine() ?? "0");

            for (int i = 0; i < n; i++)
            {
                Jogo novoJogo = new Jogo();
                Console.WriteLine($"\n---Dados do Jogo {i + 1}---");
                novoJogo.titulo = lerTextoLimitado("Título", 30);
                novoJogo.console = lerTextoLimitado("Console", 15);
                Console.Write("Ano: ");
                novoJogo.ano = int.Parse(Console.ReadLine());
                Console.Write("Ranking: ");
                novoJogo.ranking = int.Parse(Console.ReadLine());

                novoJogo.emprestimo.emprestado = 'N';
                novoJogo.emprestimo.data = "";
                novoJogo.emprestimo.nomePessoa = "";

                listaJogos.Add(novoJogo);
            }
        }

        static bool buscarPorTitulo(List<Jogo> listaJogos, string tituloBusca)
        {
            bool encontrado = false;
            foreach (Jogo j in listaJogos)
            {
                if (j.titulo.ToUpper().Contains(tituloBusca.ToUpper()))
                {
                    exibirJogo(j);
                    encontrado = true;
                }
            }
            return encontrado;
        }

        static bool listarPorConsole(List<Jogo> listaJogos, string consoleBusca)
        {
            bool encontrado = false;
            foreach (Jogo j in listaJogos)
            {
                if (j.console.ToUpper().Contains(consoleBusca.ToUpper()))
                {
                    exibirJogo(j);
                    encontrado = true;
                }
            }
            return encontrado;
        }

        static int buscarIndiceExatoTitulo(List<Jogo> listaJogos, string tituloBusca)
        {
            for (int i = 0; i < listaJogos.Count; i++)
            {
                if (listaJogos[i].titulo.ToUpper().Equals(tituloBusca.ToUpper()))
                {
                    return i;
                }
            }
            return -1;
        }

        static void emprestarJogo(List<Jogo> listaJogos, string tituloBusca)
        {
            int indice = buscarIndiceExatoTitulo(listaJogos, tituloBusca);
            if (indice == -1)
            {
                Console.WriteLine("Jogo não encontrado.");
                return;
            }

            Jogo jogo = listaJogos[indice];
            if (char.ToUpper(jogo.emprestimo.emprestado) == 'S')
            {
                Console.WriteLine($"Este jogo já está emprestado para {jogo.emprestimo.nomePessoa} desde {jogo.emprestimo.data}.");
                return;
            }

            Console.Write("Nome da pessoa que está pegando o jogo: ");
            string pessoa = Console.ReadLine() ?? "";

            jogo.emprestimo.emprestado = 'S';
            jogo.emprestimo.nomePessoa = pessoa;
            jogo.emprestimo.data = DateTime.Now.ToString("dd/MM/yyyy");

            Console.WriteLine($"Empréstimo registrado com sucesso em {jogo.emprestimo.data} para {jogo.emprestimo.nomePessoa}!");
        }

        static void devolverJogo(List<Jogo> listaJogos, string tituloBusca)
        {
            int indice = buscarIndiceExatoTitulo(listaJogos, tituloBusca);
            if (indice == -1)
            {
                Console.WriteLine("Jogo não encontrado.");
                return;
            }

            Jogo jogo = listaJogos[indice];
            if (char.ToUpper(jogo.emprestimo.emprestado) != 'S')
            {
                Console.WriteLine("Este jogo já consta como disponível (N).");
                return;
            }

            jogo.emprestimo.emprestado = 'N';
            jogo.emprestimo.nomePessoa = "";
            jogo.emprestimo.data = "";

            Console.WriteLine("Jogo devolvido com sucesso! Status alterado para 'N'.");
        }

        static void mostrarJogosEmprestados(List<Jogo> listaJogos)
        {
            bool algumEmprestado = false;
            Console.WriteLine("\n---Jogos Atualmente Emprestados---");

            foreach (Jogo j in listaJogos)
            {
                if (char.ToUpper(j.emprestimo.emprestado) == 'S')
                {
                    Console.WriteLine($"- {j.titulo} ({j.console}) -> Emprestado para: {j.emprestimo.nomePessoa} | Data: {j.emprestimo.data}");
                    algumEmprestado = true;
                }
            }

            if (!algumEmprestado)
            {
                Console.WriteLine("Nenhum jogo está emprestado no momento.");
            }
        }

        static void salvarDados(List<Jogo> listaJogos, string nomeArquivo)
        {
            using StreamWriter writer = new StreamWriter(nomeArquivo);
            foreach (Jogo j in listaJogos)
            {
                writer.WriteLine($"{j.titulo};{j.console};{j.ano};{j.ranking};{j.emprestimo.emprestado};{j.emprestimo.nomePessoa};{j.emprestimo.data}");
            }
            Console.WriteLine("Dados salvos com sucesso!");
        }

        static void carregarDados(List<Jogo> listaJogos, string nomeArquivo)
        {
            if (File.Exists(nomeArquivo))
            {
                string[] linhas = File.ReadAllLines(nomeArquivo);
                foreach (string linha in linhas)
                {
                    if (string.IsNullOrWhiteSpace(linha)) continue;

                    string[] campos = linha.Split(';');
                    Jogo j = new Jogo();
                    j.titulo = campos[0];
                    j.console = campos[1];
                    j.ano = int.Parse(campos[2]);
                    j.ranking = int.Parse(campos[3]);
                    j.emprestimo.emprestado = string.IsNullOrEmpty(campos[4]) ? 'N' : campos[4][0];
                    j.emprestimo.nomePessoa = campos.Length > 5 ? campos[5] : "";
                    j.emprestimo.data = campos.Length > 6 ? campos[6] : "";
                    listaJogos.Add(j);
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
            Console.WriteLine("=== CATÁLOGO E CONTROLE DE JOGOS ===");
            Console.WriteLine("1 - Cadastrar n Jogos");
            Console.WriteLine("2 - Procurar Jogo por Título");
            Console.WriteLine("3 - Listar Jogos de um Console");
            Console.WriteLine("4 - Emprestar Jogo");
            Console.WriteLine("5 - Devolver Jogo");
            Console.WriteLine("6 - Mostrar Jogos Emprestados");
            Console.WriteLine("7 - Salvar Dados em Arquivo");
            Console.WriteLine("8 - Carregar Dados do Arquivo");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");
            return int.Parse(Console.ReadLine());
        }

        public static void Executar()
        {
            List<Jogo> listaJogos = new List<Jogo>();
            carregarDados(listaJogos, "jogos.txt");

            int opcao;
            do
            {
                opcao = menu();
                switch (opcao)
                {
                    case 1:
                        cadastrarJogos(listaJogos);
                        break;
                    case 2:
                        Console.Write("\nDigite o título do jogo: ");
                        string tituloBusca = Console.ReadLine();
                        if (!buscarPorTitulo(listaJogos, tituloBusca))
                            Console.WriteLine("Jogo não encontrado.");
                        break;
                    case 3:
                        Console.Write("\nDigite o console: ");
                        string consoleBusca = Console.ReadLine();
                        if (!listarPorConsole(listaJogos, consoleBusca))
                            Console.WriteLine("Nenhum jogo encontrado para esse console.");
                        break;
                    case 4:
                        Console.Write("\nDigite o título exato do jogo para emprestar: ");
                        string tituloEmprestar = Console.ReadLine();
                        emprestarJogo(listaJogos, tituloEmprestar);
                        break;
                    case 5:
                        Console.Write("\nDigite o título exato do jogo para devolver: ");
                        string tituloDevolver = Console.ReadLine();
                        devolverJogo(listaJogos, tituloDevolver);
                        break;
                    case 6:
                        mostrarJogosEmprestados(listaJogos);
                        break;
                    case 7:
                        salvarDados(listaJogos, "jogos.txt");
                        break;
                    case 8:
                        listaJogos.Clear();
                        carregarDados(listaJogos, "jogos.txt");
                        break;
                    case 0:
                        Console.WriteLine("Saindo e salvando...");
                        salvarDados(listaJogos, "jogos.txt");
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
