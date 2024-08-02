using System;
using isokutuphanesi;

namespace toplamayap
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan ilk sayıyı al
            Console.Write("Birinci sayıyı girin: ");
            if (!int.TryParse(Console.ReadLine(), out int a))
            {
                Console.WriteLine("Geçersiz bir sayı girdiniz.");
                return;
            }

            // Kullanıcıdan ikinci sayıyı al
            Console.Write("İkinci sayıyı girin: ");
            if (!int.TryParse(Console.ReadLine(), out int b))
            {
                Console.WriteLine("Geçersiz bir sayı girdiniz.");
                return;
            }

            // Toplama işlemini yap
            Toplama toplama = new Toplama();
            int sonuc = toplama.Topla(a, b);

            // Sonucu ekrana yazdır
            Console.WriteLine($"Toplam: {sonuc}");
        }
    }
}
