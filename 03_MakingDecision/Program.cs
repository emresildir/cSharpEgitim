using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    class Program
    {
        static void Main(string[] args)
        {

            #region If Else

            //Console.Write("Lütfen şifreyi giriniz: ");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Hatalı !");
            //}

            //string capital, country;
            //Console.Write("Başkenti Giriniz: ");
            //country = Console.ReadLine();

            //Console.Write("Ülkeyi Giriniz: ");
            //capital = Console.ReadLine();

            //if (country == "ankara" & capital == "türkiye")
            //{
            //    Console.Write("Veriler Doğrulandı.");
            //}
            //else
            //{
            //    Console.Write("Veriler Hatalı !");
            //}


            //int number;

            //Console.Write("Sayıyı Giriniz: ");
            //number = int.Parse(Console.ReadLine());
            //if (number==5)
            //{
            //    Console.WriteLine("Sayı Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı Hatalı !");
            //}





            //int exam1, exam2, exam3, average;
            //string result = "Hata !";

            //Console.Write("Sınav 1: ");
            //exam1 = int.Parse(Console.ReadLine());

            //Console.Write("Sınav 2: ");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.Write("Sınav 3: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Ortalama Sınav Notunuz: " + average);

            //if(average > 0 & average <= 50)
            //{
            //    result = "Sonuç Vasat";
            //}
            //if (average > 50 & average <= 70)
            //{
            //    result = "Sonuç Orta";
            //}
            //if (average > 70 & average <= 84)
            //{
            //    result = "Sonuç İyi";
            //}
            //if (average > 84)
            //{
            //    result = "Sonuç Çok İyi";
            //}
            //Console.WriteLine(result);





            //string city;
            //Console.Write("Lütfen Şehir Girişi Yapınız: ");
            //city = Console.ReadLine();

            //if(city=="adana" | city == "ankara" | city == "bursa" | city== "amasya" | city == "trabzon")
            //{
            //    Console.WriteLine("Şehir Mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir Mevcut Değil");
            //}




            //Console.Write("Lütfen kullanıcı adınızı giriniz: ");
            //string username = Console.ReadLine();

            //if(username!= "admin")
            //{
            //    Console.WriteLine("Bu kullanıcı adı geçerli değil.");
            //}
            //else
            //{
            //    Console.WriteLine("Hoş Geldiniz :)");
            //}

            #endregion

            #region Mod İşlemleri

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);


            //-----> 1. Sayının 2. Sayıya Bölündüğünde Kalan Değeri

            //Console.Write("Lütfen 1. Sayıyı Giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. Sayıyı Giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;

            //Console.WriteLine("1. Sayının 2. Sayıya Bölümünden Kalan: " + result);


            //-----> Girilen Sayının Çift Tek Olduğunu Bulma

            //Console.Write("Lütfen Sayı Giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.Write("Girdiğiniz Sayı Bir Çift Sayıdır !");
            //}
            //else
            //{
            //    Console.Write("Girdiğiniz Sayı Bir Tek Sayıdır !");
            //}


            #endregion


            #region Char Değişkenler İle Karar Yapıları


            //-----> Takım Sembolü İle Takım Bulma


            //char team;
            //Console.Write("Lütfen Takım Sembolünü Giriniz: ");
            //team = char.Parse(Console.ReadLine());

            //if ( team == 'g' | team == 'G')
            //{
            //    Console.Write("Galatasaray");
            //}
            //if ( team == 'f' | team == 'F')
            //{
            //    Console.Write("Fenerbahçe");
            //}
            //if (team == 'b' | team == 'B')
            //{
            //    Console.Write("Beşiktaş");
            //}

            #endregion


            #region Örnek Proje uygulaması



            //Console.WriteLine("***** C# Eğitim Kampı Restoranı *****");
            //Console.WriteLine();
            //Console.WriteLine("-------------------------------------");
            //Console.WriteLine("1- Ana Yemekler");
            //Console.WriteLine("2- Çorbalar");
            //Console.WriteLine("3- Pizzalar");
            //Console.WriteLine("4- İçecekler");
            //Console.WriteLine("5- Tatlılar");
            //Console.WriteLine("-------------------------------------");
            //Console.WriteLine();
            //string menuItem;

            //Console.WriteLine();


            //Console.Write("Detayını görmek istediğiniz menü seçimi: ");
            //menuItem = Console.ReadLine();

            //if(menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------------------------------- ANA YEMEKLER -------------------------------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Köri Soslu Tavuk");
            //    Console.WriteLine("2- Kızartma Tabağı");
            //    Console.WriteLine("3- Fasulye Tabağı");
            //    Console.WriteLine("4- Fırında Somon");
            //    Console.WriteLine("5- Patlıcan Musakka");
            //    Console.WriteLine();
            //    Console.WriteLine("------------------------------------- ANA YEMEKLER -------------------------------------");

            //}

            //if (menuItem== "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------------------------------- ÇORBALAR -------------------------------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Mercimek Çorbası");
            //    Console.WriteLine("2- Ezogelin Çorbası");
            //    Console.WriteLine("3- Tarhana Çorbası");
            //    Console.WriteLine();
            //    Console.WriteLine("------------------------------------- ÇORBALAR -------------------------------------");
            //}

            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------------------------------- PİZZALAR -------------------------------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Karışık Pizza");
            //    Console.WriteLine("2- Margaratti Pizza");
            //    Console.WriteLine("3- Sucuklu Pizza");
            //    Console.WriteLine();
            //    Console.WriteLine("------------------------------------- PİZZALAR -------------------------------------");
            //}

            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------------------------------- İÇECEKLER -------------------------------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Kutu Kola");
            //    Console.WriteLine("2- Şişe Kola");
            //    Console.WriteLine("3- Ayran");
            //    Console.WriteLine("4- Soda");
            //    Console.WriteLine();
            //    Console.WriteLine("------------------------------------- İÇECEKLER -------------------------------------");
            //}

            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------------------------------- TATLILAR -------------------------------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Trileçe");
            //    Console.WriteLine("2- Kazandibi");
            //    Console.WriteLine("3- Sütlaç");
            //    Console.WriteLine("4- Baklava");
            //    Console.WriteLine();
            //    Console.WriteLine("------------------------------------- TATLILAR -------------------------------------");
            //}








            #endregion

            #region Switch Case

            //Console.Write("Lütfen Ay Girişi Yapınız: ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch(monthNumber)
            //{
            //    case 1:Console.Write("Ocak"); break;
            //    case 2:Console.Write("Şubat"); break;
            //    case 3: Console.Write("Mart"); break;
            //    case 4: Console.Write("Nisan"); break;
            //    case 5: Console.Write("Mayıs"); break;
            //    case 6: Console.Write("Haziran"); break;
            //    case 7: Console.Write("Temmuz"); break;
            //    case 8: Console.Write("Ağustos"); break;
            //    case 9: Console.Write("Eylül"); break;
            //    case 10: Console.Write("Ekim"); break;
            //    case 11: Console.Write("Kasım"); break;
            //    case 12: Console.Write("Aralık"); break;
            //    default: Console.Write("Hatalı Veri Girişi Yaptınız !"); break;
            //}





            #endregion

            #region Switch Case Hesap Makinesi

            //int number1, number2, result;
            //char symbol;

            //Console.Write("1. Sayıyı Giriniz: ");
            //number1 = int.Parse(Console.ReadLine());

            //Console.Write("2. Sayıyı Giriniz: ");
            //number2 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen yapmak istediğiniz işlemi giriniz: ");
            //symbol = char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Toplama İşleminin Sonucu: " + result);
            //        break;

            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Çıkarma İşleminin Sonucu: " + result);
            //        break;

            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Çarpma İşleminin Sonucu: " + result);
            //        break;

            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Bölme İşleminin Sonucu: " + result);
            //        break;

            //}









            #endregion


            Console.Read();

        }











    }
}
