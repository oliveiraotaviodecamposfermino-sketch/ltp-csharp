using System;
using BibliotecaMatriz;

class Ex10
{
    static void areaMar(int N)
    {
        int[,] matriz = new int[101, 101];

        for (int i = 0; i < N; i++)
        {
            Console.WriteLine("--Redes Lançadas ao Mar--");
            Console.Write("\nDigite o valor de Xi: ");
            int xi = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor de Xf: ");
            int xf = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor de Yi: ");
            int yi = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor de Yf: ");
            int yf = int.Parse(Console.ReadLine());

            for (int x = xi; x <= xf; x++)
            {
                for (int y = yi; y <= yf; y++)
                {
                    matriz[x, y] = 1;
                }
            }
        }

        int areaTotal = 0;

        for (int i = 0; i < 100; i++)
        {
            for (int j = 0; j < 100; j++)
            {
                if (matriz[i, j] == 1)
                {
                    areaTotal++;
                }
            }
        }

        Console.WriteLine("\n--Área Total Coberta--");
        Console.WriteLine(areaTotal);

    }

    static void Main()
    {
        Console.Write("Digite a quantidade de redes lançadas no mar: ");
        int n = int.Parse(Console.ReadLine());

        areaMar(n);

    }
}