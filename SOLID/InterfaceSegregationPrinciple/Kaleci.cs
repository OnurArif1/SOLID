using System;

namespace InterfaceSegregationPrinciple
{
    public class Kaleci:IFutbolcu,IKaleci
    {
        public void KurtarısYap()
        {
            Console.WriteLine("Kurtarıs yap..");
        }

        public void PasAt()
        {
            Console.WriteLine("Pas at..");
        }

        public void OrtaAc()
        {
            Console.WriteLine("Orta açtı..");
        }
    }
}