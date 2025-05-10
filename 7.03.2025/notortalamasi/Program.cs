using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace notortalamasi
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("İlk dersinizin notunu giriniz :");
			double not1 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("İkinci dersinizin notunu giriniz :");
			double not2 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Üçüncü dersinizin notunu giriniz :");
			double not3 = Convert.ToDouble(Console.ReadLine());

			double ort = (not1 + not2 + not3) / 3;
			Console.WriteLine("Derslerinizin ortalaması : {0:F2}", ort);
			Console.ReadKey();
		}
    }
}
