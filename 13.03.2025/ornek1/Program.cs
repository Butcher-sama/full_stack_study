using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek1
{
    class Program
    {
        static void Main(string[] args)
        {
			int toplam = 0;
			int sayi;

			for (int i = 1; i <= 10; i++)
			{
				Console.Write(i + ". sayıyı giriniz: ");
				sayi = Convert.ToInt32(Console.ReadLine());

				if ((sayi % 2) == 0)
				{
					toplam += sayi;
				}
			}
			Console.WriteLine("Çift sayıların toplamı = " + toplam);
			Console.ReadKey();
        }
    }
}
