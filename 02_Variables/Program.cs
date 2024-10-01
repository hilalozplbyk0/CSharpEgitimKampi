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
            // Konsolun karakter setini UTF-8 olarak ayarlar
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            #region Double Değişkenler

            //double number;

            //number = 4.85;

            //Console.WriteLine(number);

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine(" ----Elma Birim Fiyatı " +applePrice + "\u20BA");
            //Console.WriteLine("----Portakal Birim Fiyatı " +orangePrice + "\u20BA ");
            //Console.WriteLine("----Çilek Birim Fiyatı " +strawberryPrice + "\u20BA ");
            //Console.WriteLine("----Patates Birim Fiyatı " +potatoPrice + "\u20BA ");
            //Console.WriteLine("----Domates Birim Fiyatı " +tomatoPrice + "\u20BA ");

            //Console.WriteLine();
            //Console.WriteLine();

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //Console.WriteLine(" Elmanın Toplam Fiyatı : " + appleTotalPrice + "\u20BA");

            //double orangeTotalPrice = orangeGram * orangePrice;
            //Console.WriteLine(" Portakalın Toplam Fiyatı : " + orangeTotalPrice + "\u20BA");

            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //Console.WriteLine(" Çileğin Toplam Fiyatı : " + strawberryTotalPrice + "\u20BA");

            //double potatoTotalPrice = potatoGram * potatoPrice;
            //Console.WriteLine(" Patatesin Toplam Fiyatı : " + potatoTotalPrice + "\u20BA");

            //double tomatoTotalPrice = tomatoGram * tomatoPrice;
            //Console.WriteLine(" Domatesin Toplam Fiyatı : " + tomatoTotalPrice + "\u20BA");

            //double totalGramaj = appleGram + orangeGram + strawberryGram + potatoGram + tomatoGram;

            //double totalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;

            //Console.WriteLine(" Toplam Gramaj :  " + totalGramaj + " - Toplam Tutar: " + totalPrice + "\u20BA");

            #endregion

            #region Char Değişkenler,

            //char symbol;
            //symbol = 'a';

            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi**** ");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcu Adı : ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı : ");
            //passengerSurname = Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine("----------------");
            //Console.WriteLine("Yolcu : " + passengerName + " " + passengerSurname);

            //Console.Write(" Yolcu Semti :");
            //passengerDistrict = Console.ReadLine();

            //Console.Write(" Yolcu Şehiri : ");
            //passengerCity = Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine("--------------");
            //Console.WriteLine("Yolcunun Adres Bilgisi :" + passengerDistrict + " / " + passengerCity);

            //Console.WriteLine();
            //Console.WriteLine("--------------");

            //Console.Write("Yolcunun Yaşı :");
            //passengerAge = Console.ReadLine();
            //Console.WriteLine("Yolcunun Yaşı :" + passengerAge);

            //Console.WriteLine();
            //Console.WriteLine("--------------");

            //Console.Write("Yolcunun TC Bilgisi : ");
            //passengerIdentityNumber = Console.ReadLine();
            //Console.WriteLine("Yolcunun TC Bilgisi :" + passengerIdentityNumber);

            #endregion

            #region Klavyeden Veri Girişleri Int Değişkenler ve Dönüşümleri

            //int shoePrice, computerPrice, chairPrice, tvPrice;
            //shoePrice = 1000;
            //computerPrice =20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoeCount, computerCount, chairCount, tvCount;

            //Console.Write(" Lütfen aldığınız ayakkabı sayısını giriniz :");
            //shoeCount = int.Parse(Console.ReadLine());

            //Console.Write(" Lütfen aldığınız bilgisayar sayısını giriniz :");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write(" Lütfen aldığınız sandalye sayısını giriniz :");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write(" Lütfen aldığınız tv sayısını giriniz :");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoePrice * shoeCount + computerPrice * computerCount + chairPrice * chairCount + tvPrice * tvCount;

            //Console.WriteLine("Ödemeniz gereken toplam tutar :" + totalPrice + "\u20BA");

            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1. sınav notunuzu giriniz: ");
            //exam1= double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. sınav notunuzu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3. sınav notunuzu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine();

            //Console.WriteLine("Sınav Ortalamanız : " + result );

            #endregion

            #region Klavyeden Karakter Girişleri

            //char gender;
            //Console.Write(" Lütfen Cinsiyet seçiniz:");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine(" Seçtiğiniz Cinsiyet :" + gender);

            #endregion

            Console.Read();
        }
    }
}
