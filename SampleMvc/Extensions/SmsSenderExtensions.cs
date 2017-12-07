using System.Threading.Tasks;
using SampleMvc.Services;

namespace SampleMvc.Extensions
{
    public static class SmsSenderExtensions
    {
        public static async Task SendVerificationCode(
            this ISmsSender smsSender, string phoneNumber, string code)
        {
            await smsSender.SendSmsAsync(phoneNumber,
                $"Confirmation code: {code}");
        }
    }
}
