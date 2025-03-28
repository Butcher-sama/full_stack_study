using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek_uygulama1
{
    class Program
    {
        static void Main(string[] args)
        {
			// Bir komisyoncu sattığı mallardan fiyatı 500 tlye kadar olanlardan %3 komisyon alır, daha fazla olanlardan %2 komisyon almaktadır.
			// Klavyeden teker teker girilen 5 malın komisyonlarını bulup ekrana yazdıran ve en sonunda toplam komisyonu bulduran programı yazalım

			float total_kom = 0;
			float kom;

			for (int i = 1; i <= 5; i++)
			{
				Console.WriteLine("Satılan " + i + ". malın fiyatını yazınız =");
				float fiyat = Convert.ToSingle(Console.ReadLine());
				
				if (fiyat <= 500)
				{
					kom = ((fiyat * 3) / 100);
					total_kom += kom;
					Console.WriteLine(i + ". üründen alınan %3'lük komisyon = " + kom + "\n");
				}
				else
				{
					kom = ((fiyat * 2) / 100);
					total_kom += kom;
					Console.WriteLine(i + ". üründen alınan %2'lik komisyon = " + kom + "\n");
				}
			}
			Console.WriteLine("Satılan 5 üründen alınan toplam komisyon = " + total_kom);
			Console.ReadLine();
        }
    }
}
