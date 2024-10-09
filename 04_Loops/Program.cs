using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region for föngüsü
            // for( x;y;z)
            // x:başlangiç , y:bitiş , z: artış azalış
            //int i;
            //for (i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("C# eğitim kampı");
            //}

            //for (int i = 1; i<=20; i++ )
            //{
            //    Console.WriteLine(i);
            //}
            //for (int i = 3; i <= 50; i += 3)
            //{
            //    Console.WriteLine(i);

            //}
            //Console.Write("Lütfen ekrana yazılmasını istedğiniz " +
            //    "adeti giriniz");
            //int finishValue= int.Parse(Console.ReadLine());
            //for (int i = 0; i < finishValue; i++)
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet");
            //}

            #endregion

            #region For Döngüsü Karar yapıları

            //for (int i = 0; i <= 100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }

            //}

            //int totalValue = 0;
            //for (int i = 0; i <= 10; i++)
            //{
            //    totalValue += i;
            //}
            //Console.WriteLine(totalValue);


            //int totalValue =0;
            //for (int i = 1; i < 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine(i);

            //    }
            //}

            //Console.WriteLine(totalValue);


            //int count = 0;
            //for (int i = 1; i <= 50; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);   

            // 1-2 -4 -8 -16

            //int bakteri = 1;
            //for (int i = 1;i <= 24; i++)
            //{
            //    bakteri *= 2;
            //    Console.WriteLine(i + ".saat sonunda " + bakteri);

            //}


            #endregion

            #region While döngüsü

            //// while (şart) { işlmeler }
            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            // 1 ile 10 arasında 3 e tam bölünen sayılar

            //int i = 1;
            //while (i <=10)
            //{
            //   if(i%3== 0)
            //    {
            //        Console.WriteLine(i);

            //    }
            //    i++;
            //}

            // int i = 1;
            //int sum = 0;
            // while (i <= 10)
            // {
            //     sum += i;
            //     i++;
            // }
            // Console.WriteLine(sum);


            #endregion

            #region Örnek sınav sorusu
            // klavyeden girilen 3 basamaklı sayının basamakları
            // toplamını hesaplayan

            //456
            Console.Write("sayıyı giriniz");
            int number=int.Parse(Console.ReadLine());
            int ones, tens, hundreds, sum;
            ones = number % 10;
            Console.WriteLine(ones);
            hundreds = number / 100;
            Console.WriteLine(hundreds);

             tens = (number % 100) / 10;
          //  tens = (number - (hundreds * 100 + ones))/10;
            Console.WriteLine(tens);

            sum = ones + tens + hundreds;

             

            #endregion
            Console.Read();
        }
    }
}
