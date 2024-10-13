﻿using System;
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

            #region For Döngüsü

            //int i;

            //for(i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("C# Eğitim Kampı");
            //}

            //for (int i = 0; i <= 20; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 3; i <= 50; i += 3)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Write("Lütfen ekrana yazaılmasını istedğiniz adedi giriniz: ");
            //int finishValue = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= finishValue; i++)
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet");
            //}


            #endregion

            #region For Döngüsü ile Karar Yapıları

            //for (int i = 0; i<= 100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int totalValue = 0;

            //for (int i = 1; i <= 10; i++)
            //{
            //    totalValue += i;
            //}

            //Console.WriteLine(totalValue);

            //int totalValue = 0;

            //for (int i = 1; i <= 20; i++)
            //{
            //    if (i%2==0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("--------------");
            //Console.WriteLine(totalValue);

            //int count = 0;

            //for (int i = 1; i <= 50; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count + " Tane");

            //her saat başı ikiye katlanan bakteri sayısının 24. saaate kaç tane olduğunu bulma
            //int bacterium = 1;

            //for (int i = 1; i <= 24; i++) 
            //{
            //    bacterium *= 2;
            //    Console.WriteLine(i + ". Saat Sonunda " + bacterium + " bakteri bulunur.");
            //}

            #endregion

            #region While Döngüsü

            //int i = 1;

            //while (i <= 10)
            //{
            //    Console.WriteLine("Merhaba While Döngüsü");
            //    i++;
            //}

            //int i = 1;

            //while (i <= 10)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            //int i = 1, sum = 0;

            //while (i <= 10)
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine(sum);


            #endregion

            #region Örnek Uygulama

            //Klavyeden girilen 3 basamaklı sayının basamakları toplamını hedaplayan kod bloğu

            //Console.Write("Sayıyı Giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //int ones, tens, hundreds, sum;

            //ones = number % 10;
            //tens = (number % 100) / 10;
            //hundreds = (number / 100);

            //Console.WriteLine("Birler basamağı: " + ones + "\n" + "Onlar Basamağı: " + tens + "\n" + "Yüzler Basamağı: " + hundreds);

            //sum = ones + tens + hundreds;

            //Console.WriteLine("Basamaklar toplamı: " + ones + "+"+tens+"+"+hundreds+"="+sum);


            #endregion

            Console.Read();

        }
    }
}