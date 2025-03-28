using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace try_catch_ornek1
{
    class Program
    {
        static void Main(string[] args)
        {
		// Try Bloğu:	Hata oluşabilecek kodları içerir
		// Catch Bloğu:	Oluşan hataları yakalar ve programın çökmesini engeller
		// Finally:		Her durumda çalışır ve en son yazılması istenen mesaj buraya yazılabilir

		go:
			try
			{
				Console.WriteLine("1. sayıyı giriniz: ");
				int sayi1 = Convert.ToInt32(Console.ReadLine());

				Console.WriteLine("İkinci sayıyı giriniz: ");
				int sayi2 = Convert.ToInt32(Console.ReadLine());
			}
			catch (Exception)
			{
				Console.WriteLine("Hata tespit edildi. Doğru formatta sayı giriniz!\n");
				goto go; // işaretlenen yerden yeniden başlamasını sağlıyor
			}
			Console.ReadLine();
		}
    }
}
