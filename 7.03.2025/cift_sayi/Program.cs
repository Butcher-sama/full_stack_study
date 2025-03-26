using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cift_sayi
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Çiflerin üst sınırını yazınız :");
			int limit = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("İşte Çiftler :");
			for(int i = 2; i <= limit; i = i + 2)
			{
				Console.WriteLine(i + "\n");
			}
			Console.ReadKey();
        }
    }
}
