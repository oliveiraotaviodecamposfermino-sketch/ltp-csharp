using System;

class Ex1064
{
    static void Main()
    {
        int i, cont = 0;
        double num, media, soma = 0;

        for(i = 1; i <= 6; i++){
            num = double.Parse(Console.ReadLine());
            if(num > 0)
            {
                cont++;
                soma += num;
            }
        }
        media = soma / cont;

        Console.WriteLine(cont+" valores positivos");
        Console.WriteLine($"{media:F1}");
        
    }
}