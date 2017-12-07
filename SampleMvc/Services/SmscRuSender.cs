using System.Net.Http;
using System.Threading.Tasks;

namespace SampleMvc.Services
{
    public class SmscRuSender : ISmsSender
    {
        public async Task SendSmsAsync(string phoneNumber, string message)
        {
            using (var client = new HttpClient())
            {
                await client.GetAsync(
                    $"https://smsc.ru/sys/send.php" +
                    $"?login=ikitmita" +
                    $"&psw=6049a33147ef1bd8531a99597db1999a" +
                    $"&phones={phoneNumber}" +
                    $"&mes={message}");
            }
        }
    }
}
