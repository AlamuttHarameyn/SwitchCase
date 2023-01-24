using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._15_SwitchCaseYapisi
{
    class Program
    {
        //Programcılıkta yaygın olarak kullanılan koşul 
        //ifadelerinden biri de switch-case deyimleridir.
        //Sadece bir değişkenin durumuna bağlı olarak, o 
        //değişkenin aldığı değere göre tek tek if-else blokları 
        //yazmak yerine switch-case deyimi kullanılması tercih 
        //edilmektedir.Switch-case deyimiyle yapabildiklerimi 
        //aynı şekilde if-else kullanarak da yapabiliriz 
        //fakat, uzun kod satırları yerine düzenli switch-case 
        //blokları kod okunabilirliği için de önemlidir.
        enum Islemler
        {
            Toplama,
            Cikarma,
            Carpma,
            Bolme
        }
        static void Main(string[] args) 
        {
            int A = 10;
            int B = 20;
            Islemler secim = (Islemler)1; //0 sıralı olarak başlamasını sağlar
            //random başlatmak için (new.Random().Next(1,4)); ifadesi kullanılır.

            switch (secim)
            {
                case Islemler.Toplama:
                    Console.WriteLine($"{A}+{B}={A + B}");
                    break;
                case Islemler.Cikarma:
                    Console.WriteLine($"{A}-{B}={A - B}");
                    break;
                case Islemler.Carpma:
                    Console.WriteLine($"{A}*{B}={A * B}");
                    break;
                case Islemler.Bolme:
                    Console.WriteLine($"{A}/{B}={A / B}");
                    break;
                default:
                    Console.WriteLine("\aGeçersiz işlem!");
                    break;
            //Switch -case kullandığımızda da dikkat etmemiz
            //gereken birtakım kurallar vardır.
            //Kontrol alanındaki değerler sabit olmak zorundadır. 
            //Herhangi bir değişkeni burada tanımlayamayız.
            //Belirlediğimiz sabit değerler sayı, karakter, metin olabilir.
            //default ve case ifadelerini istediğimiz sırada yazabiliriz. 
            //Dikkat etmemiz gereken önemli konu aynı case
            //kontrolünü birden fazla yazamayız.
            //default ifadesi eğer yazdığımız case’lerden hiçbiri
            //verdiğimiz ifade ile eşleşmez ise çalışmaktadır. 
            //Eğer ifade yazdığımız case’lerden biriyle eşleşirse default ifadesi çalışmaz.
            //default kontrolünü yazmak zorunda değiliz. Eğer
            //default ifadesi yer almıyorsa hiçbir işlem yapmadan
            //uygulamamız switch bloğundan çıkmaktadır.

            }
            Console.ReadKey();
        }
    }
}