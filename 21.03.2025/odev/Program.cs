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
		{// Furkan Kasap 21.03.2025 ödev ----->
			// Kullanıcıdan, Kullanıcı adı ve şifre istensin
			// Eğer bilgiler doğru ise yaş ve emeklilik primi istenecek
			// --> Yaş > 40 && emeklilik primi > 5000 gün ise emeklilik hakkı kazansın.
			// Sonra maaş bilgisi ve çalışma yılı istensin
			// --> Çalışma yılı > 20 ise maaşın hesabını bulduralım
			// Maaş * yıl %80 ikramiye ver
			// değil ise maaş * yıl %50 ikramiye ver
			// Emeklilik primi 5000 den az ise primi hesaplat kaç prim günü kaldığını bildir
			// Sonra kullanıcıya prim günü borcunu ödemek ister misin diye sor
			// Evet der ise prim gün * prim fiyatını 5 taksitle ödemesi gerekn tutarı söyle

			bool buyukHarfVar = false;
			bool kucukHarfVar = false;
			bool sayiVar = false;
			bool ozelVar = false;

			Console.Clear();
			Console.WriteLine();
			int windowWidth = Console.WindowWidth;
			string text = "<---- EMEKLİLİK PORTALINA HOŞGELDİNİZ ---->";
			int padding = (windowWidth - text.Length) / 2;
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine(text.PadLeft(padding + text.Length));
			Console.ResetColor();

			Console.WriteLine("Yeni Kullanıcı Adı Giriniz:");
			string username = Console.ReadLine();
		pass_go:
			Console.WriteLine("Yeni Bir Şifre Belirleyin:");
			string password = ReadPassword();
			for (int i = 0; i < password.Length; i++)
			{
				if (password[i] >= 'A' && password[i] <= 'Z')
					buyukHarfVar = true;
				else if (password[i] >= 'a' && password[i] <= 'z')
					kucukHarfVar = true;
				else if (password[i] >= '0' && password[i] <= '9')
					sayiVar = true;
				else
					ozelVar = true;
			}
			if (!buyukHarfVar || !kucukHarfVar || !sayiVar || !ozelVar || password.Length < 8)
			{
				Console.WriteLine("\nZayıf Bir Şifre Girdiniz!");
				Console.WriteLine("Güçlü bir şifre için gerekenler:");
				Console.WriteLine("-En az 8 karakterden oluşmalı\n-En az 1 büyük 1 küçük 1 sayı ve 1 adet özel karakter girilmeli");
				goto pass_go;
			}
			Console.Clear();
			Console.WriteLine("Kullanıcı Başarılı Bir Şekilde Oluşturuldu.");
		wrong_username:
			Console.WriteLine("Lütfen Kullanıcı Adınızı Giriniz:");
			string login_username = Console.ReadLine();
			if (login_username != username)
			{
				Console.WriteLine("Yanlış Bir Kullanıcı Adı Girdiniz:");
				goto wrong_username;
			}
		wrong_password:
			Console.WriteLine("Lütfen Şifrenizi Giriniz:");
			string login_password = ReadPassword();
			if (login_password != password)
			{
				Console.WriteLine("\nYanlış Şifre Girdiniz!");
				goto wrong_password;
			}
			else
			{
				int age;
				while (true)
				{
					Console.Write("\nYaşınızı Giriniz: ");
					try
					{
						age = Convert.ToInt32(Console.ReadLine());
						if (age <= 0)
						{
							Console.WriteLine("Lütfen geçerli bir yaş giriniz! (Pozitif olmalı)");
							continue;
						}
						break;
					}
					catch (FormatException)
					{
						Console.WriteLine("Hatalı giriş! Lütfen sadece rakam giriniz.");
					}
					catch (OverflowException)
					{
						Console.WriteLine("Girilen sayı çok büyük! Lütfen geçerli bir yaş giriniz.");
					}
				}
				int prim;
				while (true)
				{
					Console.Write("Emeklilik Prim Gününüzü Giriniz:");
					try
					{
						prim = Convert.ToInt32(Console.ReadLine());
						if (prim < 0)
						{
							Console.WriteLine("Lütfen geçerli bir prim gün giriniz! (Pozitif olmalı)");
							continue;
						}
						break;
					}
					catch (FormatException)
					{
						Console.WriteLine("Hatalı giriş! Lütfen sadece rakam giriniz.");
					}
					catch (OverflowException)
					{
						Console.WriteLine("Girilen sayı çok büyük! Lütfen geçerli bir yaş giriniz.");
					}
				}
				
				if (age > 40 && prim > 5000)
				{
					Console.WriteLine("Tebrikler Emeklilik Hakkı Kazandınız!");
					Console.WriteLine("Kaç Yıl Çalıştığınızı Giriniz:");
					int work_year = Convert.ToInt32(Console.ReadLine());
					Console.WriteLine("En Son Hak Edilmiş Aylık Maaşınızı Giriniz:");
					int salary = Convert.ToInt32(Console.ReadLine());

					if (work_year > 20)
						Console.WriteLine("%80'lik hak edişle ikramiyeniz: " + ((salary * work_year) * 0.8));
					else
						Console.WriteLine("%50'lik hak edişle ikramiyeniz: " + ((salary * work_year) * 0.5));
				}
				else if (age > 40 && prim <= 5000)
				{
					Console.WriteLine($"{5000 - prim} prim gününüz eksiktir. Eksik prim günleri ödemek ister misiniz? (evet / hayır)");
					string confirm = Console.ReadLine();
					if (confirm.ToLower() == "evet")
					{
						int prim_debt = (5000 - prim) * 866;
						int taksitMiktari = prim_debt / 5;
						for (int i = 1; i <= 5; i++)
						{
							Console.WriteLine($"{i}. taksit = {taksitMiktari}");
						}
					}
				}
				else
					Console.WriteLine("Maalesef daha emeklilik hakkı kazanamadınız");
			}
			Console.ReadLine();
		}

		static string ReadPassword()
		{
			string password = "";
			while (true)
			{
				ConsoleKeyInfo key = Console.ReadKey(true); // true ile ekrana yazdırmayı engelleriz

				if (key.Key == ConsoleKey.Enter) // Enter'a basılınca döngüyü kır
					break;
				else if (key.Key == ConsoleKey.Backspace && password.Length > 0) // Backspace ile silme
				{
					password = password.Substring(0, password.Length - 1); // Son karakteri sil
					Console.Write("\b \b"); // Konsoldan da karakteri kaldır
				}
				else if (!char.IsControl(key.KeyChar)) // Kontrol karakterleri hariçse şifreye ekle
				{
					password += key.KeyChar;
					Console.Write("*"); // Kullanıcıya yıldız göster
				}
			}
			return password;
		}
	}
}
