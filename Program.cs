using System;
using System.Collections.Generic;

namespace forLoobBr
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int sayac=1;
            Console.WriteLine("sayi giriniz:");
            int n=Convert.ToInt32(Console.ReadLine());
            int toplam=0;
            while(sayac<=n){

                    toplam+=sayac;
                    sayac++;

            }

            Console.WriteLine("Ortalama:"+(float)((float)toplam/(sayac-1))+"--- toplam:"+toplam);


            string[] renkler={"mavi","kırmızı","beyaz","sarı"};
            int counter=1;
            foreach(var renk in renkler){
                
                Console.WriteLine("renkler:"+renk+" - "+counter+".renk "+renkler.Length+" renkten");
                counter++;
            }
        }
    }
}