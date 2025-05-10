using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diziler_ornek2
{
    class Program
    {
        static void Main(string[] args)
        {
			// 5 elemanlı dizide kullanıcının girdiği dizi elemanlarından çift sayıların ve tek sayıların toplamını bulup gösteren program

			int cift_toplam = 0;
			int tek_toplam = 0;
			int[] dizi = new int[5];

			for(int i = 0; i < 5; i++)
			{
				Console.WriteLine((i + 1) + ". elemanı giriniz:");
				dizi[i] = Convert.ToInt32(Console.ReadLine());
				if (dizi[i] % 2 == 0)
					cift_toplam += dizi[i];
				if (dizi[i] % 2 != 0)
					tek_toplam += dizi[i];
			}
			Console.WriteLine("Çift sayıların toplamı: " + cift_toplam);
			Console.WriteLine("Tek sayıların toplamı: " + tek_toplam);
			Console.ReadLine();
		}
    }
}
