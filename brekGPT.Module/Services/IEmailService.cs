using brekGPT.Module.BusinessObjects;

namespace brekGPT.Module.Services
{
    public interface IMailService
    {
        Task<bool> SendAsync(MailData mailData, CancellationToken ct);
    }
}
