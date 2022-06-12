using System;
using System.Collections.Generic;

namespace DependencyInversionPrinciple
{
    public class Sms:IMessage
    {
        public string PhoneNumber { get; set; }
        public string Message { get; set; }
        public void SendMessage()
        {
            System.Console.WriteLine("Yeni sms geldi");
            System.Console.WriteLine("Kime:"+PhoneNumber+"içerik:"+Message);
        }
    }
}