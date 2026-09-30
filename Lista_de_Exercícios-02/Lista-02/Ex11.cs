using System;
using BibliotecaMatriz;

class Ex11
{
    static void tesouro(int[,] matriz, int n)
    {
        int diagonalPrincipal = 0;
        int diagonalSegundaria = 0;

        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < n; j++)
            {
                if(i == j)
                {
                    diagonalPrincipal += matriz[i,j];
                }
                if(i + j == n - 1)
                {
                    diagonalSegundaria += matriz[i,j];
                }
            }
        }

        Console.WriteLine($"Soma da Diagonal Principal: {diagonalPrincipal}");
        Console.WriteLine($"Soma da Diagonal Secundária: {diagonalSegundaria}");

        if(diagonalPrincipal > diagonalSegundaria)
        {
            Console.WriteLine("A Diagonal Principal possui mais tesouros!");
        }
        else if (diagonalSegundaria > diagonalPrincipal)
        {
            Console.WriteLine("A Diagonal Secundária possui mais tesouros!");
        }
        else
        {
            Console.WriteLine("Ambas as diagonais possuem a mesma quantidade de tesouro!");
        }

    }

    static void Main()
    {
        Console.WriteLine("===Desafio do Tesouro===");
        Console.Write("Essa matriz possui ordem: ");
        int n = int.Parse(Console.ReadLine());

        if(n > 0 && n <= 100)
        {
            int[,] matriz = new int[n,n];

            Matriz.gerarMatriz(matriz);

            Console.WriteLine("Quantidade de moedas em cada região: ");
            Matriz.mostrarMatriz(matriz);

            tesouro(matriz, n);
        }
        else
        {
            Console.WriteLine("Não é possível criar a matriz com essa ordem!");
        }
        
    }
}