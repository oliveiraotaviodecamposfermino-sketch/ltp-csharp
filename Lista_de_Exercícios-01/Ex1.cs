using System;
using BibliotecaVetor;

class Ex1
{
    public static int somarVetor(int[] vetor)
    {
        int soma = 0;
        for (int i = 0; i < vetor.Length; i++)
        {
            soma = soma + vetor[i];
        }

        return soma;
    }

    static void Main()
    {
        int N;

        Console.WriteLine($"Informe o tamanho do vetor: ");
        N = int.Parse(Console.ReadLine());
        int[] vetor = new int[N];
        Vetor.gerarVetor(vetor);
        Vetor.mostrarVetor(vetor);
        int soma = somarVetor(vetor);
        Console.WriteLine($"A soma dos elementos do vetor é: {soma}");

    }
}