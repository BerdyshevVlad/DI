using DI.EmailSender.Enums;
using DI.EmailSender.Interfaces;
using System;

namespace DI.EmailSender
{
    public class YahooEmailSender : IEmailSender
    {
        public YahooEmailSender(EmailTarget emailTarget)
        {

        }
        public void SendEmail()
        {
            Console.WriteLine("YahooEmailSender works!");
        }
    }
}
