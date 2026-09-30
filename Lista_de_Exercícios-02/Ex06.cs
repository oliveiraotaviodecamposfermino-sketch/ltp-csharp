using System;
using BibliotecaMatriz;

class Ex6
{
    static int[,] somarMatriz(int[,] A, int[,] B)
    {
        int linhas = A.GetLength(0);
        int cols = A.GetLength(1);
        int[,] C = new int[linhas, cols];

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                C[i, j] = A[i, j] + B[i, j];
            }
        }

        return C;

    }

    static int[,] subtrairMatriz(int[,] A, int[,] B)
    {
        int linhas = A.GetLength(0);
        int cols = A.GetLength(1);
        int[,] C = new int[linhas, cols];

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                C[i, j] = B[i, j] - A[i, j];
            }
        }

        return C;

    }

    static void adicionarConstante(int[,] matriz, int k)
    {
        int linhas = matriz.GetLength(0);
        int cols = matriz.GetLength(1);

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matriz[i, j] = matriz[i, j] + k;
            }
        }
    }

    static void Main()
    {
        Console.Write("Número de linhas da matriz: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Número de colunas da matriz: ");
        int m = int.Parse(Console.ReadLine());

        int[,] matrizA = new int[n, m];
        Console.WriteLine("Matriz A: ");
        Matriz.gerarMatriz(matrizA);
        Matriz.mostrarMatriz(matrizA);

        Console.WriteLine("");

        int[,] matrizB = new int[n, m];
        Console.WriteLine("Matriz B: ");
        Matriz.gerarMatriz(matrizB);
        Matriz.mostrarMatriz(matrizB);


        Console.WriteLine("===Escolha entre as opções===");
        Console.WriteLine("Digite 1 caso queira a Opção A - Somar as duas matrizes");
        Console.WriteLine("Digite 2 caso queira a Opção B - Subtrair a primeira matriz da segunda");
        Console.WriteLine("Digite 3 caso queira a Opção C - Adicionar uma constante as duas matrizes");
        
        Console.Write("\nDigite a operação desejada: ");
        int opcao = int.Parse(Console.ReadLine());

        if(opcao == 1)
        {
            int[,] matrizC = somarMatriz(matrizA, matrizB);
            Console.WriteLine("\nSoma das matrizes");
            Matriz.mostrarMatriz(matrizC);
        }
        else if(opcao == 2)
        {
            int[,] matrizC = subtrairMatriz(matrizA, matrizB);
            Console.WriteLine("\nSubtração da primeira matriz pela segunda");
            Matriz.mostrarMatriz(matrizC);
        }
        else if(opcao == 3)
        {
            Console.Write("Digite o valor da constante: ");
            int k = int.Parse(Console.ReadLine());

            adicionarConstante(matrizA, k);
            adicionarConstante(matrizB, k);

            Console.WriteLine("\nAdição de uma constate as duas matrizes");
            
            Console.WriteLine("Matriz A: ");
            Matriz.mostrarMatriz(matrizA);
            
            Console.WriteLine("\nMatriz B: ");
            Matriz.mostrarMatriz(matrizB);
        }
        else
        {
            Console.WriteLine("Opção não encontrada!");
        }
       

    }
}