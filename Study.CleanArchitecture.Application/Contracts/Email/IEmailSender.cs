using Study.CleanArchitecture.Application.Models.Email;

namespace Study.CleanArchitecture.Application.Contracts.Email;

public interface IEmailSender
{
    Task<bool> SendEmail(EmailMessage email);
}