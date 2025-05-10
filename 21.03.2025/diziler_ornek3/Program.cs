using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diziler_ornek3
{
    class Program
    {
        static void Main(string[] args)
        {
			// Kullanıcının girdiği 5 ismin listede kaçıncı sırada olduğunu bulan program

			string[] isimler = new string[5];

			for(int i = 0; i < 5; i++)
			{
				Console.WriteLine($"{i + 1}. ismi giriniz");
				isimler[i] = Console.ReadLine();
			}
			Console.WriteLine("Aradığınız ismi yazınız:");
			string aranan = Console.ReadLine();
			int indeks = 0;
			while (aranan != isimler[indeks])
			{
				indeks++;
				if (indeks >= 5)
				{
					Console.WriteLine("İsim listede bulunamadı");
					return;
				}
			}
			Console.WriteLine($"Aradığınız isim {indeks + 1}. sıradadır");
			Console.ReadLine();
        }
    }
}
