using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü
            //string[] cities = { "Milano", "Roma", "Ankara", "Sunderland","Lviv","Moskova" };

            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //}

            //int[] numbers = { 23, 54, 12, 46, 32, 97, 544, 123, 54, 111, 3432 };
            //foreach (int item in numbers)
            //{
            //    Console.WriteLine(item);
            //}    

            //int[] numbers = { 23, 54, 12, 46, 32, 97, 544, 123, 54, 111, 3432 };
            //foreach (int item in numbers)
            //{
            //    if(item % 2 == 0)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}

            //int[] numbers = { 23, 54, 12, 46, 32, 97, 544, 123, 54, 111, 3432 };
            //int sum = 0;
            //foreach (var item in numbers)
            //{
            //    sum += item;

            //}
            //Console.WriteLine(sum);


            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,7,0,8
            //};
            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}

            //string word = "Merhaba";
            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);
            //}
            #endregion

            #region Örnek sınav sistemi uygulaması
            //Console.Write("***** C# eğitim kampı sınav uygulaması *****");
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("------------------------------------------------");
            //Console.Write("Sınıfınızda kaç öğrenci var : ");
            //int studentCount = int.Parse(Console.ReadLine());
            //Console.WriteLine("------------------------------------------------");
            //string[] studentNames = new string[studentCount];
            //double[] studentExamsAvarege = new double[studentCount];
            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.Write($"{i+1}. öğrencinin ismini giriniz : ");
            //    studentNames[i] = Console.ReadLine();
            //    double totalExamResult = 0;

            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"{studentNames[i]} adlı öğrencinin {j+1}. sınav notunu giriniz : ");
            //        double value = double.Parse(Console.ReadLine());
            //        totalExamResult+=value; 
            //    }
            //    Console.WriteLine();
            //    studentExamsAvarege[i] = totalExamResult/3;
            //}
            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.WriteLine("--------------------------------------------------------");
            //    Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması : {studentExamsAvarege[i]}");
            //    if (studentExamsAvarege[i] >= 50)
            //    {
            //        Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi GEÇTİ" );
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten KALDI");
            //    }
            //    Console.WriteLine("--------------------------------------------------------");
            //}

          
            #endregion


            Console.Read();
        }
    }
}
