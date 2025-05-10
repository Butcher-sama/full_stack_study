using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev
{
    class Program
    {
        static void Main(string[] args)
        {
			// Furkan Kasap 14.03.2025 ödev
			Random r = new Random();
			const string alpnbr = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()-_=+<>?";

			char[] sifre = new char[8];

			bool buyukHarfVar = false;
			bool kucukHarfVar = false;
			bool sayiVar = false;
			bool ozelVar = false;

			for (int i = 0; i < 8; i++)
			{
				sifre[i] = alpnbr[r.Next(alpnbr.Length)];

				if (sifre[i] >= 'A' && sifre[i] <= 'Z')
					buyukHarfVar = true;
				else if (sifre[i] >= 'a' && sifre[i] <= 'z')
					kucukHarfVar = true;
				else if (sifre[i] >= '0' && sifre[i] <= '9')
					sayiVar = true;
				else
					ozelVar = true;
			}
			Console.WriteLine("Yeni şifre: " + new string(sifre));
			if (buyukHarfVar && kucukHarfVar && sayiVar && ozelVar)
				Console.WriteLine("Şifre güçlü");
			else
				Console.WriteLine("Şifre Zayıf!");
			Console.ReadLine();
		}
    }
}
