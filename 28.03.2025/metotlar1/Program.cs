using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metotlar1
{
	internal class Program
	{
		public static float zam(float fiyat, float oran)
		{
			fiyat += fiyat * oran / 100;
			return (fiyat);
		}

		public static float indirim(float fiyat, float oran)
		{
			if (fiyat > 1000)
				fiyat -= fiyat * oran / 100;
			else
				fiyat -= 100;
				return (fiyat);
		}

		public static void ozellik(string urun, float fiyat)
		{
			if (urun == "bardak" || urun == "sürahi")
			{
				Console.WriteLine("Bardak ve sürahilerde indirim var faydalanın");
			}
			else
			{
				Console.WriteLine("Diğer ürünlerde ekstra indirim var");
				Console.WriteLine("Fiş tutarı üzerinden 100 tl indirim var");
				Console.WriteLine("Son ödeme tutarı: " + (fiyat - 100));
			}
			Console.WriteLine("Kampanyaya katılmak ister misiniz?");
			string cevap = Console.ReadLine();
			if (cevap == "evet")
			{
				int hediye_ceki = 2000;
				Console.WriteLine($"Bir sonraki alışverişinizde kullanmak üzere {hediye_ceki} kadar bonus para kazandınız");
			}
			else
				Console.WriteLine("Teşekkürler İyi Günler");
		}
		static void Main(string[] args)
		{
			float fiyat = 0;
			float oran = 0;

			// Kullanıcıdan ürün seçimi isteyecek
			// zam metodu, indirim metodu ve özellik metodu olacak

			Console.WriteLine("1- Bardak");
			Console.WriteLine("2- Sürahi");
			Console.WriteLine("3- Termos");
			Console.WriteLine("Ürün Seçiniz");
			
			string urun = Console.ReadLine();

			switch (urun)
			{
				case "bardak": // zam metodu
				{
					Console.WriteLine("Fiyatı Giriniz:");
					fiyat = Convert.ToInt32(Console.ReadLine());
					Console.WriteLine("Oran Giriniz:");
					oran = Convert.ToInt32(Console.ReadLine());
					float sonuc = zam(fiyat, oran);
					Console.WriteLine("Ödemeniz gereken tutar: " + sonuc);
					break;
				}
				case "sürahi": // indirim metodu
				{
					Console.WriteLine("Fiyatı Giriniz:");
					fiyat = Convert.ToInt32(Console.ReadLine());
					Console.WriteLine("Oran Giriniz:");
					oran = Convert.ToInt32(Console.ReadLine());
					float sonuc = indirim(fiyat, oran);
					Console.WriteLine("Ödemeniz gereken tutar: " + sonuc);
					break;
				}
				case "termos":
				{
					Console.WriteLine("Fiyatı Giriniz:");
					fiyat = Convert.ToInt32(Console.ReadLine());
					Console.WriteLine("Oran Giriniz:");
					oran = Convert.ToInt32(Console.ReadLine());

					Console.WriteLine("Ödemeniz gereken tutar " + zam(fiyat, oran));
					break;
				}
				default:
				{
					Console.WriteLine("Fiyat Giriniz: ");
					fiyat = Convert.ToInt32(Console.ReadLine());

					ozellik(urun, fiyat);
					break;
				}
			}
			Console.ReadLine();
		}
	}
}
