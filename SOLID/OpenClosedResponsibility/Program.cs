using System;

namespace OpenClosedResponsibility
{
    class Program
    {//Open Closed Principle:Bu prensibe göre classlar gelişime açık, değişime kapalı olmalıdır. 
        static void Main(string[] args)
        {
            var employe=new Employe();
            var rapor=new Rapor();
            var pdfRaporOlustur=new PDFRaporOlustur();
            var crystalReportOlustur=new CrystalReportOlustur();
            rapor.RaporOlustur(employe);
            pdfRaporOlustur.RaporOlustur(employe);
            crystalReportOlustur.RaporOlustur(employe);
        }
    }
}
