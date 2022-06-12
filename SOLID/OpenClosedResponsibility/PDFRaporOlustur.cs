using System;

namespace PDFRaporOlustur
{
    class PDFRaporOlustur:Rapor
    {
        public override void RaporOlustur(Employe em)
        {
            System.Console.WriteLine("bu metod burada override edildi");
        }
    }
}