using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulama4
{
    class Program
    {
        static void Main(string[] args)
        {
			//Klavyeden negatif sayı girilene kadar diğer sayıların toplayıp gösteren program

			int toplam = 0;
			int sayi = 0;
		go:
			try
			{
				while (sayi >= 0)
				{
					Console.WriteLine("Negatif sayı yazarsan öncekileri toplarım. Sen sayı yaz :");
					sayi = Convert.ToInt32(Console.ReadLine());

					if (sayi < 0)
					{
						break;
					}
					toplam += sayi;
				}
			}
			catch(Exception ex)
			{
				Console.WriteLine("Hatalı giriş!" + ex.Message);
				goto go;
			}
			Console.WriteLine("Girilenlerin toplamı : " + toplam);
			Console.ReadLine();
        }
    }
}
