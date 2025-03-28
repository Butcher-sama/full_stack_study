using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulama1
{
    class Program
    {
        static void Main(string[] args)
        {
			// kira hesabı yapan bir program yazalım
			// Kullanıcıdan sözleşme başlangıç yılı, bitiş yılı, kira, yıllık kira artış miktarı istenecek
			// Her yılın kirasını yazdıralım

			Console.WriteLine("Sözleşmenin başlangıç yılını giriniz :");
			int basyil = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Sözleşmenin bitiş yılını giriniz :");
			int bityil = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Sözleşmenin başlangıç kira bedelini giriniz :");
			int kira = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Kira yıllık artış yüzdesini giriniz :");
			int yuzde = Convert.ToInt32(Console.ReadLine());

			float toplamkira = kira;

			while(basyil <= bityil)
			{
				Console.WriteLine(basyil + ". yılın kirası = " + toplamkira);
				basyil++;
				toplamkira += (toplamkira * yuzde) / 100;
			}
			Console.ReadLine();
		}
    }
}
