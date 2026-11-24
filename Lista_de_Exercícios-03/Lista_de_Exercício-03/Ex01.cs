namespace Lista_de_Exercícios_03
{
    internal class Banda
    {
        public string nome;
        public string genero;
        public int integrantes;
        public int ranking;
    }

    internal class Ex01
    {
        static void salvarDados(List<Banda> listadeBandas, string nomeArquivo)
        {
            StreamWriter writer = new StreamWriter(nomeArquivo);

            foreach (Banda banda in listadeBandas)
            {
                writer.WriteLine($"{banda.nome},{banda.genero},{banda.integrantes},{banda.ranking}");
            }

            Console.WriteLine("Dados salvos com sucesso");
            writer.Dispose();
        }

        static void carregarDados(List<Banda> listadeBandas, string nomeArquivo)
        {
            if (File.Exists(nomeArquivo))
            {
                string[] linhasDoArquivo = File.ReadAllLines(nomeArquivo);
                foreach (string linha in linhasDoArquivo)
                {
                    string[] campos = linha.Split(',');
                    Banda banda = new Banda();
                    banda.nome = campos[0];
                    banda.genero = campos[1];
                    banda.integrantes = int.Parse(campos[2]);
                    banda.ranking = int.Parse(campos[3]);
                    listadeBandas.Add(banda);
                }
                Console.WriteLine("Dados carregados com sucesso!");
            }
            else
            {
                Console.WriteLine("Arquivo não encontrado");
            }
        }

        static void addBanda(List<Banda> listaBandas)
        {
            Banda novaBanda = new Banda();
            Console.WriteLine("\n--Entre com os dados da Banda--");
            Console.Write("Nome da Banda: ");
            novaBanda.nome = Console.ReadLine();
            Console.Write("Gênero da Banda: ");
            novaBanda.genero = Console.ReadLine();
            Console.Write("Integrantes da Banda: ");
            novaBanda.integrantes = int.Parse(Console.ReadLine());
            Console.Write("Ranking da Banda: ");
            novaBanda.ranking = int.Parse(Console.ReadLine());
            listaBandas.Add(novaBanda); //colocando nova banda no vetor
        }

        static int menu()
        {
            Console.WriteLine("=== SISTEMA DE CADASTRO DE BANDAS ===");
            Console.WriteLine("1 - Adicionar Banda");
            Console.WriteLine("2 - Mostrar Bandas");
            Console.WriteLine("3 - Buscar Banda (por Nome)");
            Console.WriteLine("4 - Buscar Banda (por Gênero)");
            Console.WriteLine("5 - Buscar Banda (por Ranking)");
            Console.WriteLine("6 - Atualizar Banda");
            Console.WriteLine("7 - Remover Banda");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");
            return int.Parse(Console.ReadLine());
        }

        static bool buscarBandaPorNome(List<Banda> listaBandas, string nomeBanda)
        {
            bool encontrado = false;
            for (int i = 0; i < listaBandas.Count; i++) // Percorra até a quantidade de elementos da lista
            {
                if (listaBandas[i].nome.ToUpper().Contains(nomeBanda.ToUpper()))
                {
                    Console.WriteLine("\n*** Banda ***");
                    Console.WriteLine($"Nome: {listaBandas[i].nome}");
                    Console.WriteLine($"Gênero: {listaBandas[i].genero}");
                    Console.WriteLine($"Integrantes: {listaBandas[i].integrantes}");
                    Console.WriteLine($"Ranking: {listaBandas[i].ranking}");
                    encontrado = true; // Marque que pelo menos uma banda foi localizada
                }
            }
            return encontrado;
        }

        static bool buscarBandaPorGenero(List<Banda> listaBandas, string generoBanda)
        {
            bool encontrado = false;
            for (int i = 0; i < listaBandas.Count; i++) // Percorra até a quantidade de elementos da lista
            {
                if (listaBandas[i].genero.ToUpper().Contains(generoBanda.ToUpper()))
                {
                    Console.WriteLine("\n*** Banda ***");
                    Console.WriteLine($"Nome: {listaBandas[i].nome}");
                    Console.WriteLine($"Gênero: {listaBandas[i].genero}");
                    Console.WriteLine($"Integrantes: {listaBandas[i].integrantes}");
                    Console.WriteLine($"Ranking: {listaBandas[i].ranking}");
                    encontrado = true; // Marque que pelo menos uma banda foi localizada
                }
            }
            return encontrado;
        }

        static bool buscarBandaPorRanking(List<Banda> listaBandas, string rankingBanda)
        {
            bool encontrado = false;
            for (int i = 0; i < listaBandas.Count; i++) // Percorra até a quantidade de elementos da lista
            {
                if (listaBandas[i].ranking == int.Parse(rankingBanda))
                {
                    Console.WriteLine("\n*** Banda ***");
                    Console.WriteLine($"Nome: {listaBandas[i].nome}");
                    Console.WriteLine($"Gênero: {listaBandas[i].genero}");
                    Console.WriteLine($"Integrantes: {listaBandas[i].integrantes}");
                    Console.WriteLine($"Ranking: {listaBandas[i].ranking}");
                    encontrado = true; // Marque que pelo menos uma banda foi localizada
                }
            }
            return encontrado;
        }

        static int buscarIndiceBanda(List<Banda> listaBandas, string nomeBanda)
        {
            for (int i = 0; i < listaBandas.Count; i++)
            {
                if (listaBandas[i].nome.ToUpper().Equals(nomeBanda.ToUpper())) // Compara se os nomes são iguais
                {
                    Console.WriteLine($"*** Banda ***");
                    Console.WriteLine($"Nome: {listaBandas[i].nome}");
                    Console.WriteLine($"Gênero: {listaBandas[i].genero}");
                    Console.WriteLine($"Integrantes: {listaBandas[i].integrantes}");
                    Console.WriteLine($"Ranking: {listaBandas[i].ranking}");
                    return i; // Retorne o índice onde a banda foi encontrada
                }
            }
            return -1; // Retorne o valor padrão que indica "não encontrado"
        }

        static bool atualizarBanda(List<Banda> listaBandas, string nomeBanda)
        {
            int indice = buscarIndiceBanda(listaBandas, nomeBanda); // Busque o índice da banda
            if (indice != -1)
            {
                Console.Write("Novo Nome:");
                listaBandas[indice].nome = Console.ReadLine();
                Console.Write("Novo Gênero:");
                listaBandas[indice].genero = Console.ReadLine();
                Console.Write("Novos Integrantes:");
                listaBandas[indice].integrantes = int.Parse(Console.ReadLine());
                Console.Write("Novo Ranking:");
                listaBandas[indice].ranking = int.Parse(Console.ReadLine());
                return true;
            }
            return false;
        }

        static bool removerBanda(List<Banda> listaBandas, string nomeBanda)
        {
            int indice = buscarIndiceBanda(listaBandas, nomeBanda);
            if (indice != -1)
            {
                Console.Write("Confirma a remoção da banda? (1-Sim / 2-Não): ");
                int confirmacao = int.Parse(Console.ReadLine());
                if (confirmacao == 1)
                {
                    listaBandas.RemoveAt(indice); // Remove o elemento (RemoveAt)
                    return true;
                }
            }
            return false;
        }
        static void mostrarBandas(List<Banda> listaBandas)
        {
            Console.WriteLine("\nBandas Cadastradas:");
            for (int i = 0; i < listaBandas.Count; i++)
            {
                Console.WriteLine($"\n--Dados da Banda {i + 1}--");
                Console.WriteLine($"Nome: {listaBandas[i].nome}");
                Console.WriteLine($"Gênero: {listaBandas[i].genero}");
                Console.WriteLine($"Integrantes: {listaBandas[i].integrantes}");
                Console.WriteLine($"Ranking: {listaBandas[i].ranking}");
            }
        }

        public static void Executar()
        {
            List<Banda> listaBandas = new List<Banda>();
            int opcao;
            carregarDados(listaBandas, "bandas.txt");
            do
            {
                opcao = menu();
                switch (opcao)
                {
                    case 1:
                        addBanda(listaBandas);
                        break;
                    case 2:
                        mostrarBandas(listaBandas);
                        break;
                    case 3:
                        Console.Write("Nome da banda: ");
                        string nomedeBusca = Console.ReadLine();
                        bool retorno = buscarBandaPorNome(listaBandas, nomedeBusca);
                        if (retorno == false)
                        {
                            Console.WriteLine("Banda não encontrada");
                        }
                        break;
                    case 4:
                        Console.Write("Gênero da banda: ");
                        string generoBusca = Console.ReadLine();
                        bool retorno2 = buscarBandaPorGenero(listaBandas, generoBusca);
                        if (retorno2 == false)
                        {
                            Console.WriteLine("Banda não encontrada");
                        }
                        break;
                    case 5:
                        Console.Write("Ranking da banda: ");
                        string rankingBusca = Console.ReadLine();
                        bool retorno3 = buscarBandaPorRanking(listaBandas, rankingBusca);
                        if (retorno3 == false)
                        {
                            Console.WriteLine("Banda não encontrada");
                        }
                        break;
                    case 6:
                        Console.Write("Digite o nome da banda que deseja atualizar:");
                        string nomeBandaAtualizar = Console.ReadLine();
                        bool atualizado = atualizarBanda(listaBandas, nomeBandaAtualizar);
                        if (atualizado)
                            Console.WriteLine("Banda atualizada com sucesso!");
                        else
                            Console.WriteLine("Banda não encontrada!");
                        break;
                    case 7:
                        Console.Write("Digite o nome da banda que deseja remover:");
                        string nomeBandaRemover = Console.ReadLine();
                        bool removido = removerBanda(listaBandas, nomeBandaRemover);
                        if (removido)
                            Console.WriteLine("Banda removida com sucesso!");
                        else
                            Console.WriteLine("Banda não encontrada!");
                        break;
                    case 0:
                        Console.WriteLine("Saindo...");
                        salvarDados(listaBandas, "bandas.txt");
                        break;
                }//fim switch
                Console.ReadKey();
                Console.Clear();
            } while (opcao != 0);
        }
    }
}
