//Nome: Otávio de Campos Fermino Oliveira
using System;
using BibliotecaMatriz;

class Ex2
{
	static double[] calcularPercentuaDesmatamento(int[,] matriz)
	{
		int linhas = matriz.GetLength(0);
		int cols = matriz.GetLength(1);
		double total = linhas * cols;
		
		double[] percentuais = new double[3];
		
		for (int i = 0; i < linhas; i++)
		{
			for (int j = 0; j < cols; j++)
			{
				percentuais[matriz[i, j]]++;
			}
		}
		
		for (int i = 0; i < percentuais.Length; i++)
		{
			percentuais[i] = percentuais[i] / total * 100;
		}
		
		return percentuais;
	}
	
	static void analisarAumento(int[,] matrizAnterior, int[,] matrizAtual)
	{
		double[] anterior = calcularPercentuaDesmatamento(matrizAnterior);
		double[] atual = calcularPercentuaDesmatamento(matrizAtual);
		
		Console.WriteLine("\nPercentual de ocorrências na matriz 6 meses atrás:");
		Console.WriteLine($"Área Desmatada (Código 0): {anterior[0]:F2}%");
		
		Console.WriteLine("\nPercentual de ocorrências na matriz atual:");
		Console.WriteLine($"Área Desmatada (Código 0): {atual[0]:F2}%");
		
		if (atual[0] > anterior[0])
		{
			Console.WriteLine($"\nHouve Aumento no Desmatamento – Anterior {anterior[0]:F2}% -> Atual {atual[0]:F2}%");
		}
		else if (atual[0] < anterior[0])
		{
			Console.WriteLine($"\nHouve Redução no Desmatamento – Anterior {anterior[0]:F2}% -> Atual {atual[0]:F2}%");
		}
		else
		{
			Console.WriteLine($"\nO Desmatamento se manteve – {atual[0]:F2}%");
		}
	}

	static void Main()
	{
		Console.WriteLine("Matriz de 6 meses atrás:");
		int[,] matrizAnterior = Matriz.carregarMatriz("dados_matriz_6meses_atras.csv");
		Matriz.mostrarMatriz(matrizAnterior);
		
		Console.WriteLine("\nMatriz Atual:");
		int[,] matrizAtual = Matriz.carregarMatriz("dados_matriz_atual.csv");
		Matriz.mostrarMatriz(matrizAtual);
		
		analisarAumento(matrizAnterior, matrizAtual);
	}
}