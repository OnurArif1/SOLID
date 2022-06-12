using System;
using System.Collections.Generic;

namespace DependencyInversionPrinciple
{
    public class Email:IMessage
    {
        public string ToAddress { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public void SendMessage()
        {
            System.Console.WriteLine("Yeni mail geldi");
            System.Console.WriteLine("Kime:"+ToAddress+"konu:"+Subject+"içerik:"+Content);
        }
    }
}