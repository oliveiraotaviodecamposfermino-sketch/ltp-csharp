using System;
using BibliotecaMatriz;

class Ex9
{
    static void calcularForca(int[,] matriz, int R, int C)
    {
        Console.WriteLine("\n--Força Total das Regiões--");

        for(int i = 0; i < R; i++)
        {
            int soma = 0;
            for(int j = 0; j < C; j++)
            {
                soma += matriz[i,j];
            }

            Console.WriteLine($"Região {i + 1}: {soma} tropas");

        }
    }

    static void Main()
    {
        Console.WriteLine("===Reino de Quadratum===");
        Console.Write("\nDigite a quantidade de regiões: ");
        int linhas = int.Parse(Console.ReadLine());
        Console.Write("\nDigite a quantidade de cidades por região: ");
        int cols = int.Parse(Console.ReadLine());

        int[,] matriz = new int[linhas, cols];

        Matriz.gerarMatriz(matriz);

        Console.WriteLine("\n--Mapa das Tropas--");
        Matriz.mostrarMatriz(matriz);

        calcularForca(matriz, linhas, cols);
    }
}