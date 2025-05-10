using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace degiskenler2
{
    class Program
    {
        static void Main(string[] args)
        {

			Console.WriteLine("İsminizi Yazınız :");
			string name = Console.ReadLine();

			Console.WriteLine("Mezuniyet Notunuzu Giriniz :");
			float point = Convert.ToSingle(Console.ReadLine());

			Console.WriteLine("Tecrübe Yılını Giriniz :");
			int exp = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Cİnsiyetinizi Giriniz (E/K) :");
			char gender = Convert.ToChar(Console.ReadLine());

			Console.WriteLine("<----- ÇIKTI EKRANI ----->");
			Console.WriteLine("Adınız :" + name);
			Console.WriteLine("Mezuniyet Notunuz :" + point);
			Console.WriteLine("Tecrübe yılınız :" + exp);
			Console.WriteLine("Cinsiyetiniz :" + gender);
			Console.ReadKey();
		}
    }
}
