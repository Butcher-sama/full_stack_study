using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulama2
{
    class Program
    {
        static void Main(string[] args)
        {
			// 1- 100 arasında rastgele tutulan sayıların 5'E bölünenlerin toplamı 1000 i bulan program

			Random r = new Random();
			int sayac = 0;
		go:
			int toplam = 0;
		
			while(toplam < 1000)
			{
				int nbr = r.Next(1, 101);
				if(nbr % 5 == 0)
				{
					Console.WriteLine("5. e bölünen sayı : " + nbr);
					toplam += nbr;
				}
			}
			if (toplam != 1000)
			{
				sayac++;
				Console.WriteLine(sayac + ". deneme başarızı. Hadi bir daha\n");
				goto go;
			}
			else
			{
				Console.WriteLine("Program bitti. Toplam = " + toplam);
				Console.WriteLine((sayac + 1) + ". denemede 1000 i bulduk");
			}
			Console.ReadLine();
        }
    }
}
