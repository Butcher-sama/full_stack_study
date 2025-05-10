using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metot_overloading
{
	internal class Program
	{
		public static void not_hesap(double s1, double s2)
		{
			double ort = (s1 + s2) / 2;
			Console.WriteLine("Not ortalamanız: " + ort);
		}

		public static void not_hesap(double s1, double s2, double sozlu)
		{
			double ort = (s1 + s2 +sozlu) / 3;
			Console.WriteLine("Not ortalamanız: " + ort);
		}

		public static void not_hesap(double s1, double s2, double sozlu, double kanaat)
		{
			double ort = (s1 + s2 + sozlu + kanaat) / 4;
			Console.WriteLine("Not ortalamanız: " + ort);
		}
		static void Main(string[] args)
		{
			// Metot Overloading (Aşırı yükleme): Aynı isimle metot oluşturmak için kullanılır. Fakat aynı olan metotların parametreleri farklı olmalıdır.

			Console.WriteLine("1) İlkokul");
			Console.WriteLine("2) Ortaokul");
			Console.WriteLine("3) Lise");
			Console.WriteLine("Lütfen okul seçimi yapınız");
			int okul = Convert.ToInt32(Console.ReadLine());

			if (okul == 1)
			{
				Console.WriteLine("1. Sınav Notunu Giriniz:");
				double not1 = Convert.ToDouble(Console.ReadLine());
				Console.WriteLine("2. Sınav Notunu Giriniz:");
				double not2 = Convert.ToDouble(Console.ReadLine());
				not_hesap(not1, not2);
			}
			else if (okul == 2)
			{
				Console.WriteLine("1. Sınav Notunu Giriniz:");
				double not1 = Convert.ToDouble(Console.ReadLine());
				Console.WriteLine("2. Sınav Notunu Giriniz:");
				double not2 = Convert.ToDouble(Console.ReadLine());
				Console.WriteLine("Sözlü Sınav Notunu Giriniz:");
				double sozlu = Convert.ToDouble(Console.ReadLine());
				not_hesap(not1, not2, sozlu);
			}
			else if (okul == 3)
			{
				Console.WriteLine("1. Sınav Notunu Giriniz:");
				double not1 = Convert.ToDouble(Console.ReadLine());
				Console.WriteLine("2. Sınav Notunu Giriniz:");
				double not2 = Convert.ToDouble(Console.ReadLine());
				Console.WriteLine("Sözlü Sınav Notunu Giriniz:");
				double sozlu = Convert.ToDouble(Console.ReadLine());
				Console.WriteLine("Kanaat Notunu Giriniz:");
				double kanaat = Convert.ToDouble(Console.ReadLine());
				not_hesap(not1, not2, sozlu, kanaat);
			}
			Console.ReadLine();
		}
	}
}
