using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace degiskenler1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             DEĞİŞKENLER VE VERİ TİPLERİ

            değişkenler: verileri taşır
            metinsel veri tipi: string
            tam sayı: int
            ondalıklı sayı: float(10,5f), double(10,5d), decimal(10,5m)
            tek karakter: char
            bool: true / false

            dışarıdan girilen tüm veriler string olarak tanımlanır
            diğer değişken türleri ile işlem için tür dönüşümü yapılmalı (convert veya parse)
            
            -Convert için;
            int => ToInt32
            char => ToChar
            float => ToSingle
            decimal => ToDecimal
            double => ToDouble
            */

            string name = "Furkan";
            string province = "Istanbul";
			int nbr1 = 20;
			float nbr2 = 100.4f;
            double nbr3 = 100.4d;
            decimal nbr4 = 100.4m;
            char gender = 'K';

			Console.WriteLine("<----- KAYIT BİLGİLERİ ----->\n");
			Console.WriteLine("Adı Soyadı	:" + name);
			Console.WriteLine("İl		:" + province);
			Console.WriteLine("Sayı 1		:" + nbr1);
			Console.WriteLine("Sayı 2		:" + nbr2);
			Console.WriteLine("Sayı 3		:" + nbr3);
			Console.WriteLine("Sayı 4		:" + nbr4);
			Console.WriteLine(); //boş satır işlevi görür
			Console.WriteLine("Cinsiyet	:" + gender);

			Console.ReadKey();
			

        }
    }
}
