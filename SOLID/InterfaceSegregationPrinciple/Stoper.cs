using System;

namespace InterfaceSegregationPrinciple
{
    public class Stoper:IFutbolcu,IStoper
    {
        public void DefansYap()
        {
            Console.WriteLine("Defans yap..");
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