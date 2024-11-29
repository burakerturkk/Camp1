using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakinDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else
            //Console.Write("Lütfen şifreyi giriniz : ");
            //string password = Console.ReadLine();
            //if (password == "1234")
            //{
            //    Console.WriteLine("Şifre doğru.");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}
            //string capital, country;
            //Console.Write("Başkanti giriniz : ");
            //capital = Console.ReadLine();
            //Console.Write("Ülkeyi giriniz : ");
            //country = Console.ReadLine();
            //if(capital == "ankara" & country == "türkiye")
            //{
            //    Console.WriteLine("Veriler doğrulandı.");
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı Bilgi.");
            //}

            //int number;
            //Console.Write("Sayıyı giriniz : ");
            //number = int.Parse(Console.ReadLine());
            //if (number == 5)
            //{
            //    Console.WriteLine("Sayı doğru.");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı yanlış.");
            //}

            //int exam1, exam2, exam3, average;
            //string result;
            //Console.Write("Sınav 1 : ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav 1 : ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav 1 : ");
            //exam3 = int.Parse(Console.ReadLine());
            //average = (exam1 + exam2 + exam3) / 3;
            //Console.Write("Sınavların ortalaması : " + average);
            //if (average > 0 & average <= 50)
            //{
            //    result = "Sonuç vasat.";
            //}
            //else if (average > 50 & average <= 70)
            //{
            //    result = "Sonuç orta.";
            //}
            //else if (average > 70 & average <= 84)
            //{
            //    result = "Sonuç iyi.";
            //}
            //else if (average > 85 & average <= 100)
            //{
            //    result = "Sonuç çok iyi.";
            //}
            //else
            //{
            //    result = "Sonuç geçersiz.";
            //}
            //Console.WriteLine();
            //Console.WriteLine(result);


            //string city;
            //Console.Write("Şehir giriniz : ");
            //city = Console.ReadLine();
            //if(city == "Bursa" || city== "Ankara")
            //{
            //    Console.WriteLine("Şehir doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir yanlış.");
            //}

            //Console.Write("Kullanıcı adını giriniz : ");
            //string userName = Console.ReadLine();
            //if (userName != "Burak")
            //{
            //    Console.WriteLine("Kullanıcı hatalı.");
            //}
            //else
            //{
            //    Console.WriteLine("Hoş geldiniz.");
            //}
            #endregion

            #region Mod
            //int number;
            //number = 29;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("Lütfen birinci sayıyı giriniz : ");
            //int number1 = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen ikinci sayıyı giriniz : ");
            //int number2 = int.Parse(Console.ReadLine());
            //int result = number1 % number2;
            //Console.Write("Birinci sayının, ikinci sayıya bölümünden kalan : " + result);

            //int number;
            //Console.Write("Bir sayı giriniz : ");
            //number = int.Parse(Console.ReadLine());
            //if(number % 2 == 0)
            //{
            //    Console.WriteLine("Sayı çifttir.");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı tektir.");
            //}












            #endregion

            #region Char
            //char team;
            //Console.Write("Takım sembolü giriniz : ");
            //team = char.Parse(Console.ReadLine());
            //if(team == 'b' | team == 'B')
            //{
            //    Console.WriteLine("Beşiktaş");
            //}
            //else if (team == 'g' | team == 'G')
            //{
            //    Console.WriteLine("Galatasaray");
            //}
            //else if (team == 'f' | team == 'F')
            //{
            //    Console.WriteLine("Fenerbahçe");
            //}
            #endregion

            #region Örnek Proje Uygulaması
            //Console.WriteLine("*****Restoran******");
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------------------");
            //Console.WriteLine("1- Ana yemekler");
            //Console.WriteLine("2- Pizzalar");
            //Console.WriteLine("3- Çorbalar");
            //Console.WriteLine("4- İçecekler");
            //Console.WriteLine("5- Tatlılar");
            //Console.WriteLine("-----------------------------------------");

            //string menuItem;
            //Console.Write("Detayını görmek istediğiniz menü seçimi : ");
            //menuItem = Console.ReadLine();
            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------------------Ana yemekler----------------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Köri soslu tavuk");
            //    Console.WriteLine("1- Barbekü soslu tavuk");
            //    Console.WriteLine("1- Izgara Köfte");
            //    Console.WriteLine("1- Dana Wrap");
            //    Console.WriteLine("1- Beef Hamburger");
            //    Console.WriteLine("-------------------Ana yemekler----------------------");
            //    Console.WriteLine();
            //}
            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------------------Pizzalar----------------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Margarita");
            //    Console.WriteLine("2- Eti bol");
            //    Console.WriteLine("3- Ton balıklı");
            //    Console.WriteLine("4- Vejeteryan");
            //    Console.WriteLine("-------------------Pizzalar----------------------");
            //    Console.WriteLine();
            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------------------Çorbalar----------------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Margarita");
            //    Console.WriteLine("2- Eti bol");
            //    Console.WriteLine("3- Ton balıklı");
            //    Console.WriteLine("4- Vejeteryan");
            //    Console.WriteLine("-------------------Çorbalar----------------------");
            //    Console.WriteLine();
            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------------------içecekler----------------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Kola");
            //    Console.WriteLine("2- Şalgam");
            //    Console.WriteLine("3- Su");
            //    Console.WriteLine("4- Ayran");
            //    Console.WriteLine("-------------------İçecekler----------------------");
            //    Console.WriteLine();
            //}
            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------------------Tatlılar----------------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Baklava");
            //    Console.WriteLine("2- Sütlaç");
            //    Console.WriteLine("3- Tiramisu");
            //    Console.WriteLine("4- Magnolya");
            //    Console.WriteLine("-------------------Tatlılar----------------------");
            //    Console.WriteLine();
            //}
            #endregion

            #region Switch-Case
            //Console.Write("Kaçıncı ayı görmek istiyorsunuz : ");
            //int monthNumber = int.Parse(Console.ReadLine());
            //switch (monthNumber)
            //{
            //    case 1: Console.WriteLine("Ocak"); break;
            //    case 2: Console.WriteLine("Şubat"); break;
            //    case 3: Console.WriteLine("Mart"); break;
            //    case 4: Console.WriteLine("Nisan"); break;
            //    case 5: Console.WriteLine("Mayıs"); break;
            //    case 6: Console.WriteLine("Haziran"); break;
            //    case 7: Console.WriteLine("Temmuz"); break;
            //    case 8: Console.WriteLine("Ağustos"); break;
            //    case 9: Console.WriteLine("Eylül"); break;
            //    case 10: Console.WriteLine("Ekim"); break;
            //    case 11: Console.WriteLine("Kasım"); break;
            //    case 12: Console.WriteLine("Aralık"); break;
            //    default: Console.WriteLine("Hatalı veri girişi"); break;
            //}
            #endregion

            #region Switch-Case Calculator
            //int number1, number2, result;
            //char symbol;
            //Console.Write("Birinci sayıyı giriniz : ");
            //number1 = int.Parse(Console.ReadLine());
            //Console.Write("İkici sayıyı giriniz : ");
            //number2 = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen yapmak istediğiniz işlemi giriniz : ");
            //symbol = char.Parse(Console.ReadLine());
            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Toplam : " +result);
            //        break;
                    
            //        case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Fark : "+result);
            //        break;

            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Çarpım : " + result);
            //        break;

            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Bölüm : " + result);
            //            break;
            //    default: Console.WriteLine("Geçersiz sembol girdiniz!"); break;
            //}


            #endregion

            Console.Read();
        }
    }
}

