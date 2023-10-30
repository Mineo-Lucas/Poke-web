using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class EmailService
    {
        private MailMessage mensaje;
        private SmtpClient servidor;

        public EmailService()
        {
            servidor = new SmtpClient();
            servidor.Credentials = new NetworkCredential("bd5ab225d567df", "********5ef1");
            servidor.EnableSsl = true;
            servidor.Port = 2525;
            servidor.Host = "sandbox.smtp.mailtrap.io";
        }
        
        public void ArmarCorreo(string CorreoDestino, string Asunto, string Mensaje)
        {
            mensaje=new MailMessage();
            mensaje.From = new MailAddress("ejemplo123@example.com");
            mensaje.To.Add(CorreoDestino);
            mensaje.Subject = Mensaje;
            mensaje.IsBodyHtml= true;
            mensaje.Body = Mensaje;
        }
        public void EnviarEmail()
        {
            try
            {
                servidor.Send(mensaje);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
