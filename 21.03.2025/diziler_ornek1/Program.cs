using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diziler_ornek1
{
    class Program
    {
        static void Main(string[] args)
        {
			// Kullanıcının belirlediği eleman sayısı olan bir dizi için kullanıcı değer girecek ve bu verilerin ortalamaları bulup yazacak

			double toplam = 0, ortalama = 0;
			Console.WriteLine("Kaç adet sayının ortalamasını istiyorsun?");
			int n = Int32.Parse(Console.ReadLine()); //string veriyi alıp onu int verisine dönüştürür

			double[] dizi = new double[n];
			for(int i = 0; i < dizi.Length; i++)
			{
				Console.WriteLine((i + 1) + ". elemanın değerini yazınız: ");
				dizi[i] = Convert.ToDouble(Console.ReadLine());
				toplam += dizi[i];
			}
			ortalama = toplam / n;
			Console.WriteLine(n + " elemanlı verdiğiniz sayıların ortalaması: " + ortalama);
			Console.ReadLine();
        }
    }
}
