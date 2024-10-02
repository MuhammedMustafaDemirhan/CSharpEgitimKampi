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
            #region Double Değişkenler
            double number = 5;
            Console.WriteLine(number);

            Console.WriteLine("***** Fiyat Listesi *****");
            Console.WriteLine();
            double applePrice = 14.85, orangePrice = 20.95, strawberryPrice = 45, potatoPrice = 9.74, tomatoPrice = 6.88;

            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("----- Elma Birim Fiyatı : " + applePrice + " ₺");
            Console.WriteLine("----- Portakal Birim Fiyatı : " + orangePrice + " ₺");
            Console.WriteLine("----- Çilek Birim Fiyatı : " + strawberryPrice + " ₺");
            Console.WriteLine("----- Patates Birim Fiyatı : " + potatoPrice + " ₺");
            Console.WriteLine("----- Domates Birim Fiyatı : " + tomatoPrice + " ₺");

            Console.WriteLine();
            Console.WriteLine();

            double appleGram = 1.245, orangeGram = 2.650, strawberryGram = 0.750, potatoGram = 4.859, tomatoGram = 3.745;
            double totalApplePrice = appleGram * applePrice;
            double totalOrangePrice = orangeGram * orangePrice;
            double totalStrawberryPrice = strawberryGram * strawberryPrice;
            double totalPotatoPrice = potatoGram * potatoPrice;
            double totalTomatoPrice = tomatoGram * tomatoPrice;

            Console.WriteLine("Alınan Ürün: Elma - " + "Birim Fiyat: " + applePrice + " - Gramaj: " + appleGram + " - Toplam Tutar: " + totalApplePrice);
            Console.WriteLine("Alınan Ürün: Portakal - " + "Birim Fiyat: " + orangePrice + " - Gramaj: " + orangeGram + " - Toplam Tutar: " + totalOrangePrice);
            Console.WriteLine("Alınan Ürün: Çilek - " + "Birim Fiyat: " + strawberryPrice + " - Gramaj: " + strawberryGram + " - Toplam Tutar: " + totalStrawberryPrice);
            Console.WriteLine("Alınan Ürün: Patates - " + "Birim Fiyat: " + potatoPrice + " - Gramaj: " + potatoGram + " - Toplam Tutar: " + totalPotatoPrice);
            Console.WriteLine("Alınan Ürün: Domates - " + "Birim Fiyat: " + tomatoPrice + " - Gramaj: " + tomatoGram + " - Toplam Tutar: " + totalTomatoPrice);

            Console.WriteLine();
            Console.WriteLine();

            double shoppingTotalPrice = totalApplePrice + totalOrangePrice + totalStrawberryPrice + totalTomatoPrice + totalPotatoPrice;
            Console.WriteLine("Alışveriş Toplam Tutar : " + shoppingTotalPrice + " ₺");
            #endregion

            #region Char Değişkenler
            char symbol = 'a';
            Console.WriteLine(symbol);
            #endregion

            #region Klavyeden Veri Giriş - String
            string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;
            Console.Write("Yolcu Adı: ");
            passengerName = Console.ReadLine();
            Console.Write("Yolcu Soyadı: ");
            passengerSurname = Console.ReadLine();
            Console.Write("İlçe Bilgisi: ");
            passengerDistrict = Console.ReadLine();
            Console.Write("Şehir Bilgisi: ");
            passengerCity = Console.ReadLine();
            Console.Write("Yolcu Yaş: ");
            passengerAge = Console.ReadLine();
            Console.Write("Yolcu TC Kimlik No: ");
            passengerIdentityNumber = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Yolcu TC Kimlik No: " + passengerIdentityNumber + " - Yolcu Ad Soyad: " + passengerName + " " + passengerSurname + " " + passengerDistrict + " / " + passengerCity + " " + passengerAge);
            #endregion

            #region Klavyeden Veri Giriş - Int ve Dönüşümler
            int shoesPrice, computerPrice, chairPrice, tvPrice;
            int shoesCount, computerCount, chairCount, tvCount;
            shoesPrice = 1000;
            computerPrice = 20000;
            chairPrice = 5000;
            tvPrice = 12000;
            Console.WriteLine("Lütfen aldığınız ürün adetlerini giriniz:");
            Console.Write("Ayakkabı: ");
            shoesCount = int.Parse(Console.ReadLine());
            Console.Write("Bilgisayar: ");
            computerCount = int.Parse(Console.ReadLine());
            Console.Write("Sandalye: ");
            chairCount = int.Parse(Console.ReadLine());
            Console.Write("Televizyon: ");
            tvCount = int.Parse(Console.ReadLine());
            int totalprice = shoesCount * shoesPrice + computerCount * computerPrice + chairPrice * chairCount + tvPrice + tvCount;
            Console.WriteLine();
            Console.WriteLine("Toplam Ödemeniz Gereken Tutar :" + totalprice);
            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri
            double exam1, exam2, exam3, result;
            Console.Write("1.Sınav Notu: ");
            exam1 = double.Parse(Console.ReadLine());
            Console.Write("2.Sınav Notu: ");
            exam2 = double.Parse(Console.ReadLine());
            Console.Write("3.Sınav Notu: ");
            exam3 = double.Parse(Console.ReadLine());
            result = (exam1 + exam2 + exam3) / 3;
            Console.WriteLine("Ortalama : " + result);
            #endregion

            #region Klavyeden Karakter Girişleri
            char gender;
            Console.Write("Lütfen Cinsiyet Seçiniz : ");
            gender = char.Parse(Console.ReadLine());
            Console.WriteLine("Seçtiğiniz Cinsiyet: " + gender);
            #endregion

            Console.Read();
        }
    }
}
