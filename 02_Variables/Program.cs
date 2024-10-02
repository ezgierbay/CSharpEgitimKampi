using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region doubledeğişknler
            // double number;
            // number = 4.85;
            //  Console.WriteLine(number);


            //Console.WriteLine("***** Fiyat Listesi *****");

            //Console.WriteLine();
            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;
            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;
            //Console.WriteLine("-------Elma Birim Fiyatı:"+ applePrice + "TL");
            //Console.WriteLine("-------Portakal Birim Fiyatı:"+ orangePrice + "TL");
            //Console.WriteLine("-------Çilek Birim Fiyatı:"+ strawberryPrice + "TL");
            //Console.WriteLine("-------Patates Birim Fiyatı:"+ potatoPrice+ "TL");
            //Console.WriteLine("-------Domates Birim Fiyatı:"+ tomatoPrice + "TL");
            //Console.WriteLine();
            //Console.WriteLine();

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;
            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //tomatoGram = 3.745;
            //potatoGram = 4.859;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;

            //Console.WriteLine("Alınan Ürün: Elma" + "Birim Fiyatı: "+
            //    applePrice + "-Gramaj" + appleGram +"Toplam Tutar: " +appleTotalPrice) ;

            //Console.WriteLine("Alınan Ürün: Portakal" + "Birim Fiyatı: " +
            //    orangePrice + "-Gramaj" + orangeGram + "Toplam Tutar: " + orangeTotalPrice);

            //Console.WriteLine("Alınan Ürün:Çilek" + "Birim Fiyatı: " +
            //    strawberryPrice + "-Gramaj" + strawberryGram + "Toplam Tutar:" + strawberryTotalPrice);

            //Console.WriteLine("Alınan Ürün: Domates" + "Birim Fiyatı: " +
            //     tomatoPrice + "-Gramaj" + tomatoGram + "Toplam Tutar:" + tomatoTotalPrice);

            //Console.WriteLine("Alınan Ürün: Patates" + "Birim Fiyatı: " +
            //    potatoPrice + "-Gramaj" + potatoGram + "Toplam Tutar: " + potatoTotalPrice);


            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice +
            //    tomatoTotalPrice + potatoTotalPrice;

            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine( "Alışveriş Toplam Tutar:"+ shoppingTotalPrice + "TL");




            #endregion

            #region chardeğişkenler

            //ABCDEFGH
            //DEF
            //TOPLANTI SAAT 20:00'DE
            //car symbol;
            //ymbol = 'a';
            //nsole.WriteLine(symbol);

            #endregion

            #region KlavyedenVeriGiriş

            //Console.WriteLine(" Charp Hava Yolları Yolcu Bilgi");
            //Console.WriteLine();
            //string passengerName, passengerSurname, passengerDistrict, passengerCity,
            //    passengerAge,Identitynumber;


            //Console.Write("Yolcu Adı: ");
            //passengerName= Console.ReadLine();
            //Console.Write("Yolcu Soyadı :");
            //passengerSurname = Console.ReadLine();
            //Console.Write("İlçe Bilgisi");
            //passengerDistrict = Console.ReadLine();
            //Console.Write("Şehir Bilgisi: ");
            //passengerCity = Console.ReadLine();
            //Console.Write("Yolcu Yaş: ");
            //passengerAge = Console.ReadLine();
            //Console.Write("TC Kimlik No: ");
            //Identitynumber  = Console.ReadLine();
            //Console.WriteLine();

            //Console.WriteLine("----------------");
            //Console.WriteLine("Yolcu : " + passengerName + " " + passengerSurname + " " + passengerDistrict
            //    + "/" + passengerCity +" " +passengerAge);







            #endregion


            #region klavyeden Tam Sayı Girişleri ve Dönüşümler
            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 211000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;
            //Console.Write("lütfen aldığınız ayakkabı sayısını giriniz:");
            //shoesCount = int.Parse(Console.ReadLine());
            //Console.Write("lütfen aldığınız bilgisayar sayısını giriniz:");
            //computerCount = int.Parse(Console.ReadLine());
            //Console.Write("lütfen aldığınız sandalye sayısını giriniz:");
            //chairCount = int.Parse(Console.ReadLine());
            //Console.Write("lütfen aldığınız televizyon sayısını giriniz:");
            //tvCount = int.Parse(Console.ReadLine());


            //int totalPrice = shoesCount*shoesPrice+computerCount*computerPrice+chairCount*tvPrice;
            //Console.WriteLine();
            //Console.WriteLine("toplam ücret: "+ totalPrice + "TL");

            #endregion

            #region Klaveyeden Ondalıklı Sayı İşlemleri
            //double exam1, exam2, exam3, result;
            //Console.Write("Lütfen birinci sınav notunu giriniz : ");
            //exam1= double.Parse(Console.ReadLine());
            //Console.Write("Lütfen 2.sınva notunu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());
            //Console.Write("Lütfen 3. sınav notunu giriniz: ");
            //exam3= double.Parse(Console.ReadLine());
            //result = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sonuç " + result);

            // virgülle yazcan ekrandan
            //koda yazarken nokta unutma !!

            #endregion


            #region Klavyeden karakter girişleri
            char gender;
            Console.Write("Lütfen cinsiyet seçiniz : ");
            gender = char.Parse(Console.ReadLine());

            Console.WriteLine("Seçtiğiniz Cinsiyet : " + gender);

            #endregion

            Console.Read();
        }
    }
}
