using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar
            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Hakan Öztürk");
            //    Console.WriteLine("Merve Candan");
            //}
            //CustomerList();
            //CustomerList();
            //CustomerList();
            //CustomerList();

            //void Sum()
            //{
            //    int x = 12;
            //    int y = 13;
            //    int z = x+ y;
            //    Console.WriteLine(z);
            //}
            //Sum();



            #endregion

            #region Geriye değer döndürmeyen string parametreli metotlar
            //void Write(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}
            //Write("Burak Ertürk");

            //void CustomerCard(string name, string surName)
            //{
            //    Console.WriteLine("Müşteri : " + name +" " + surName);
            //}
            //CustomerCard("Burak","Ertürk");
            //CustomerCard("Özge","Kaya");
            //CustomerCard("Ozan","Demir");


            #endregion

            #region Geriye değer döndürmeyen int parametreli metotlar

            //void Sum(int x, int y, int z)
            //{
            //    int result = x+y+z;
            //    Console.WriteLine("Sonuç : " + result);
            //}
            //Sum(1, 2, 3);   

            #endregion

            #region Geriye değer döndüren metorlar

            //string CustomerName()
            //{
            //    return "Buse Yıldız";
            //}
            //CustomerName();

            //string StudentCard()
            //{
            //    string name = "Burak";
            //    string surName = "Kaya";
            //    return name + " " + surName;
            //}
            //Console.WriteLine(StudentCard());

            #endregion

            #region Geriye değer döndüren string parametreli metotlar
            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = " - Ülke : " + countryName + " - Başkent : " + capital + " - Bayrak rengi : " + flagColor;
            //    return cardInfo;
            //}
            //string x, y, z;
            //Console.Write("Ülke adını giriniz : ");
            //x = Console.ReadLine();
            //Console.Write("Başkenti giriniz : ");
            //y = Console.ReadLine();
            //Console.Write("Bayrak rengini giriniz : ");
            //z = Console.ReadLine();
            //Console.WriteLine(CountryCard(x,y,z));


            #endregion

            #region Geriye değer döndüren int parametreli metotlar

            //int Sum(int number1, int number2, int number3)
            //{
            //    int result = number1 + number2+number3;
            //    return result;
            //}
            //Console.WriteLine(Sum(1,2,3));
            //Console.WriteLine(Sum(12,22,13));
            //Console.WriteLine(Sum(71,42,43));
            //Console.WriteLine(Sum(32,52,68));

            #endregion

            #region Örnek Uygulama
            //string ExamResult(string student, int exam1, int exam2, int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) / 3;
            //    if (result >= 50)
            //    {
            //        return result + " notu ile " + student + " isimli öğrenci sınavı geçti.";
            //    }
            //    else
            //    {
            //        return result + " notu ile " + student + " isimli öğrenci sınavdan kaldı.";
            //    }
            //}

            //Console.WriteLine(ExamResult("Burak Ertürk", 44, 33, 77));
            #endregion

            Console.Read();
        }

    }
}
