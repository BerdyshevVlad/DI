using DI.EmailSender;
using DI.EmailSender.Enums;
using DI.EmailSender.Interfaces;
using DI.EmailSenderFactory.Interfaces;
using System;

namespace DI.EmailSenderFactory
{
    public class EmailSenderFactory : IEmailSenderFactory
    {
        //simple realization
        public IEmailSender CreateSender(EmailTarget emailTarget)
        {
            switch (emailTarget)
            {
                case EmailTarget.Gmail:
                    return new GmailEmailSender(emailTarget);

                case EmailTarget.Yahoo:
                    return new YahooEmailSender(emailTarget);

                default:
                    throw new InvalidOperationException($"Unknown email target {emailTarget}");
            }
        }


        //private readonly IServiceCollection diContainer;

        //public EmailSenderFactory(IServiceCollection diContainer)
        //{
        //    this.diContainer = diContainer;
        //}

        //public IEmailSender CreateSender(EmailTarget emailTarget)
        //{
        //    switch (emailTarget)
        //    {
        //        case EmailTarget.Gmail:
        //            return diContainer.Resolve<GmailEmailSender>();

        //        case EmailTarget.Yahoo:
        //            return diContainer.Resolve<YahooEmailSender>();

        //        default:
        //            throw new InvalidOperationException($"Unknown email target {emailTarget}");
        //    }
        //}
    }
}
