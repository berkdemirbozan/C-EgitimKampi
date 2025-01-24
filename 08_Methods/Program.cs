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

            //()
            //Geriye Değer Döndürmeyen Metotlar
            //Customer--> Listle,ekle,sil,güncelle

            void CustomerList()
            {
                Console.WriteLine("Ali Yıldız");
                Console.WriteLine("Ayşe Yıldız");
                Console.WriteLine("Merve Çınar");
                Console.WriteLine("Hakan Öztürk");
            }

            CustomerList();
            CustomerList();
            CustomerList();
            CustomerList();

            void Sum()
            {
                int x = 1;
                int y = 2;
                int z = x + y;
                Console.WriteLine(z);
            }
            Sum();


            #endregion

            #region Geriye Değer Döndürmeyen String Parametreli Metotlar

            void WriteMethod(string CustomerName)
            {
                Console.WriteLine(CustomerName);
            }

            WriteMethod("Mehmet Yıldırım");


            void CustomerCard(string name, string surName)
            {
                Console.WriteLine("Müşteri: " + name + " " + surName);
            }

            CustomerCard("Berk", "Demirbozan");
            CustomerCard("Ayşe", "Kaya");
            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli Metotlar

            void Sum(int number1, int number2, int number3)
            {
                int result = number1 + number2 + number3;
                Console.WriteLine(result);
            }

            Sum(4, 5, 6);

            #endregion

            #region Geriye Değer Döndüren Metotlar

            string CustomerName()
            {
                return "Buse Yıldız";
            }

            CustomerName();


            string StudentCard()
            {
                string name = "Ali";
                string surname = "Çınar";

                return name + " " + surname;
            }
            Console.WriteLine(StudentCard());

            #endregion

            #region Geriye Değer Döndüren String Parametreli Metotlar

            string CountryCard(string countryName, string capital, string flagColor)
            {
                string cardInfo = "Ülke: " + countryName + " - Başkent: " + capital + " - Bayrak Rengi: " + flagColor;
                return cardInfo;
            }

            string x, y, z;
            Console.Write("Ülke Adını Giriniz: ");
            x = Console.ReadLine();

            Console.Write("Başkent Giriniz: ");
            y = Console.ReadLine();

            Console.Write("Bayrak Rengi Giriniz: ");
            z = Console.ReadLine();

            Console.WriteLine(CountryCard(x, y, z));

            #endregion

            #region Geriye Değer Döndüren Int Parametreli Metotlar


            int Sum(int number1, int number2)
            {
                int result = number1 + number2;
                return result;
            }
            Console.WriteLine(Sum(45, 68));
            Console.WriteLine(Sum(12, 89));
            Console.WriteLine(Sum(7, 32));
            Console.WriteLine(Sum(456, 123));



            #endregion

            #region Örnek Uygulama

            string ExamResult(string student, int exam1, int exam2, int exam3)
            {
                int result = (exam1 + exam2 + exam3) / 3;
                if (result >= 50)
                {
                    return student + " isimli öğrenci sınavı geçti " + " Ortalama: " + result;
                }
                else
                {
                    return student + " isimli öğrenci sınavı geçemedi " + " Ortalama: " + result;

                }
            }

            Console.WriteLine(ExamResult("Berk", 45, 68, 12));

            #endregion

            //Console.Read();
        }
    }
}
