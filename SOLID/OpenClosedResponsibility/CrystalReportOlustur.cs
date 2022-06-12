using System;

namespace CrystalReportOlustur
{
    class CrystalReportOlustur:Rapor
    {
        public override void RaporOlustur(Employe em)
        {
            System.Console.WriteLine("bu metod burada override edildi");
        }
    }
}