using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genel_uygulama1
{
    class Program
    {
        static void Main(string[] args)
        {
		// Takımı X olan ve yaşı 18'den büyük olanlar sisteme giriş yapabilsin
		// Farklı takımda olanlar giriş yapamasın
		// Sisteme giriş yapan kişiden cinsiyet ve meslek bilgisi alındığında %10 indirim uygula (cinsiyet: kadın, meslek: mühendis)

		go:
			try
			{
				Console.WriteLine("Takımınızı yazınız:");
				string takim = Console.ReadLine();

				Console.WriteLine("Yaşınızı yazınız:");
				int yas = Convert.ToInt32(Console.ReadLine());

				if (takim.ToLower() == "x" && yas >= 18)
				{
					Console.WriteLine("X Sistemine Hoşgeldiniz");
					int abonman = 5000;

					Console.WriteLine("Cinsiyetinizi yazınız: (erkek/kadın)");
					string cinsiyet = Console.ReadLine();

					Console.WriteLine("Mesleğinizi yazınız:");
					string meslek = Console.ReadLine();

					if (cinsiyet.ToLower() == "kadın" && meslek.ToLower() == "mühendis")
					{
						abonman -= abonman * 10 / 100;
						Console.WriteLine("İndirimli abonman tutarınız: " + abonman);
					}
					else
					{
						Console.WriteLine("Abonman Tutarınız: " + abonman);
					}
				}
				else
				{
					Console.WriteLine("Bu sayfa size uygun değil!");
				}
				Console.WriteLine("Ana ekrana dönmek ister misiniz? evet/hayır");
				string cevap = Console.ReadLine();
				if (cevap.ToLower() == "evet")
				{
					Console.Clear();
					goto go;
				}
				else
				{
					Console.WriteLine("Çıkış Yapılıyor. Hoşçakal...");
					return;
				}
			}
			catch(Exception ex)
			{
				Console.WriteLine("Hata alındı: " + ex.Message);
				goto go;
			}
        }
    }
}
