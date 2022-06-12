using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingleResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            var employe = new Employee();
            var raporOlustur = new RaporOlustur(employe);


        }
    }
}
