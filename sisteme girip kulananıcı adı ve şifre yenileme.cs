using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hazırStringMetotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            DEVAM:
            Console.Write("Kullanıcı adınızı giriniz:");
            string kAdi = Console.ReadLine();
            Console.Write("Şifrenizi giriniz:");
            string sifre = Console.ReadLine();
            string kayıtlıİsim = "Sümeyye";
            string kayıtlıSifre = "13011999";
            int x = string.Compare(kAdi,kayıtlıİsim);
            int y = string.Compare(sifre, kayıtlıSifre);
            if (x==0&&y==0)
            {
                Console.WriteLine("Giriş onaylanmıştır.");

            }
            else
            {
                Console.Clear();
                Console.WriteLine("Kullanıcı adı ya da şifre yanlış.. tekrar deneyin");

                goto DEVAM;
            }
            orn=string.Compare
            Console.Write("Sİsteme hoşgeldiniz.\nKullanıcı adınızı belirleyiniz:");
            string isim = Console.ReadLine();
            BAS:
            Console.Write("\nŞifre belirleyin:");
            string sifre1 = Console.ReadLine();
            Console.Write("\nŞifrenizi tekrar girin:");
            string sifre2 = Console.ReadLine();
            int x = string.Compare(sifre1, sifre2,true);//3. parametre olarak true girilince büyük küçük harf kullanımına dikkat edilmiyor
            if (x==0)
            {
                Console.WriteLine("Şifreler aynı. kaydınız tamamlanmıştır.\nKullanıcı adınız:{0}\nŞifreniz:{1}",isim,sifre1);
            }
            else
            {
                Console.WriteLine("Girilen şifreler aynı değil. Tekrar deneyin.");
                goto BAS;
            }

            Console.ReadKey();

        }
    }
}
