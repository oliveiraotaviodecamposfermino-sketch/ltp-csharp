using System;

class Program
{
    static void Main()
    {
        char[] dna = new char[50];

        for (int i = 0; i < dna.Length; i++)
        {
            Console.Write($"Base {i + 1}: ");
            string entrada = Console.ReadLine();
            dna[i] = entrada[0];
        }

        char[] complementar = new char[dna.Length];

        for (int i = 0; i < dna.Length; i++)
        {
            if (dna[i] == 'A')
            {
                complementar[i] = 'T';
            }
            else if (dna[i] == 'T')
            {
                complementar[i] = 'A';
            }
            else if (dna[i] == 'C')
            {
                complementar[i] = 'G';
            }
            else if (dna[i] == 'G')
            {
                complementar[i] = 'C';
            }
        }

        string fita = new string(complementar);
        Console.WriteLine($"Fita complementar: {fita}");

    }

}