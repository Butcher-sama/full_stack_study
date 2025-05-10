using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace donguler1
{
    class Program
    {
        static void Main(string[] args)
        {
			int toplam = 0;

			for(int i = 1; i <= 10; i++)
			{
				Console.Write(i+". Sayıyı Giriniz: ");
				int sayi = Convert.ToInt32(Console.ReadLine());
				toplam += sayi;
			}
			Console.WriteLine("Girilen 10 sayının toplamı = " + toplam);
			Console.ReadLine();
        }
    }
}
