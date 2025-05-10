using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulama3
{
    class Program
    {
        static void Main(string[] args)
        {
			// Klavyeden 15 girilene kadar sayıları toplayıp ekrana yazar program

			int toplam = 0;
			int sayi = 0;

			while(sayi != 15)
			{
				Console.WriteLine("Sayı giriniz :");
				sayi = Convert.ToInt32(Console.ReadLine());

				if(sayi == 15)
				{
					break;
				}
				toplam += sayi;
			}
			Console.WriteLine("Toplam sonucu : " + toplam);
			Console.ReadLine();
        }
    }
}
