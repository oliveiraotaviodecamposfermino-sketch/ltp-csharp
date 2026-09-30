using System;
using BibliotecaMatriz;

class Ex7
{
    static void somarMatriz(int[,] A, int[,] B)
    {
        int linhasA = A.GetLength(0);
        int colsA = A.GetLength(1);

        int linhasB = B.GetLength(0);
        int colsB = B.GetLength(1);

        if (linhasA == linhasB && colsA == colsB)
        {
            int[,] C = new int[linhasA, colsA];

            for (int i = 0; i < linhasA; i++)
            {
                for (int j = 0; j < colsA; j++)
                {
                    C[i, j] = A[i, j] + B[i, j];
                }
            }

            Console.WriteLine("\n--Soma das Matrizes--");
            Matriz.mostrarMatriz(C);

        }
        else
        {
            Console.WriteLine("Não foi possível somar as matrizes, pois não são de mesma ordem.");
        }
    }

    static void Main()
    {
        Console.Write("Número de linhas da matriz: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Número de colunas da matriz: ");
        int m = int.Parse(Console.ReadLine());

        Console.WriteLine("--Matriz A--");
        int [,] matrizA = new int[n, m];
        Matriz.gerarMatriz(matrizA);
        Matriz.mostrarMatriz(matrizA);

        Console.WriteLine("\n--Matriz B--");
        int [,] matrizB = new int[n,m];
        Matriz.gerarMatriz(matrizB);
        Matriz.mostrarMatriz(matrizB);

        somarMatriz(matrizA, matrizB);
        
    }
}