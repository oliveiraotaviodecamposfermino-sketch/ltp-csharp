using System;
using BibliotecaMatriz;

class Ex5
{
    static int contarOcorrencias(int[,] matriz, int x)
    {
        int linhas = matriz.GetLength(0);
        int cols = matriz.GetLength(1);
        int cont = 0;

        for(int i = 0; i < linhas; i++)
        {
            for(int j = 0; j < cols; j++)
            {
                if(matriz[i, j] == x)
                {
                    cont++;
                }
            }
        }

        return cont;

    }

    static void Main()
    {
        Console.WriteLine("Número de linhas da matriz: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Número de colunas da matriz: ");
        int m = int.Parse(Console.ReadLine());
        int[,] matriz = new int[n, m];
        Matriz.gerarMatriz(matriz);
        Matriz.mostrarMatriz(matriz);

        Console.WriteLine("Digite o valor de X: ");
        int X = int.Parse(Console.ReadLine());

        int quantidadeOcorrencias = contarOcorrencias(matriz, X);
        Console.WriteLine($"O número {X} aparece {quantidadeOcorrencias} vezes");
    }
}