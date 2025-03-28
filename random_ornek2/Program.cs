using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace random_ornek2
{
    class Program
    {
        static void Main(string[] args)
        {
			// Üretilen 10 random sayının toplamını bulan program 100 - 501

			int total = 0;
			Random r = new Random();

			for (int i = 1; i <= 10; i++)
			{
                int nbr = r.Next(100, 501);
				Console.WriteLine(i + ". random sayı = " + nbr);
                total += nbr;
			}
            Console.WriteLine("10 rastgele sayının toplamı = " + total);
            Console.ReadLine();
        }
    }
}
