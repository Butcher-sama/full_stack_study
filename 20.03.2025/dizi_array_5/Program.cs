using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dizi_array_5
{
    class Program
    {
        static void Main(string[] args)
        {
			// Dizinin elemanlarını dışarıdan alan ve boyutunu kullanıcının belirlediği programı yazalım
			// Yaş bilgisi

			Console.WriteLine("Dizi boyutunu yazınız:");
			int len = Convert.ToInt32(Console.ReadLine());

			int[] dizi = new int[len];

			for(int i = 0; i < len; i++)
			{
				Console.WriteLine((i + 1) + ". yaşı giriniz");
				dizi[i] = Convert.ToInt32(Console.ReadLine());
			}
			Array.Sort(dizi); // dizileri sorting yapıyor
			for (int i = 0; i < len; i++)
			{
				Console.WriteLine("Yeniden sıralı yazma: " + dizi[i]);
			}
			Console.ReadLine();
        }
    }
}
