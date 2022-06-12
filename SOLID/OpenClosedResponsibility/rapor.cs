using System;

namespace Rapor
{
    abstract class Rapor
    {
        public int RaporID { get; set; }
        public string RaporName { get; set; }
        public abstract void RaporOlustur(Employe em)
        {
            System.Console.WriteLine("RaporId:");
            em.RaporID=ConverttoInt32(Console.Readline());
            System.Console.WriteLine("Raporİsmi:");
            em.RaporName=Console.Readline();
            System.Console.WriteLine("bu metodun orjinal hali");
        }     
    }
}
