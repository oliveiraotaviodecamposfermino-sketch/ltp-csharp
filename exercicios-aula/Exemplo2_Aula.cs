// Calcula a média final de um aluno a partir da nota regular e da nota da prova final (peso 1 e 2).
using System;

class Exemplo2_Aula
{

    static double notaFinalDisciplina(double notaReg, double notaProvaFinal)
    {
        double resultado;
        resultado = (notaProvaFinal * 2 + notaReg) / 3;
        return resultado;
    }//fim função

    static void Main()
    {
        double notaRegular, notaProvaFinal, mediaFinal;
        while (true)
        {
            Console.WriteLine("Entre com a nota regular e nota da prova final: ");
            notaRegular = double.Parse(Console.ReadLine());
            notaProvaFinal = double.Parse(Console.ReadLine());
            mediaFinal = notaFinalDisciplina(notaRegular, notaProvaFinal);
            Console.WriteLine($"A media final do aluno é: {mediaFinal:F2}");


        }
    }
}
