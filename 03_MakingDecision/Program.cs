using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region IF

            //Console.WriteLine("Lütfen şifrenizi giriniz: ");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre doğru");


            //}
            //else
            //{
            //    Console.WriteLine("şifre doğru değil");
            //}


            //string capital, country;
            //Console.Write("Başkneti Giriniz:");
            //capital = Console.ReadLine();
            //Console.Write("Ülke giriniz:");
            //country = Console.ReadLine();
            //if (capital == "ankara" & country == "türkiye")
            //{
            //    Console.Write("Veriler doğrulandı");
            //}
            //else
            //{
            //    Console.Write("hatalı bilgi");

            //}

            //int sayi;
            //Console.Write("sayı giriniz: ");
            //sayi=int.Parse(Console.ReadLine());
            //if (sayi == 0)
            //{
            //    Console.WriteLine("sayı 0'a eşit");
            //}

            //else
            //{
            //    Console.WriteLine("0 değil");
            //}

            //int exam1, exam2, exam3, average;
            //string result="hata";
            //Console.Write("Sınav1: ");
            //exam1=int.Parse(Console.ReadLine());
            //Console.Write("Sınav2: ");
            //exam2 =int.Parse(Console.ReadLine());
            //Console.Write("Sınav3: ");
            //exam3 =int.Parse(Console.ReadLine());
            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınavların Ortalaması : " + average);
            //if(average>0 & average <= 50)
            //{
            //    result="Sonuç vasat";

            //}
            //if (average > 50 & average <= 70)
            //{
            //    result = "Sonuç orta";

            //}
            //if (average > 70 & average <= 84)
            //{
            //    result = "iyi";

            //}
            //if (average > 84)
            //{
            //    result = "çok iyi";

            //}
            //Console.Write(result);

            //string city;
            //Console.Write("Lütfen şehir giriniz");
            //city = Console.ReadLine();

            //if (city == "adana" | city == "kilis")
            //{
            //    Console.WriteLine("şehir mevcut");
            //}

            //else
            //{
            //    Console.WriteLine("şehir mevcut değil");
            //}


            //string username;
            //Console.WriteLine("Lütfen kullanıcı adını giriniz:");
            //username = Console.ReadLine();
            //if (username != "admin")
            //{
            //    Console.WriteLine("olmaz");
            //}
            //else
            //{
            //    Console.WriteLine("hoşgeldiniz");
            //}

            #endregion

            #region mod

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("Birinci sayıyı giriniz");
            //int number1= int.Parse(Console.ReadLine());

            //Console.Write("ikinci sayıyı giriniz");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;
            //Console.Write("1.sayının 2.sayıya bölümünden kalan =" + result);

            //Console.WriteLine("Lütfen sayıyı giriniz");
            //int number=int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("çift");
            //}
            //else
            //{
            //    Console.WriteLine("tek");
            //}

            //klavyeden giren harfe göre takım
            //char team;
            //Console.WriteLine("takımınızın baş harfini giriniz");
            //team=char.Parse(Console.ReadLine());    

            //if(team =='g'  |team== 'G')
            //{
            //    Console.WriteLine("galatasaray");
            //}

            //if (team == 'b' | team == 'B')
            //{
            //    Console.WriteLine("Beşiktaş");
            //}
            #endregion
            #region Örnek Proje Uygulamaaları

            Console.WriteLine("**C# eğitim kampı restorant**");
            Console.WriteLine();
            Console.WriteLine("------------------------");

            Console.WriteLine("1-Ana yemekler");
            Console.WriteLine("2-Çorba");
            Console.WriteLine("3-Pizza");
            Console.WriteLine("4-İçecek");
            Console.WriteLine("5-Tatlılar");
            Console.WriteLine("------------------------");
            Console.WriteLine();

            string menuItem;
            Console.WriteLine("görmek istediğiniz menüyü seçiniz");
            menuItem = Console.ReadLine();

            if (menuItem == "1")
            {
                Console.WriteLine();
                Console.WriteLine("--------- Ana Yemekler ---------");
                Console.WriteLine("");
                Console.WriteLine("1-Köri Soslu Tavuk");
                Console.WriteLine("2-Kızartma tabağı");
                Console.WriteLine("3-Fasulye Pilavı");
                Console.WriteLine("4-Fırında Somon");
                Console.WriteLine("5-Patlıcan Musakka");
                Console.WriteLine();

            }

            if (menuItem == "2")
            {
                Console.WriteLine();
                Console.WriteLine("--------- Çorbalar ---------");
                Console.WriteLine("");
                Console.WriteLine("1-M.Çorba");
                Console.WriteLine("2-Ezogelin Çorba");

                Console.WriteLine();

            }
            if (menuItem == "3")
            {
                Console.WriteLine();
                Console.WriteLine("--------- Pizzalar ---------");
                Console.WriteLine("");
                Console.WriteLine("1-a. pizza");
                Console.WriteLine("2-b. pizza");
                Console.WriteLine("2-c. pizza");

                Console.WriteLine();

            }
            if (menuItem == "4")
            {
                Console.WriteLine();
                Console.WriteLine("---------İçecekler---------");
                Console.WriteLine("");
                Console.WriteLine("1-su");
                Console.WriteLine("2-süt");

                Console.WriteLine();

            }
            if (menuItem == "5")
            {
                Console.WriteLine();
                Console.WriteLine("--------Tatlılar---------");
                Console.WriteLine("");
                Console.WriteLine("1-sütlaç");
                Console.WriteLine("2-çok tatlı");

                Console.WriteLine();

            }
            #endregion

            Console.Read();
        }
    }
}
        
