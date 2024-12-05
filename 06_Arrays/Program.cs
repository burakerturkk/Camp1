using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel dizi örnekleri
            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Sarı";
            //colors[2] = "Beyaz";
            //colors[3] = "Mavi";
            //Console.WriteLine(colors[2]);

            //string[] cities = new string[5];
            //cities[0] = "Milano";
            //cities[1] = "Budapeşte";
            //cities[2] = "Lyon";
            //cities[3] = "Kahire";
            //cities[4] = "New York";
            //Console.WriteLine(cities[4]);

            //int[] numbers = new int[10];
            //numbers[0] = 12;
            //numbers[1] = 86;
            //numbers[2] = 362;
            //numbers[8] = 424;
            //Console.WriteLine(numbers[7]);

            //string[] cities = { "Bursa", "Prag", "Roma", "Atina", "Madrid" };
            //Console.WriteLine(cities[3]);

            #endregion

            #region Dizideki tüm elemanları listeleme
            //string[] colors = { "Sarı", "Beyaz", "Siyah", "Yeşil", "Kırmızı" };
            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 4, 34, 65, 8677, 23, 456, 124, 974, 121, 578, 2568 };
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //char[] symbols = { 'A', '+', '$', '/', 'Z' };
            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            //int[] myArray = { 23, 56, 234, 78643, 123, 65, 2346, 12, 6, };
            //int maxNumber  = myArray[0];
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }

            //}
            //Console.WriteLine(maxNumber);


            #endregion

            #region Dizi Metotları
            //string[] people = { "Ali", "Ahmet", "Can", "Yılmaz", "Buse", "Cenk", "Deniz" };
            //Console.WriteLine(people.Length);

            //int[] numbers = { 45, 85, 132, 52, 12, 79 };
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //int[] numbers = { 45, 85, 132, 52, 12, 79 };
            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //string[] people = { "Ali", "Buse", "Ayşe", "Beyza" };
            //int index = Array.IndexOf(people, "Ayşe");
            //Console.WriteLine(index);

            //int[] numbers = { 1, 12, 233, 44, 566, 621 };
            //Console.WriteLine("Dizinin en büyük elemanı : " + numbers.Max() + " dizinin en küçük elemanı : " + numbers.Min());


            #endregion

            #region Kullanıcıdan değer alma
            //string[] cities = new string[5];
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}. şehri giriniz : ");
            //    cities[i] = Console.ReadLine();

            //}
            //Console.WriteLine();
            //Console.WriteLine("------------------------------------------");
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //int[] numbers = { 10, 20, 30, 40, 50 };
            //int sum = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}

            //Console.WriteLine(sum);

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            //Console.Write("Çift Sayılar : ");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.Write(numbers[i]);
            //    }
            //}
            //Console.WriteLine();
            //Console.Write("Tek sayılar : ");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 != 0)
            //    {
            //        Console.Write(numbers[i]);
            //    }
            //}
            #endregion

            Console.Read();
        }
    }
}
