using System;
using BibliotecaMatriz;

class Ex1
{
     public static int maiorValor(int[,] matriz)
        {
            int linhas = matriz.GetLength(0);
            int colunas = matriz.GetLength(1);
            int maiorvalor;

            maiorvalor = matriz[0, 0];

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    if (maiorvalor < matriz[i, j])
                    {
                        maiorvalor = matriz[i, j];
                    }//fim do if
                }//fim do for i
            }//fim do for j 

           return maiorvalor;

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

        int maior = maiorValor(matriz);
        Console.WriteLine($"O maior valor da matriz é: {maior}");
    }
}