using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace random_ornek1
{
    class Program
    {
        static void Main(string[] args)
        {
			//Random: Rastgele sarı üretir.
			//Random bir class'tır.

			Random rastgele = new Random();
			//int sayi = rastgele.Next(); // 0 - int.MaxValue arasında değer üretir
			//Console.WriteLine(sayi);

			int sayi = rastgele.Next(10, 100); // minValue yani 10 dahil, fakat maxValue yani 100 dahil değil!
			Console.WriteLine("10 - 100 arası rastgele sayı: " + sayi);
			Console.ReadLine();

        }
    }
}
