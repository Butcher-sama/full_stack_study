using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace random_ornek3
{
    class Program
    {
        static void Main(string[] args)
        {
			// 8 tane 10 - 100 arasında random sayı üret, 2 ve 7 ye bölünenlerin adedini bul

			Random r = new Random();
			int count = 0;

			for (int i = 1; i <= 8; i++)
			{
				int nbr = r.Next(10, 100);
				Console.WriteLine(i + ". random sayı = " + nbr);
				if ((nbr % 14) == 0)
				{
					Console.WriteLine("2 ve 7 ye bölünen " + (count + 1) + ". sayı = " + nbr);
				}
			}
			Console.WriteLine("Toplamda 2 ve 7 ye tam bölünen " + count + " adet sayı üretilmiş");
			Console.ReadLine();
        }
    }
}
