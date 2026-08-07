using System;

class Ex1
{
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

    static int somarVetor(int[] vetor)
    {
        int soma = 0;
        for (int i = 0; i < vetor.Length; i++)
            soma += vetor[i];
        return soma;
    }
    static void Main()
    {
        int N;

        Console.WriteLine($"Informe o tamanho do vetor: ");
        N = int.Parse(Console.ReadLine());
        int[] array = new int[N];
        gerarVetor(array);
        mostrarVetor(array);
        int soma = somarVetor(array);
        Console.WriteLine($"A soma dos elementos do vetor é: {soma}");

    }

}
