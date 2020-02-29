using System;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Text;

namespace MetanitEmail
{
    class Program
    {
        static void Main(string[] args)
        {
                MailAddress from = new MailAddress("test21asdfmail@gmail.com");
                MailAddress to = new MailAddress("21asdfmail@gmail.com");

                MailMessage message = new MailMessage(from, to)
                {
                    Subject = "Твое приложение оценили!",
                    IsBodyHtml = false,
                    Body = "BODY"
                };

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587)
                {
                    Credentials = new NetworkCredential("21asdfmail@gmail.com", "testasdf"),
                    EnableSsl = true
                };

                smtp.Send(message);                             // Отправляем наше письмо
                Console.WriteLine("Сообщение успешно отправлено. Спасибо!");
        }
    }
}
