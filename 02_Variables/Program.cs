using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            #region Double Değişkenler

            //double number;

            //number = 4.85;

            //Console.WriteLine(number);

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 21.95;
            //strawberryPrice = 65;
            //potatoPrice = 9.74;
            //tomatoPrice = 7.88;

            //Console.WriteLine("----> Elma Birim Fiyatı:" + applePrice + " ₺");
            //Console.WriteLine("----> Portakal Birim Fiyatı:" + orangePrice + " ₺");
            //Console.WriteLine("----> Çilek Birim Fiyatı:" + strawberryPrice + " ₺");
            //Console.WriteLine("----> Patates Birim Fiyatı:" + potatoPrice + " ₺");
            //Console.WriteLine("----> Domates Birim Fiyatı:" + tomatoPrice + " ₺");

            //Console.WriteLine();
            //Console.WriteLine();

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.645;
            //tomatoGram = 3.724;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;

            //Console.WriteLine("Alınan Ürün : Elma     -> " + "Birim Fiyatı: " + applePrice + " ₺    -> Gramaj: " + appleGram + " KG --> Toplam Elma Tutarı: " + appleTotalPrice + " ₺");
            //Console.WriteLine("Alınan Ürün : Portakal -> " + "Birim Fiyatı: " + orangePrice + " ₺    -> Gramaj: " + orangeGram + " KG  --> Toplam Portakal Tutarı: " + orangeTotalPrice + " ₺");
            //Console.WriteLine("Alınan Ürün : Çilek    -> " + "Birim Fiyatı: " + strawberryPrice + " ₺       -> Gramaj: " + strawberryGram + " KG  --> Toplam Çilek Tutarı: " + strawberryTotalPrice + " ₺");
            //Console.WriteLine("Alınan Ürün : Patates  -> " + "Birim Fiyatı: " + potatoPrice + " ₺     -> Gramaj: " + potatoGram + " KG --> Toplam Patates Tutarı: " + potatoTotalPrice + " ₺");
            //Console.WriteLine("Alınan Ürün : Domates  -> " + "Birim Fiyatı: " + tomatoPrice + " ₺     -> Gramaj: " + tomatoGram + " KG --> Toplam Domates Tutarı: " + tomatoTotalPrice + " ₺");

            //Console.WriteLine();

            //double totalShoppingPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;

            //Console.WriteLine("Toplam AlışVeriş Tutarı: " + totalShoppingPrice + " ₺");


            #endregion

            #region Char Değişkenler

            //ABCDEFGH
            //DEF....
            //TOPLANTI SAAT 20:00'DE

            //char symbol;
            //symbol = 'a';

            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Veri Girişleri

            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi ****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerIdentityNumber, passengerAge, passengerCity, passengerDistrict;

            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("Yolcu TC Kimlik Numarası: ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.Write("Yolcu Yaşı: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();


            //Console.WriteLine();

            //Console.WriteLine("----------------");
            //Console.WriteLine("Yolcu Adı Soyadı: " + passengerName + " " + passengerSurname + " - " + "Yolcu TC Kimlik No: " + passengerIdentityNumber + " - " + "Yolcu Yaşı: " + passengerAge + " - " + "Yolcu İl/İlçe Bilgisi: " + passengerCity + "/" + passengerDistrict);


            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            ////ABC12D 

            ////Ürünlerimizi Integer Değişken Olarak Tanımladık.
            //int shoesPrice, computerPrice, chairPrice, tvPrice;

            ////Değişkenlerimize atadık.
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            ////Kaç adet ürün aldığımızı bulabilmek için count yani sayı girişi alacağız son kullanıcıdan.
            //int shoesCount, computerCount, chairCount, tvCount;

            ////Integer olan bir değişkene string değer yazmak istediğimiz için girilen verileri int.Parse komutu ile parse ettik.
            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız televizyon sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());


            //int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + chairCount * chairPrice + tvCount * tvPrice;

            //Console.WriteLine();
            //Console.WriteLine("Ödemeniz gereken toplam tutar: " + totalPrice + " ₺");




            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1. sınav notunuzu giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. sınav notunuzu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3. sınav notunuzu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Sınav Notlarınızın Ortalaması: " + result);



            #endregion

            #region Klavyeden Karakter Girişleri

            //char gender;
            //Console.Write("Lütfen Cinsiyet Seçiniz: ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz Cinsiyet: " + gender);



            #endregion



            Console.Read();
        }
    }
}
