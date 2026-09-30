using System;
using BibliotecaMatriz;

class Ex4
{


    static void Main()
    {
        Console.WriteLine("Matriz de ordem: ");
        int n = int.Parse(Console.ReadLine());

        if (n > 0 && n <= 100)
        {
            int[,] matriz = new int[n, n];
            Matriz.gerarMatriz(matriz);
            Matriz.mostrarMatriz(matriz);

            Console.WriteLine("A diagonal secundária é: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i + j == n - 1)
                    {
                        Console.Write($"|{matriz[i, j],3}");
                    }
                }
            }
        }
        else
        {
            Console.WriteLine("Não é possível criar a matriz com essa ordem!");
        }

    }
}