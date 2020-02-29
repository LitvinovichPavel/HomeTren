using System;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;

namespace DocNet
{
    class Program
    {
        static void Main(string[] args)
        {
            SmtpClient Smtp = new SmtpClient("smtp.gmail.com", 587);//Тут нужно 587
            Smtp.Credentials = new NetworkCredential("test21asdfmail@gmail.com", "testasdf");
            MailMessage Message = new MailMessage();
            Message.From = new MailAddress("test21asdfmail@gmail.com"); // пишем свой e-mail.
            Message.To.Add(new MailAddress("21asdfmail@gmail.com")); // Куда отправлять
            Message.Subject = "TEXT SUBJECT"; // свой заголовок
            Message.Body = "TEXT BOBY";
            Smtp.EnableSsl = true;
            Smtp.Send(Message);
        }
    }
}
