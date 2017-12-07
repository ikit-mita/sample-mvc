using System.Threading.Tasks;

namespace SampleMvc.Services
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string phoneNumber, string message);
    }
}
