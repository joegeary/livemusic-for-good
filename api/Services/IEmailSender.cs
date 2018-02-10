using System.Threading.Tasks;

namespace LiveMusicForGood.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string toEmail, string subject, string htmlMessage, string textMessage = null);
    }
}
