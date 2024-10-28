﻿using System;
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
            //()
            //Geriye Değer Döndürmeyen Metotlar
            //Customer-->Listele, ekle, sil, güncelle
            //Void

            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Öztürk");
            //    Console.WriteLine("Kimono");
            //}

            //CustomerList();
            //Console.WriteLine("--------------------");
            //CustomerList();
            //Console.WriteLine("--------------------");
            //CustomerList();
            //Console.WriteLine("--------------------");
            //CustomerList();

            //void SumMethods()
            //{
            //    int number1 = 12;
            //    int number2= 26;
            //    int result = number1 + number2;
            //    Console.WriteLine(result);
            //}

            //SumMethods();


            #endregion

            #region Geriye Değer Döndürmeyen Parametreli Metotlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}
            //WriteMethod("Doğan Güneş");

            //void CustomerCard(string name, string surName)
            //{
            //    Console.WriteLine("Müşteri: " + name+ " " + surName);
            //}

            //CustomerCard("Doğan", "GÜNEŞ");
            //CustomerCard("Ali", "Veli");

            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli Metotlar

            //void Sum(int num1, int num2, int num3)
            //{
            //    int result = num1 + num2 + num3;
            //    Console.WriteLine("Sonuç: "+ result);
            //}

            //Sum(26, 42, 65);

            #endregion

            #region Geriye Değer Döndüren Metotlar

            //string CustomerName()
            //{
            //    return "Doğan GÜNEŞ";
            //}

            //CustomerName();

            //string StudentCard()
            //{
            //    string name = "Doğan";
            //    string surname = "GÜNEŞ";

            //    return name + " " + surname;
            //}

            //Console.WriteLine(StudentCard());


            #endregion

            #region Geriye Değer Döndüren String Parametreli Metotlar

            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = "Ülke: " + countryName + "\n" + "Başkent: " + capital + "\n" + "Bayrak Rengi: " + flagColor;
            //    return cardInfo;
            //}

            //string x, y, z;
            //Console.Write("Ülke Adını Giriniz: ");
            //x= Console.ReadLine();
            //Console.Write("Başkenti Giriniz: ");
            //y= Console.ReadLine();
            //Console.Write("Bayrak Rengini Giriniz: ");
            //z= Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));

            //Console.WriteLine(CountryCard("Türkiye", "Ankara", "Kırmızı - Beyaz"));

            #endregion

            #region Geriye Değer Döndüren Int Parametreli Metotlar

            //int Sum(int num1, int num2)
            //{
            //    int result = num1 + num2;
            //    return result;
            //}

            //Console.WriteLine(Sum(26,48));
            //Console.WriteLine(Sum(76,256));
            //Console.WriteLine(Sum(89,34));
            //Console.WriteLine(Sum(73,63));

            #endregion

            #region Örnek Uygulama

            string ExamResult(string student, int exam1, int exam2, int exam3)
            {
                int result = (exam1 + exam2 + exam3) / 3;
                if (result >= 50)
                {
                    return student + " " + result + " puan ile " + "Başarılı oldu.";
                }
                else
                {
                    return student + " " + result + " puan ile " + "Başarısız oldu.";
                }
            }

            Console.WriteLine(ExamResult("Doğan Güneş", 67, 32, 83));
            Console.WriteLine(ExamResult("Ali Veli", 52, 75, 22));

            #endregion

            Console.Read();


        }
    }
}
