using System;
using System.Collections.Generic;

namespace DependencyInversionPrinciple
{
    public class Whatsapp:IMessage
    {
        public string PhoneNumber { get; set; }
        public string Message { get; set; }
        public char Emoji { get; set; }
        public void SendMessage()
        {
            System.Console.WriteLine("Yeni wp mesajı geldi");
            System.Console.WriteLine("Kime:"+PhoneNumber+"mesaj:"+Message+"emoji:"+Emoji);
        }
    }
}