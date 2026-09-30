using System;
using BibliotecaMatriz;

class Ex8
{
    static void verificarMapa(int N)
    {
        int[,] mapa = new int[501, 501];
        int cont = 0;

        Console.WriteLine("\n===Anotação das Coordenadas===");

        for (int i = 0; i < N; i++)
        {
            Console.Write("Digite a coordenada X da região: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Digite a coordenada Y da região: ");
            int y = int.Parse(Console.ReadLine());

            if (mapa[x, y] == 1)
            {
                cont = 1;
            }
            else
            {
                mapa[x, y] = 1;
            }

            Console.WriteLine("");

        }

        Console.WriteLine("\n--Resultado--");
        Console.WriteLine(cont);

    }

    static void Main()
    {
        Console.Write("Digite o número total de raios: ");
        int quantidadeRaio = int.Parse(Console.ReadLine());
        verificarMapa(quantidadeRaio);
    }

}