using DI.EmailSender.Enums;
using DI.EmailSenderFactory.Interfaces;
using System;

namespace DI
{
    class Program
    {
        static void Main(string[] args)
        {
            var userChoise = "";
            EmailTarget result= EmailTarget.None;

            Console.WriteLine("Press \"1\" to send \"Gmail\", or press \"2\" to send \"Yahoo\"!");
            userChoise=Console.ReadLine();

            if (userChoise == "1")
            {
                result = EmailTarget.Gmail;
            }
            if (userChoise == "2")
            {
                result = EmailTarget.Yahoo;
            }

            IEmailSenderFactory emailSenderFactory = new EmailSenderFactory.EmailSenderFactory();
            EmailSender.EmailSender emailSender = new EmailSender.EmailSender(emailSenderFactory);
            try
            {
                emailSender.Send(result);
            }
            catch (Exception)
            {
                Console.WriteLine("Incorrect input!");
            }
            

            Console.ReadLine();
        }
    }
}
