using System;
using BibliotecaMatriz;

class Ex2
{
    public static int menorValor(int[,] matriz)
        {
            int linhas = matriz.GetLength(0);
            int colunas = matriz.GetLength(1);
            int menorvalor;

            menorvalor = matriz[0, 0];

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    if (menorvalor > matriz[i, j])
                    {
                        menorvalor = matriz[i, j];
                    }//fim do if
                }//fim do for i
            }//fim do for j 

           return menorvalor;

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

        int menor = menorValor(matriz);
        Console.WriteLine($"O menor valor da matriz é: {menor}");
    }
}