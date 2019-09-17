using DI.EmailSender.Enums;
using DI.EmailSender.Interfaces;

namespace DI.EmailSenderFactory.Interfaces
{
    public interface IEmailSenderFactory
    {
        IEmailSender CreateSender(EmailTarget emailTarget);
    }
}
