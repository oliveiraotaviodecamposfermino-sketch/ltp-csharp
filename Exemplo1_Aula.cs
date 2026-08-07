using System;
using System.Diagnostics.Contracts;

class Exemplo1_Aulas
{
    static void lerVetor(int[] vetor)
    {
        Console.WriteLine("[Funcao]Entre com os dados do vetor: ");
        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write($"Array[{i}]: ");
            vetor[i] = int.Parse(Console.ReadLine());

        }//fim for

    }

    static void gerarVetor(int[] vetor)
    {
        Random aleatorio = new Random();
        for (int i = 0; i < vetor.Length; i++)
            vetor[i] = aleatorio.Next(1, 100);

    }
    static void mostrarVetor(int[] vetor)
    {
        Console.WriteLine("[Funcao]Dados do vetor: ");
        for (int i = 0; i < vetor.Length; i++)
            Console.Write("|" + vetor[i]);

        Console.WriteLine("|");

    }
    static void Main()
    {
        int[] meuArray = new int[5];
        gerarVetor(meuArray);
        mostrarVetor(meuArray);

    }
}