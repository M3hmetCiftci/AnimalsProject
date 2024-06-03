using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanlarAlemi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hayvanalrın eşitliğini bulan örnek");
            Console.WriteLine();
            Console.WriteLine();

            Kedi kdi = new Kedi();
            Console.Write("Kedi sayısı :");
            kdi.hayvansayisi = Convert.ToInt32(Console.ReadLine());
            Console.Write("Hayvan ismi :");
            kdi.hayvanismi = "Kedi , ";
            Console.Write(kdi.hayvanismi);
            Console.Write("Hayvan sesi :");
            kdi.hayvansesi = "Miyav";
            Console.WriteLine(kdi.hayvansesi);

            Console.WriteLine();

            Kopek kpk = new Kopek();
            Console.Write("Köpek sayısı :");
            kpk.hayvansayisi = Convert.ToInt32(Console.ReadLine());
            Console.Write("Hayvan ismi :");
            kpk.hayvanismi = "Köpek , ";
            Console.Write(kpk.hayvanismi);
            Console.Write("Hayvan sesi :");
            kpk.hayvansesi ="Haw";
            Console.WriteLine(kpk.hayvansesi);

            Console.WriteLine();

            Kus ks = new Kus();
            Console.Write("Kuş sayisi :");
            ks.hayvansayisi = Convert.ToInt32(Console.ReadLine());
            Console.Write("Hayvan ismi :");
            ks.hayvanismi = "Kuş , ";
            Console.Write(ks.hayvanismi);
            Console.Write("Hayvan sesi :");
            ks.hayvansesi ="Cik";
            Console.WriteLine(ks.hayvansesi);

            Console.WriteLine();

            if (kdi.hayvansayisi == ks.hayvansayisi && kdi.hayvansayisi == kpk.hayvansayisi && ks.hayvansayisi == kpk.hayvansayisi)
            {
                Console.WriteLine("Hayvan sayıları birbirine eşit");
            }
           else if (kdi.hayvansayisi == ks.hayvansayisi)
            {
                Console.WriteLine("Kedi ve Kuş sayısı eşittir");
            }
            else if (kpk.hayvansayisi == ks.hayvansayisi)
            {
                Console.WriteLine("Köpek ve Kuş sayısı eşittir");
            }
            else if(kdi.hayvansayisi == kpk.hayvansayisi)    
            { 
                Console.WriteLine("Köpek ve kedi birbirine eşit");
            }         
            else { Console.WriteLine("Hayvan sayıları eşit değildir"); }
            Console.WriteLine();

            Console.Write("Lütfen 1 ile 3 arasında bir tecih yapın : ");
          int secim =Convert.ToInt32 (Console.ReadLine());
            switch (secim)
            {
                case 1:
                    Console.WriteLine($"hayvan sayısı : {kdi.hayvansayisi}, hayvan ismi : {kdi.hayvanismi}, hayvan sesi : {kdi.hayvansesi}");
                    break;
                    case 2:
                    Console.WriteLine($"hayvan sayısı : {kpk.hayvansayisi}, hayvan ismi : {kpk.hayvanismi}, hayvan sesi : {kpk.hayvansesi}");
                    break;
                case 3:
                    Console.WriteLine($"hayvan sayısı : {ks.hayvansayisi}, hayvan ismi : {ks.hayvanismi}, hayvan sesi : {ks.hayvansesi}");
                    break;
                default:
                    Console.WriteLine("Yanlış tercih yaptınız");
                    break;
                   
            }
            Console.Read();
        }
        
    }
}
