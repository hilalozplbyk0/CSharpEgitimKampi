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
            #region YazdırmaKomutları

            //Console.Write(" Merhaba Dünya");

            //Console.WriteLine(" Selam ");
            //Console.Write("erhtoıwhrotıhowır");

            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1 - Çorbalar");
            //Console.WriteLine("2- Ana Yemekler");
            //Console.WriteLine("3 - Soğuk Başlangıçlar");
            //Console.WriteLine("4 - Salatalar");
            //Console.WriteLine("5 - Tatlılar");
            //Console.WriteLine("6- İçecekler");
            //Console.WriteLine();        
            //Console.WriteLine("***** Yemek Kategorileri *****");

            #endregion
            #region String Değişkenler

            //string
            //Değişken_türü değişken_adı;

            //string name;
            //name = " Hilal";
            //Console.WriteLine(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = " Hilal"; 
            //customerSurname = "ÖZPALABIYIK";
            //customerPhone = " 0536 028 25 95 ";
            //customerEmail = " hilalozplbyk0@gmail.com";
            //district = "Banazı ";
            //city = " Malatya";

            //Console.WriteLine(" * Rezarasyon Kartı *");
            //Console.WriteLine();
            //Console.WriteLine(" ----------------------- ");
            //Console.WriteLine(" Müşteri : " + customerName  +  " "  + customerSurname);
            //Console.WriteLine("İletişim:" + customerPhone);
            //Console.WriteLine("Email Adresi:" + customerEmail);
            //Console.WriteLine("Adres:" + district + " / "+ city);
            //Console.WriteLine(" ------------------------- ");
            //Console.WriteLine();

            //Console.WriteLine();

            //customerName = "Ayşegül";
            //customerSurname = "Kaya";
            //customerPhone = " 0505 456 76 23";
            //customerEmail = "test@gmail.com";
            //district = "Sapanca";
            //city = "Sakarya";


            //Console.WriteLine(" ----------------------- ");
            //Console.WriteLine(" Müşteri : " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim:" + customerPhone);
            //Console.WriteLine("Email Adresi:" + customerEmail);
            //Console.WriteLine("Adres:" + district + " / " + city);
            //Console.WriteLine(" ------------------------- ");
            //Console.WriteLine();


















            #endregion

            #region Int Değişkenler

            //int
            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("**** Restoran Memü Fiyatı ****");
            Console.WriteLine();
            Console.WriteLine("--- Hamburger Fiyatı:" + hamburgerPrice  + "TL" );
            Console.WriteLine("--- Kola Fiyatı:" + cokePrice +  "TL");
            Console.WriteLine("--- Su Fiyatı:" + waterPrice + "TL");
            Console.WriteLine("---  Kızartma Fiyatı:" + friesPrice + "TL");
            Console.WriteLine("--- Pizza Fiyatı:" + pizzaPrice +  "TL");
            Console.WriteLine("--- Limonota Fiyatı:" + lemonadePrice +  "TL");

            Console.WriteLine();
            Console.WriteLine("**** Restoran Memü Fiyatı ****");
            
            Console.WriteLine();
            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount; 
            int pizzaCount;
            int lemonCount;

            int totalPrice = 0;

            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonCount = 0;

            totalPrice = hamburgerCount * hamburgerPrice + cokeCount * cokePrice + waterCount * waterPrice + friesCount * friesPrice + pizzaCount * pizzaPrice + lemonCount * lemonadePrice;

            Console.WriteLine(" Toplam Ücret :" + totalPrice + " TL "); 


            #endregion


            Console.Read();
        }
    }
}


// Hilal ÖZPALABIYIK 

 