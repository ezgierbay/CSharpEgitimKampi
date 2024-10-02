using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Yazdırma
            //Console.Write("Merhaba Dünya");
            //Console.WriteLine("selam"); //degeri yazar imleci alt satıra atar.
            //Console.WriteLine("***** Yemek Kategorileri****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("4-Tatlılar");
            //Console.WriteLine("İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri****");
            #endregion
            #region StringDeğişkenler
            //Değişkenler
            //string değişknler
            // degişken türü boşluk adı
            // string name;
            // name = "Ezgi";
            // Console.Write(name);

            //string customerName ;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;
            //customerName = "Ali";
            //customerSurname = "Çınar";
            //customerPhone = "111111";
            //customerEmail = "deneme@gmail.com";
            //district = "Kadıköy";
            //city = "İstanbul";

            //Console.WriteLine("**** Rezervasyon Kartı ****");
            //Console.WriteLine();
            //Console.WriteLine("---------------------------");
            //Console.WriteLine("Müşteri:" + customerName +
            //" " + customerSurname);
            //Console.WriteLine("iletişim"+customerPhone);
            //Console.WriteLine("email"+ customerEmail);
            //Console.WriteLine("adres" + district + "/" + city);
            //Console.WriteLine("---------------------------");
            //Console.WriteLine();
            //customerName = "Ayşegül";
            //customerSurname = "Kaya";
            //customerPhone = "00000";
            //customerEmail = "test@gmail.com";
            //district = "sapanca";
            //city = "sakarya";

            //Console.WriteLine("---------------------------");
            //Console.WriteLine("Müşteri:" + customerName +
            //" " + customerSurname);
            //Console.WriteLine("iletişim" + customerPhone);
            //Console.WriteLine("email" + customerEmail);
            //Console.WriteLine("adres" + district + "/" + city);
            //Console.WriteLine("---------------------------");

            #endregion
            #region intdegişkenler
            // int number = 24;
            //Console.WriteLine(number);  

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("***** Restoran Menü Fiyatı *****");
            Console.WriteLine();
            Console.WriteLine("----Hamburger Fiyatı: " + hamburgerPrice + "TL");
            Console.WriteLine("----Pizza: " + pizzaPrice+ "TL");
            Console.WriteLine("----Kola: " + cokePrice+ "TL");
            Console.WriteLine("----Limonata: " + lemonadePrice+ "TL");
            Console.WriteLine("----Kızartma: " + friesPrice+ "TL");
            Console.WriteLine("----Su: " + waterPrice+ "TL");

            Console.WriteLine("***** Restoran Menü Fiyatı *****");
            Console.WriteLine();

            int hamburgerCount;
            int cokeCount;  
            int waterCount;
            int friesCount; 
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice = 0;
            int totalCokePrice;
            int totalWaterPrice;
            int totalFriesPrice; 
            int totalPizzaPrice;
            int totalLemonadePrice;

            hamburgerCount = 3;
            cokeCount=3;
            waterCount=3;
            friesCount=3;
            pizzaCount=3;
            lemonadeCount=3;
            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice; 
            totalWaterPrice = waterCount * waterPrice;
            totalCokePrice= cokeCount * cokePrice;  
            totalPizzaPrice= pizzaCount * pizzaPrice;
            totalFriesPrice = friesCount * friesPrice;  
            totalLemonadePrice= lemonadeCount * lemonadePrice;  

          
            Console.WriteLine("-------------");
            Console.WriteLine("hamburger tutarı :" +totalHamburgerPrice +"TL");    
            Console.WriteLine("pizza tutarı :" +totalPizzaPrice +"TL");    
            Console.WriteLine("kızartma tutarı: " +totalFriesPrice +"TL");    
            Console.WriteLine("kola: " +totalCokePrice +"TL");   
            Console.WriteLine("limonata: " +totalLemonadePrice +"TL");    
            Console.WriteLine("Su: " +totalWaterPrice +"TL");   

            int totalPrice= totalCokePrice+totalWaterPrice+totalLemonadePrice
            +totalHamburgerPrice + totalFriesPrice + totalPizzaPrice;

            Console.WriteLine("Toplam Ödenecek Tutar: "+ totalPrice + "TL");
           
   
        


            #endregion

            Console.Read(); //entera basana kadar durur.
        }
    }
}
//Yazdırma komutları