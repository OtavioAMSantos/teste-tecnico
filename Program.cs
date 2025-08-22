using System;

class Program
{
	static void Main()
	{
		Console.WriteLine("Digite a primeira palavra:");
		string palavra1 = Console.ReadLine();

		Console.WriteLine("Digite a segunda palavra:");
		string palavra2 = Console.ReadLine();

		if (SaoAnagramas(palavra1, palavra2))
		{
			Console.WriteLine("Resultado: As palavras são anagramas!");
		}
		else
		{
			Console.WriteLine("Resultado: As palavras NÃO são anagramas!");
		}
	}

	static bool SaoAnagramas(string a, string b)
	{
		a = a.Replace(" ", "").ToLower();
		b = b.Replace(" ", "").ToLower();

		char[] arrA = a.ToCharArray();
		char[] arrB = b.ToCharArray();
		Array.Sort(arrA);
		Array.Sort(arrB);

		return new string(arrA) == new string(arrB);
	}
}
