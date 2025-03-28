using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dizi_array_4
{
    class Program
    {
        static void Main(string[] args)
        {
			string[] isimler = { "ayşe", "ali", "deniz" };
			for(int i = 0; i < isimler.Length; i++)
				Console.WriteLine("İsim listesi: " + isimler[i]);
			Console.ReadLine();
		}
    }
}
