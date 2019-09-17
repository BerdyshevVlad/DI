using DI.EmailSender;
using DI.EmailSender.Enums;
using DI.EmailSender.Interfaces;
using DI.EmailSenderFactory.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace DI.Config
{
    public class RegisterDependencies
    {
        ServiceCollection _serviceProvider;
        public RegisterDependencies()
        {
            _serviceProvider = new ServiceCollection();
            _serviceProvider.AddTransient<IEmailSender>(s => new GmailEmailSender(EmailTarget.Gmail))
                .AddTransient<IEmailSender>(s => new YahooEmailSender(EmailTarget.Yahoo))
                .AddTransient<IEmailSenderFactory, EmailSenderFactory.EmailSenderFactory>()
                .BuildServiceProvider();
        }
        
    }
}
