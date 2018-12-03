using System.Threading.Tasks;

namespace CiuchApp.Dashboard.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
