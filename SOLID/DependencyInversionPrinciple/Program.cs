using System;
using System.Collections.Generic;
namespace DependencyInversionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {//Bir sınıfın, metodun yada özelliğin, onu kullanan diğer sınıflara karşı olan bağılmılığı en aza indirgenmelidir.
         //alt sınıfta yapılan değişiklikler üst sınıfları etkilememelidir
            var email=new Email();
            email.Content="Bu bir deneme mailidir";
            email.Subject="Test";
            email.ToAddress="deneme@gmail.com";
            email.SendMessage();
            //Bu yukarıdaki örneği diğer sınıflarada uygulayabiliriz
        }
    }
}
