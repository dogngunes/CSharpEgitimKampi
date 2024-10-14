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
            #region Temel Dizi Örnekleri

            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Yeşil";
            //colors[2] = "Siyah";
            //colors[3] = "Mavi";

            //Console.WriteLine(colors[2]);

            //string[] cities = new string[5];

            //cities[0] = "İstanbul";
            //cities[1] = "Şanlıurfa";
            //cities[2] = "Giresun";
            //cities[3] = "Gaziantep";
            //cities[4] = "Trabzon";

            //Console.WriteLine(cities[2]);

            //int[] numbers = new int[10];
            //numbers [0] = 1;
            //numbers [1] = 2;
            //numbers[3]= 3;
            //numbers [7] = 4;
            //numbers [9] = 5;

            //Console.WriteLine(numbers[4]);

            //string[] cities = { "Şanlıurfa", "Gaziantep", "Giresun" };

            //Console.WriteLine(cities[2]);

            #endregion

            #region Dizideki Tüm Elemanları Listeleme

            //string[] colors = { "Sarı", "Lacivert", "Yeşil", "Mavi", "Siyah", "Pembe" };

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 4, 85, 96, 75, 125, 635, 488, 522, 7456, 2365, 1120 };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //char[] symbols = { 'd', 'o', 'g', 'a', 'n' };
            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.Write(symbols[i]);
            //}

            //int[] myArray = { 1, 2, 3, 4, 5, 6, 7, 48, 8, 9, 10, 11 };
            //int maxNumber = myArray[0];

            //for (int i = 1; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);

            #endregion

            #region Dizi Metotları

            //Dizi eleman sayısı, uzunluğu için length
            //string[] persons = { "Ali", "Ahmet", "Mehmet"};
            //Console.WriteLine(persons.Length);

            //Sıralama yapan metot sort
            //int[] numbers = { 1, 8, 19, 3, 12, 8, 4, 5 };
            //Array.Sort(numbers);

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //Diziyi tersine çeviren metot Reverse
            //int[] numbers = { 1, 8, 19, 3, 12, 8, 4, 5 };
            //Array.Reverse(numbers);

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //Dizi içindeki aranan değerin index sırasını veren metot IndexOf
            //string[] customers = { "ali", "ahmet", "mehmet", "veli", "merve" };
            //int index = Array.IndexOf(customers, "veli");

            //Console.WriteLine(index);

            //Dizinin en büyük ve en küçük elemanları için max ve min metotları
            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            //Console.WriteLine("Dizinin en büyük elemanı: " + numbers.Max());
            //Console.WriteLine("Dizinin en küçük elemanı: " + numbers.Min());


            #endregion

            #region Kullanıcıdan Dizi İçin Değer Alma

            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}. Şehri Giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}

            //Console.WriteLine();
            //Console.WriteLine("-------------------");

            //for (int i = 0;i < cities.Length;i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            //int sum = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}

            //Console.WriteLine(sum);

            //int[] numbers = { 22, 63, 65, 89, 545, 752, 67, 32, 265 };
            //Console.WriteLine("Çift Sayılar");
            //Console.WriteLine();
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            //Console.WriteLine("-------------------------");
            //Console.WriteLine();

            //Console.WriteLine("Tek Sayılar");
            //Console.WriteLine();
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            #endregion

            Console.Read();
        }
    }
}
