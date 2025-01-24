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
            #region For Döngüsü

            //For(x;y;z)
            //x:başlangıç
            //y:bitiş
            //z:artış-azalış


            //ÖRNEK----------------------------->

            //int i;

            //for (i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("CSharp Eğitim Kampı");
            //}


            //ÖRNEK----------------------------->

            //for (int i = 1; i <= 20; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //ÖRNEK----------------------------->

            //for (int i = 3; i <= 50; i += 3)
            //{
            //    Console.WriteLine(i);
            //}

            //ÖRNEK----------------------------->

            //Console.Write("Lütfen ekrana yazılmasını istediğiniz adedi giriniz: ");
            //int finishValue = int.Parse(Console.ReadLine());

            //for(int i = 1; i <= finishValue; i++)
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet");
            //}

            #endregion

            #region For Döngüsü ile Karar Yapıları

            //ÖRNEK----------------------------->

            //for(int i = 1 ; i <= 100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            //ÖRNEK----------------------------->

            //int totalValue = 0;
            //for(int i = 1; i <= 10; i++)
            //{
            //    totalValue += i;
            //}

            //Console.WriteLine(totalValue);

            //ÖRNEK----------------------------->

            //int totalValue = 0;
            //for (int i = 0;i < 20;i++)
            //{
            //    if(i % 2 == 0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine(i);
            //    }
            //}

            //Console.WriteLine("-----------------");
            //Console.WriteLine(totalValue);

            //ÖRNEK----------------------------->

            //int count = 0;
            //for(int i = 1; i <= 60; i++)
            //{
            //    if(i % 7 == 0)
            //    {
            //        count++;
            //    }
            //}

            //Console.WriteLine(count);

            //ÖRNEK----------------------------->

            //1-2-4-8-16...

            //int bakterium = 1;

            //for(int i = 1; i <= 24; i++)
            //{
            //    bakterium *= 2;
            //    Console.WriteLine(i + ".Saatin Sonunda " + bakterium);
            //}

            #endregion

            #region While Döngüsü

            //ÖRNEK----------------------------->


            //While(şart)
            //{
            //işlemler
            //}

            //int i = 1;

            //while (i <= 10)
            //{
            //    Console.WriteLine("merhaba döngüler");
            //    i++;
            //}

            //ÖRNEK----------------------------->


            //int i = 1;

            //while (i <= 10)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            //ÖRNEK----------------------------->

            //int i = 1;
            //int sum = 0;

            //while (i <= 10)
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine(sum);


            #endregion

            #region Örnek Sınav Sorusu

            //Klavyeden girilen 3 basamaklı sayının basamakları toplamını hesaplayan kodu yazınız.
            //456


            //Console.Write("Sayıyı Giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //int ones, tens, hundreds;
            //int sum;

            //ones = number % 10;
            //tens = (number % 100) / 10;
            //hundreds = number / 100; //4.56 --> 4


            //Console.WriteLine(ones + "-" +tens + "-" + hundreds);
            //sum = ones + tens + hundreds;
            //Console.WriteLine("Toplam: "+sum);
            #endregion


            Console.Read();
        }
    }
}
