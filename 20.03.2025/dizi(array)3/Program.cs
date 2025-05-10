using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dizi_array_3
{
    class Program
    {
        static void Main(string[] args)
        {
			int[] sayi = { 1, 2, 3, 4 };

			for(int i = 0; i < sayi.Length; i++)
			{
				Console.WriteLine(sayi[i]);
			}
			Console.ReadLine();
        }
    }
}
