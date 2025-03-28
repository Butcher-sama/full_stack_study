using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metotlar2
{
	internal class Program
	{
		public static double vergi_hesapla(double fiyat, int adet)
		{
			fiyat *= adet;
			double kdv = fiyat + (fiyat * 0.18);
			return (kdv);
		}

		public static void son_tutar(double toplam)
		{
			if (toplam >= 5000 && toplam < 10000)
			{
				double son_tutar = toplam - (toplam * 10 / 100);
				Console.WriteLine("%10 İndirim ve Hediye ütü kazandınız. Ödemeniz gerekn son tutar : " + son_tutar);
			}
			else if (toplam >= 10000 && toplam < 15000)
			{
				double son_tutar = toplam - (toplam * 20 / 100);
				Console.WriteLine("%20 İndirim ve Robot süpürge kazandınız. Ödemeniz gerekn son tutar : " + son_tutar);
			}
			else if (toplam >= 15000)
			{
				double son_tutar = toplam - (toplam * 25 / 100);
				Console.WriteLine("%25 İndirim ve Kahve makinesi kazandınız. Ödemeniz gerekn son tutar : " + son_tutar);
			}
		}
		static void Main(string[] args)
		{
			// Züccaciye
			// Mutfak gereçleri satılsın -> Tencere takımı, Yemek Takımı
			// Oda gereçleri olsun

			// metot -> vergi_hesapla(fiyat, adet) sonucunda %18 KDV uygulayacak
			// vergi_hesapla dan gelen son tutara göre ayrı bir metot hazırlanacak
			// hediye(son_tutar)
			// if 5000 < son_tutar < 10.000 -> %10 indirim + ütü hediye et
			// if 10.000 < son_tutar < 15.000 -> %20 indirim + robot süpürge hediye et
			// if 15.000 < son_tutar -> %25 indirim + kahve makinesi hediye et

			double	fiyat;
			int adet;
			Console.WriteLine("Hangi ürün grubundan bir ürün aldınız?");
			Console.WriteLine("1) Mutfak gereçleri");
			Console.WriteLine("2) Oda gereçleri");
			string urun = Console.ReadLine();

			if (urun.ToLower() == "mutfak gereçleri")
			{
				Console.WriteLine("Mutfak gereçlerinden seçim yapınız:");
				Console.WriteLine("1) Tencere Takımı");
				Console.WriteLine("2) Yemek Takımı");
				string secim = Console.ReadLine();

				if (secim.ToLower() == "tencere" || secim.ToLower() == "yemek")
				{
					Console.Write("Lütfen ürün fiyatını giriniz: ");
					fiyat = Convert.ToInt32(Console.ReadLine());
					Console.Write("Lütfen ürün adedini giriniz: ");
					adet = Convert.ToInt32(Console.ReadLine());

					double toplam = vergi_hesapla(fiyat, adet);
					Console.WriteLine("Toplam tutar : " + toplam);
					son_tutar(toplam);
				}
			}
			else if (urun.ToLower() == "oda")
			{
				Console.WriteLine("İyi alışverişler");
			}
			Console.ReadLine();
		}
	}
}
