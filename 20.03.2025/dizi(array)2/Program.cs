using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dizi_array_2
{
    class Program
    {
        static void Main(string[] args)
        {
			int[] sayi = new int[5];
			sayi[0] = 10;
			sayi[1] = 20;
			sayi[2] = 30;
			sayi[3] = 40;
			sayi[4] = 50;
			// sayi[5] = 60; dizi sınır dışında yapılmaz!

			Console.WriteLine(sayi[4]);
			Console.ReadLine();
		}
    }
}
