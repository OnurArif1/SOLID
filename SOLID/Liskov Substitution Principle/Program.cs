using System;

namespace Liskov_Substitution_Principle
{
    class Program
    {//Kalıtım alınan class’ın içindeki özellikler kalıtımı alan class ta kullanılmalıdır.
        static void Main(string[] args)
        {
            var tavuk=new Tavuk();
            System.Console.WriteLine("tavuk ,");
            tavuk.Yuru();
            var guvercin=new Guvercin();
            System.Console.WriteLine("güvercin ,");
            guvercin.Yuru();
            System.Console.WriteLine("güvercin ,");
            guvercin.Uc();
        }
    }
}
