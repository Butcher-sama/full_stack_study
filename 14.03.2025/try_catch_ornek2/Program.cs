using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace try_catch_ornek2
{
    class Program
    {
        static void Main(string[] args)
        {
		go:
			try
			{
				Console.WriteLine("Bir sayı girişi yapınız =");
				string giris = Console.ReadLine();
				int sayi = Convert.ToInt32(giris);

				Console.WriteLine("Girdiğiniz sayı = " + sayi);
			}
			catch (FormatException) // sayı yerine başka bir karakter girilirse bu kısım çalışır
			{
				Console.WriteLine("Hatalı giriş! Lütfen sadece sayı giriniz!\n");
				goto go;
			}
			catch (OverflowException) // çok büyük veya çok küçük sayı girildiğinde çalışır
			{
				Console.WriteLine("Hatalı giriş! Çok büyük veya çok küçük bir sayı girdiniz!\n");
				goto go;
			}
			catch (Exception ex) // beklenmeyen diğer tüm hatalar için kullanılır
			{
				Console.WriteLine("Beklenmeyen bir hata oluştu: " + ex.Message);
				goto go;
			}
			finally // her işlem sonucunda çalışacak
			{
				Console.WriteLine("İşlem tamamlandı");
			}
			Console.ReadLine();
        }
    }
}
