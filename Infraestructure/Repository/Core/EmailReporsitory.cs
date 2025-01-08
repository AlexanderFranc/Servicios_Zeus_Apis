using Core.Dtos.Core;
using Core.Interfaces.Core;
using Infraestructure.Configuration.Conexion.LoginDB;
using System.Net.Mail;

namespace Infraestructure.Repository.Core
{
    public class EmailReporsitory: IEmailReporsitory
    {
        public async Task SendEmail(EmailDto emaildata)
        {
            MailMessage correo = new MailMessage();
            correo.To.Add(emaildata.toEmail);
            correo.CC.Add(emaildata.cc);

            correo.From = new MailAddress("no.reply@uisek.edu.ec", "Notificación Zeus", System.Text.Encoding.UTF8);
            correo.Subject = emaildata.subject;
            correo.SubjectEncoding = System.Text.Encoding.UTF8;
            correo.Body = "Saludos Cordiales,\n " + emaildata.body + ".\n" +
                "NO RESPONDA A ESTE EMAIL.";
            correo.BodyEncoding = System.Text.Encoding.UTF8;
            string body = "<html><head> " +
             "<style type=\"text/css\">.style3 { width:30%;  } .style2 {color:red;}.style4 {border:0;} .titulo{text-align:center;}</style>" +
            "</head>" +
            "<body class=\"style4\">" +
            "<form id=\"form1\" runat=\"server\">" +
            "<div class=\"titulo\"><h3>Aprobación solicitud</h3></div>" +
            "<div><label>Saludos cordiales,\n</label><br/>" +
            "<label>" + emaildata.body + "</label> </div> " +
            "<hr/><br/>" +
            "En caso de dudas contacte al departamento t&eacute;cnico de la Universidad Internacional SEK helpdesk@uisek.edu.ec ." +

            "</div></form></body></html>";

            System.Net.Mime.ContentType mimeType = new System.Net.Mime.ContentType("text/html");
            // Add the alternate body to the message.

            AlternateView alternate = AlternateView.CreateAlternateViewFromString(body, mimeType);

            correo.AlternateViews.Add(alternate);
            correo.IsBodyHtml = false;
            SmtpClient client = new SmtpClient
            {
                Credentials = new System.Net.NetworkCredential("no.reply@uisek.edu.ec", Funciones.ConectarMail()),
                Port = 587,
                Host = "smtp.gmail.com",
                EnableSsl = true //Esto es para que vaya a través de SSL que es obligatorio con GMail 
            };
            try
            {
                await client.SendMailAsync(correo);

            }
            catch (Exception ex)
            {
            }
        }
    }
}
