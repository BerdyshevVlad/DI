using DI.EmailSender.Enums;
using DI.EmailSender.Interfaces;
using System;

namespace DI.EmailSender
{
    public class GmailEmailSender : IEmailSender
    {
        public GmailEmailSender(EmailTarget emailTarget)
        {

        }
        public void SendEmail()
        {
            Console.WriteLine("GmailEmailSender works!");
        }
    }
}
