using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diziler_ornek4
{
    class Program
    {
        static void Main(string[] args)
        {
			// 100 - 200 arasında random atanan 7 sayının son rakamı 0 olanların toplamını bulsun

			Random r = new Random();
			int[] dizi = new int[7];
			int toplam = 0;

			for(int i = 0; i < 7; i++)
			{
				dizi[i] = r.Next(100, 201);
				Console.WriteLine((i + 1) + ". sayı: " + dizi[i]);
				if(dizi[i] % 10 == 0)
				{
					toplam += dizi[i];
				}
			}
			Console.WriteLine("Son rakamı 0 olanların toplamı: " + toplam);
			Console.ReadLine();
        }
    }
}
