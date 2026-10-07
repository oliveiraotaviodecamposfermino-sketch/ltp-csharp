//Nome: Otávio de Campos Fermino Oliveira
using System;
using BibliotecaVetor;

class Ex01
{
	static double mediaRoubos(int[] roubos)
	{
		double soma = 0;
		
		for(int i = 0; i < roubos.Length; i++)
		{
			soma += roubos[i];
		}
		
		double media = soma / 10;
		
		return media;
		
	}
	
	static void exibirTop3BairrosViolentos(String[] bairros, int[] roubos)
	{
		int primeiro = -1;
		int indice1 = -1;
		
		for(int i = 0; i < roubos.Length; i++)
		{
			if(roubos[i] > primeiro)
			{
				primeiro = roubos[i];
				indice1 = i;
			}
		}
		
		int segundo = -1;
		int indice2 = -1;
		
		for(int i = 0; i < roubos.Length; i++)
		{
			if(i != indice1 && roubos[i] > segundo)
			{
				segundo = roubos[i];
				indice2 = i;
			}
		}
		
		int terceiro = -1;
		int indice3 = -1;
		
		for(int i = 0; i < roubos.Length; i++)
		{
			if(i != indice1 && i != indice2 && roubos[i] > terceiro)
			{
				terceiro = roubos[i];
				indice3 = i;
			}
		}
		
		Console.WriteLine("\n--- TOP 3 BAIRROS MAIS VIOLENTOS ---");
		Console.WriteLine($"1º Lugar: {bairros[indice1]} (Índice {indice1}) - {primeiro} roubos");
		Console.WriteLine($"2º Lugar: {bairros[indice2]} (Índice {indice2}) - {segundo} roubos");
		Console.WriteLine($"3º Lugar: {bairros[indice3]} (Índice {indice3}) - {terceiro} roubos");
	}
	
	static void Main()
	{
		int[] roubo = new int[10];
		string[] bairro = {"Centro", "Moema", "Pinheiros", "Itaquera", "Tatuapé", "Santo Amaro", "Vila Mariana", "Lapa", "Capão Redondo", "Santana"};
		Vetor.gerarVetor(roubo);
		double media = mediaRoubos(roubo);
		
		Console.Write("Dados do vetor:");
		Vetor.mostrarVetor(roubo);
		Console.WriteLine("\n\n=== ANÁLISE DE SEGURANÇA PÚBLICA - BAIRROS DE SP ===");
		Console.WriteLine($"Média de roubos por bairro: {media:F2} ocorrências");
		
		exibirTop3BairrosViolentos(bairro, roubo);	
		
	}
}
