using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri
            //2.4.6.8
            //sarı,kırmızı,mavi
            //adana,ankara,istanbul,bursa
            //değilken türü[] diziadı = new değişkentürü[sayı];
            //string[] colors = new string[4];
            //colors[0] = "kırmızı";
            //colors[1] = "sarı";
            //colors[2] = "beyaz";
            //colors[3] = "mavi";
            //Console.WriteLine(colors[2]);
            //string[] cities = new string[5];
            //cities[0] = "Milano";
            //cities[1] = "Budapeşte";
            //cities[2] = "Lyon";
            //cities[3] = "Kahire";
            //cities[4] = "Üsküp";
            //Console.WriteLine(cities[5]);

            //int[] numbers = new int[10];
            //numbers[0] = 1;
            //numbers[1] = 2;
            //numbers[2] = 3;
            //numbers[3] = 4;
            //numbers[4] = 5;
            //numbers[5] = 6;
            //numbers[6] = 7;
            //numbers[7] = 8;
            //numbers[8] = 9;
            //numbers[9] = 10;
            //Console.WriteLine(numbers[5]);

            //String[] cities = { "prag", "roma", "atina", "ankara" };
            //Console.WriteLine(cities[0]);
            //Console.WriteLine(cities[1]);
            //Console.WriteLine(cities[2]);
            //Console.WriteLine(cities[3]);




            #endregion

            #region Dizideki Tüm Elemanları Listele
            //string[] colors = { "sarı", "kırmızı", "beyaz", "yeşil", "turuncu", "pembe" };
            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}
            //int[] number = { 4, 85, 96, 74, 125, 635, 488, 520, 7456, 2365, 1120 };

            //for (int i = 0; i < number.Length; i++)
            //{
            //    if (number[i] % 3 == 0)
            //    {
            //        Console.WriteLine(number[i]);
            //    }
            //}


            //char[] symbols = { 'a', 'b', 'c' };

            // dizideki en büyük elemanı bulan !
            //int[] myArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            //int maxNumber = myArray[0];
            //for (int i = 0; i < myArray.Length ; i++) {

            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }

            //}
            //Console.WriteLine(maxNumber);

            //            string[] person = { "ali", "ayşe ", "buse", "ezgi " }
            //;
            //            Console.WriteLine(person.Length);

            //            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };
            //           Array.Sort(numbers);
            //            for (int i = 0; i < numbers.Length; i++)
            //            {
            //                Console.WriteLine(numbers[i]);
            //            }
            // reverse tersten sıralar



            #endregion

            #region dizi metotları 
            //string[] customers = { "ali", "buse", "ayşe" };
            //int index = Array.IndexOf(customers, "buse");
            //Console.WriteLine(index);

            #endregion
            Console.Read();
        }
    }
}
