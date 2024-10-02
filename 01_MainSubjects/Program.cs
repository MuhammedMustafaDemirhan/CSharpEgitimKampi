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
            #region Yazdırma Komutları
            Console.WriteLine("Hello");
            Console.WriteLine("World");
            Console.WriteLine();
            Console.WriteLine("***** Yemek Kategorileri *****");
            Console.WriteLine();
            Console.WriteLine("1-Çorbalar");
            Console.WriteLine("2-Ana Yemekler");
            Console.WriteLine("3-Soğuk Başlangıçlar");
            Console.WriteLine("4-Salatalar");
            Console.WriteLine("5-Tatlılar");
            Console.WriteLine("6-İçecekler");
            Console.WriteLine();
            Console.WriteLine("***** Yemek Kategorileri *****");
            #endregion

            #region String Değişkenler
            string customerName = "Muhammed Mustafa";
            string customerSurname = "Demirhan";
            string customerPhone = "+90 534 256 90 58";
            string customerEmail = "muhammedmustafademirhan@gmail.com";
            string district = "Bağcılar";
            string city = "İstanbul";

            Console.WriteLine("***** Rezervasyon Kartı *****");
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            Console.WriteLine("İletişim: " + customerPhone);
            Console.WriteLine("Email Adresi: " + customerEmail);
            Console.WriteLine("Adres: " + district + "/" + city);
            Console.WriteLine("-----------------------------------------------");

            customerName = "Bilal";
            customerSurname = "Altunbilek";
            customerPhone = "+90 552 458 98 84";
            customerEmail = "bilalaltnblk@gmail.com";
            district = "Bağcılar";
            city = "İstanbul";

            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            Console.WriteLine("İletişim: " + customerPhone);
            Console.WriteLine("Email Adresi: " + customerEmail);
            Console.WriteLine("Adres: " + district + "/" + city);
            Console.WriteLine("-----------------------------------------------");
            #endregion

            #region Int Değişkenler
            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("***** Restoran Menü Fiyatı *****");
            Console.WriteLine();
            Console.WriteLine("-----Hamburger: " + hamburgerPrice + " TL");
            Console.WriteLine("-----Pizza: " + pizzaPrice + " TL");
            Console.WriteLine("-----Kola: " + cokePrice + " TL");
            Console.WriteLine("-----Limonata: " + lemonadePrice + " TL");
            Console.WriteLine("-----Kızartma: " + friesPrice + " TL");
            Console.WriteLine("-----Su: " + waterPrice + " TL");
            Console.WriteLine();
            Console.WriteLine("***** Restoran Menü Fiyatı *****");

            Console.WriteLine();
            int hamburgerCount = 3;
            int cokeCount = 3;
            int waterCount = 3;
            int friesCount = 1;
            int pizzaCount = 0;
            int lemonadeCount = 0;

            int totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            int totalCokePrice = cokeCount * cokePrice;
            int totalWaterPrice = waterCount * waterPrice;
            int totalFriesPrice = friesCount * friesPrice;
            int totalPizzaPrice = pizzaCount * pizzaPrice;
            int totalLemonadePrice = lemonadeCount * lemonadePrice;

            int totalPrice = totalHamburgerPrice + totalCokePrice + totalWaterPrice + totalFriesPrice + totalPizzaPrice + totalLemonadePrice;

            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Hamburger Tutarı: " + totalHamburgerPrice + " TL");
            Console.WriteLine("Kola Tutarı: " + totalCokePrice + " TL");
            Console.WriteLine("Su Tutarı: " + totalWaterPrice + " TL");
            Console.WriteLine("Kızartma Tutarı: " + totalFriesPrice + " TL");
            Console.WriteLine("Pizza Tutarı: " + totalPizzaPrice + " TL");
            Console.WriteLine("Limonata Tutarı: " + totalLemonadePrice + " TL");

            Console.WriteLine();

            Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice + " TL");


            #endregion

            Console.Read();
        }
    }
}
