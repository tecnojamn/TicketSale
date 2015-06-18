using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
namespace COM
{
    public class MAILER
    {
        //sends confirmation mail (SIN PROBAR)
        public static void sendCofirmationMail(String email,String code)
        {

            MailMessage objeto_mail = new MailMessage();
            SmtpClient client = new SmtpClient();
            client.Host = "smtp.googlemail.com";
            client.Port = 587;
            client.UseDefaultCredentials = false;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.EnableSsl = true;
            client.Credentials = new System.Net.NetworkCredential("directmarket.notificaciones@gmail.com", "tecnologo1");
            objeto_mail.From = new MailAddress("directmarket.notificaciones@gmail.com");
            objeto_mail.To.Add(new MailAddress(email));
            objeto_mail.Subject = "Confirmación de cuenta";
            objeto_mail.Body = "<div>Por su seguridad debe confirmar su cuenta siguiendo el enlace <a href='/User/auth_confirmation/'"+code+" >AQUI</a></div>";
            client.Send(objeto_mail);
        }
    }
}
