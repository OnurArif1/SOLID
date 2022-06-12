using System;

namespace InterfaceSegregationPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {//Interface Segregation prensibine göre, “istemcilerin kullanmadıkları arayüzleri uygulamaya zorlanmaması gerektiğini” savunulmaktadır.
            var forvet=new Forvet();
            System.Console.Write("Pas At Metodu(Forvet):");
            forvet.PasAt();
            System.Console.Write("Gol At Metodu(Forvet):");
            forvet.GolAt();
            System.Console.Write("Orta Aç Metodu(Forvet):");
            forvet.OrtaAc();
            var stoper =new Stoper();
            System.Console.Write("Pas At Metodu(Stoper):");
            stoper.PasAt();
            System.Console.Write("Defans Yap Metodu(Stoper):");
            stoper.DefansYap();
            System.Console.Write("Orta Aç Metodu(Stoper):");
            stoper.OrtaAc();
            var kaleci=new Kaleci();
            System.Console.Write("Pas At Metodu(Kaleci):");
            kaleci.PasAt();
            System.Console.Write("OrtOrta Aç Metodu(Kaleci):");
            kaleci.OrtaAc();
            System.Console.Write("Kurtarış Yap Metodu(Kaleci):");
            kaleci.KurtarısYap();
        }
    }
}
