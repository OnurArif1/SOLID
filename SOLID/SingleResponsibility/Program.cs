using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingleResponsibility
{
    class Program
    {//Bir sınıfın sadece bir tane sorumluluğu olması gerekir.Class veya metodun değişmek için bir sebebi olmalı.
        static void Main(string[] args)
        {
            var employe = new Employee();
            var raporOlustur = new RaporOlustur(employe);


        }
    }
}
