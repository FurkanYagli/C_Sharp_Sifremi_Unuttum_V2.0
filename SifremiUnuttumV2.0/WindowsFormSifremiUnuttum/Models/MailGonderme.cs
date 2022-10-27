using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using WindowsFormSifremiUnuttum.Models;

namespace WindowsFormSifremiUnuttum.Models
{
    public class MailGonderme
    {
        WindowsFormSifremiUnuttumEntitiesConnectionDb db = new WindowsFormSifremiUnuttumEntitiesConnectionDb();
        public void Microsoft(string GondericiMail, string GondericiPass, string AliciMail)
        {
            PersonelGirisTablosu p = db.PersonelGirisTablosu.FirstOrDefault(x => x.MailAdress == GondericiMail);
            SmtpClient sc = new SmtpClient();
            sc.Port = 587;
            sc.Host = "smtp.outlook.com";
            sc.EnableSsl = true;
            sc.Credentials = new NetworkCredential(GondericiMail, GondericiPass);

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(GondericiMail, "Şifre Yenileme");
            mail.To.Add(AliciMail);
            mail.Subject = "Şifre Yenileme Talebi";
            mail.IsBodyHtml = true;
            mail.Body = $@"{DateTime.Now.ToString()} Tarihinde şifre yenileme talebinde bulundunuz. Şifreniz: {p.Password}";
            //sc.Timeout = 100;
            sc.Send(mail);
        }
    }
}
