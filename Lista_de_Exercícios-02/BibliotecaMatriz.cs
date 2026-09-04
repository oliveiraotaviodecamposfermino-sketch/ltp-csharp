using System;
using System.IO;

namespace BibliotecaMatriz
{
    public class Matriz
    {
        public static void lerMatriz(int[,] matriz)
        {
            int linhas = matriz.GetLength(0);
            int colunas = matriz.GetLength(1);
            //Ler matriz
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    Console.Write($"[{i},{j}]:");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }//fim do for j
            }//fim do for i

        }//fim da função

        public static void mostrarMatriz(int[,] matriz)
        {
            int linhas = matriz.GetLength(0);
            int colunas = matriz.GetLength(1);
            //Mostrar matriz
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    Console.Write($"|{matriz[i, j],3}");
                }//fim j
                Console.WriteLine();//Quebra a linha
            }//fim i

        }//fim função

        public static void gerarMatriz(int[,] matriz)
        {
            Random random = new Random();
            int linhas = matriz.GetLength(0);
            int colunas = matriz.GetLength(1);
            for (int i = 0; i < linhas; i++)
                for (int j = 0; j < colunas; j++)
                    matriz[i, j] = random.Next(0, 100);
        }

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

    }
}
