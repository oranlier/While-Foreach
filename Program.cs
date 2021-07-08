using System;

namespace While_Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            //while
            //1 den baslayarak konsoldan girilen sayıya kadar(sayı dahil) ortalama hesaplayan program
            Console.WriteLine("sayı giriniz");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam =0;
            while (sayac <=sayi)//parantez içindeki ifade true ise dongu devam eder
            {
                toplam +=sayac;
                sayac++;
            }
            double ort=toplam/sayi;
            Console.WriteLine(ort);

            //a dan z ye kadar tüm harfleri konsola yazdırmak
            char character='a';

            while (character<='z')
            {
                Console.WriteLine(character);
                character++;
            }
             Console.WriteLine("************ForEach**************");
             string[] arabalar ={"BMW", "Ford", "Toyota", "Nissan"};

            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
        }
    }
}
