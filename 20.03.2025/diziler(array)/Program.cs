using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diziler_array_
{
    class Program
    {
        static void Main(string[] args)
        {
			// Aynı türdeki birden fazla değeri tek bir değişkende saklamaya yarayan veri yapısı
			// Sabit uzunluğa sahiptir
			// İndeks numaraları ile elemanlara erişilir

			int[] sayi = { 10, 20, 30, 40, 50 };
			Console.WriteLine(sayi[0]);
			Console.WriteLine(sayi[3]);
			Console.ReadLine();
        }
    }
}
