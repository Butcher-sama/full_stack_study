using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genel_uygulama
{
    class Program
    {
        static void Main(string[] args)
        {
			// Program rastgele 1 - 20 arasında sayı tutsun
			// Kullanıcı tutulan sayıyı tahmin etsin
			// Kaçıncı kerede tahmini tuttuğunu yazdırsın

			int count = 0;
			Random r = new Random();
			int sayi = r.Next(1, 21);
			int tahmin = 0;
		
			Console.WriteLine("1 - 20 arasında tuttuğum sayıyı tahmin et");
		go:
			try
			{
				while (sayi != tahmin)
				{
					tahmin = Convert.ToInt32(Console.ReadLine());
					count++;
					if (sayi == tahmin)
					{
						Console.WriteLine("Tebrikler bildin");
						Console.WriteLine(count + ". kerede tutturdun helal sana");
						Console.ReadLine();
					}
					else
					{
						Console.WriteLine("Bilemedin tekrar dene");
						if (sayi > tahmin)
							Console.WriteLine("Arttır!");
						else if (sayi < tahmin)
							Console.WriteLine("Azalt!");
					}
				}
			}
			catch (Exception)
			{
				Console.WriteLine("Sayısal bir değer giriniz!");
				goto go;
			}
        }
    }
}
