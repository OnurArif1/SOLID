using System;

namespace InterfaceSegregationPrinciple
{
    public class Forvet:IFutbolcu,IForvet
    {
        public void PasAt()
        {
            Console.WriteLine("Pas at..");
        }

        public void GolAt()
        {
            Console.WriteLine("Çok güzel gol..");
        }

        public void OrtaAc()
        {
            Console.WriteLine("Orta açtı..");
        }
    }
}