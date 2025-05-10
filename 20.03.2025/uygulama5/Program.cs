using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulama5
{
    class Program
    {
        static void Main(string[] args)
        {
			// Girilen metindeki karakter ve sesli harf sayısını bulan ve yazan program

			string sesliharf = "aeıioöuü";
			int sayac = 0;

			Console.WriteLine("Bir metin giriniz :");
			string metin = Console.ReadLine();
			
			foreach(char karakter in metin)
			{
				Console.Write(karakter);
				foreach(char sesli in sesliharf)
				{
					Console.Write(sesli);
					if(karakter == sesli)
					{
						sayac++;
					}
				}
			}
			Console.WriteLine("Girilen metnin karakter uzunluğu : " + metin.Length);
			Console.WriteLine("Girilen metindeki sesli harf sayısı : " + sayac);
			Console.ReadLine();
		}
	}
}
