using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingleResponsibility
{
    public class RaporOlustur
    {
        public RaporOlustur(Employee em)
        {
            Console.WriteLine("Çalışan id girin :");
            em.EmployeID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Çalışanın ismini girin :");
            em.EmployeName = Console.ReadLine();
            Console.ReadLine();
        }
    }
}
