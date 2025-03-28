using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dizilerde_try_catch
{
    class Program
    {
		static void Main(string[] args)
		{
		go:
			try
			{
				int[] sayilar = { 10, 20, 30, 40 };

				Console.WriteLine("Kaçıncı elemanı görmek istiyorsun?");
				int index = Convert.ToInt32(Console.ReadLine());

				Console.WriteLine("Seçilen sayı: " + sayilar[index]);
			}
			catch (Exception ex)
			{
				Console.WriteLine("Hata mesajı: " + ex.Message + "\n");
				goto go;
			}
			finally
			{
				Console.WriteLine("Program tamamlandı");
			}
			Console.ReadLine();
        }
    }
}
