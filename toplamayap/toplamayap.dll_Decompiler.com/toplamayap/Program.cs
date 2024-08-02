using System;
using isokutuphanesi;

namespace toplamayap;

internal class Program
{
	private static void Main(string[] args)
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		Console.Write("Birinci sayıyı girin: ");
		int num = default(int);
		if (!int.TryParse(Console.ReadLine(), ref num))
		{
			Console.WriteLine("Geçersiz bir sayı girdiniz.");
			return;
		}
		Console.Write("İkinci sayıyı girin: ");
		int num2 = default(int);
		if (!int.TryParse(Console.ReadLine(), ref num2))
		{
			Console.WriteLine("Geçersiz bir sayı girdiniz.");
			return;
		}
		int num3 = new Toplama().Topla(num, num2);
		Console.WriteLine($"Toplam: {num3}");
	}
}
