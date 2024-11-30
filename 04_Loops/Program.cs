using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Loop
            //int i;
            //for (i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("C# Eğitim Kampı");
            //}

            //for (int i = 0; i <= 20; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 3; i < 51; i+=3)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Write("Lütfen ekrana yazılmasını istediğiniz adedi giriniz : ");
            //int finishValue = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= finishValue; i++)
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet");
            //}



            #endregion

            #region Making Decision with For Loop
            //for (int i = 1; i < 101; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }

            //}

            //int totalValue = 0;
            //for (int i = 1; i < 11; i++)
            //{
            //    totalValue = totalValue + i;
            //}
            //Console.WriteLine(totalValue);

            //int totalValue = 0;
            //for (int i = 0; i < 21; i+=2)
            //{
            //    totalValue = totalValue + i;
            //}
            //Console.WriteLine(totalValue);

            //int count = 0;
            //for (int i = 1; i < 51; i++)
            //{
            //    if(i%7 == 0)
            //    {
            //      count++;
            //    }
            //}
            //Console.WriteLine(count);

            #endregion

            #region Bacterium
            //int bacterium = 1;
            //for (int i = 1; i < 25; i++)
            //{
            //    bacterium *= 2;
            //    Console.WriteLine(i + ". saat sonunda : " + bacterium);
            //}

            #endregion

            #region While Loop
            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine("Merhaba döngüler");
            //    i++;    
            //}

            //int number = 1;
            //while (number < 11)
            //{
            //    if(number % 3 == 0)
            //    {
            //        Console.WriteLine(number); 
            //    }
            //    number++;
            //}

            //int i = 1;
            //int j = 0;
            //while (i<11)
            //{
            //    j = j + i;
            //    i++;
            //}
            //Console.WriteLine(j);
            #endregion

            #region Exam Question Sample
            //Klavyeden girilen 3 basamaklı sayının basamakları toplamını hesaplayan programı yazınız.

            //Console.Write("Sayıyı giriniz : ");
            //int number = int.Parse(Console.ReadLine());
            //int onces, tens, hundreds;
            //int sum;
            //onces = number % 10;
            //tens = number / 10;
            //tens=tens % 10;
            //hundreds = number / 100;
            //Console.WriteLine(onces);
            //Console.WriteLine(tens);
            //Console.WriteLine(hundreds);
            //sum = onces + tens + hundreds;
            //Console.WriteLine("Girilen sayıların basamaklarının toplamı : " + sum);
            #endregion

            Console.Read();
        }

    }
}
