using Core.Dtos.Core;
using Core.Interfaces.Core;
using Infraestructure.Configuration.Conexion.LoginDB;
using System.Net.Mail;

namespace Infraestructure.Repository.Core
{
    public class EmailReporsitory: IEmailReporsitory
    {
        //CORREO CUANDO APRUEBA TALENTO HUMANO
        public async Task SendEmail(EmailDto emaildata)
        {
            MailMessage correo = new MailMessage();
            correo.To.Add(emaildata.toEmail);
            if (emaildata.tipoUsuario.Equals("VICE"))
            {
                // si es TIEMPO COMPLETO
                if (emaildata.idDedicacion == 1)
                {
                    correo.CC.Add("contrataciones.tc@uisek.edu.ec");
                }
                else
                {
                    correo.CC.Add("contrataciones.tp@uisek.edu.ec");
                }
            }
            correo.Bcc.Add("edwin.villalobos@uisek.edu.ec");
            correo.Bcc.Add("franklin.onofa@uisek.edu.ec");

            correo.From = new MailAddress("no.reply@uisek.edu.ec", "Notificación Zeus", System.Text.Encoding.UTF8);
            correo.Subject = emaildata.subject;
            correo.SubjectEncoding = System.Text.Encoding.UTF8;
            correo.BodyEncoding = System.Text.Encoding.UTF8;

            string bodyTmp = "<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n" +
                "<head>\r\n" +
                "<style type=\"text/css\">\r\n" +
                "   .style3 {\r\nwidth: 30%;\r\n}\r\n\r\n" +
                "   .style2 {\r\ncolor: red;\r\n}\r\n\r\n" +
                "   .styletable {\r\nborder: 0;\r\nborder-radius: 14px 14px 14px 14px;\r\nbackground: #F7F7F7;\r\n}\r\n\r\n" +
                "   .styleTitulo {\r\nborder: 0;\r\nfont-size: 18px;\r\ncolor: #000000;\r\n}\r\n\r\n" +
                "   .stylecentrado {\r\nborder: 0;\r\ntext-align: center;\r\nfont-size: 18px;\r\ncolor: #000000;\r\n}\r\n\r\n" +
                "   .encabezado {\r\ntext-align: center;\r\nbackground-color: #0b5a9c;\r\nheight: 100px;\r\n}\r\n\r\n" +
                "   .styleParrafo {\r\nfont-family: 'Ubuntu', sans-serif;\r\nfont-size: 15px;\r\nletter-spacing: 0px;\r\nword-spacing: 0px;\r\ncolor: #545454;\r\n}\r\n\r\n" +
                "   .styletoken {\r\ncolor: #1e1e2d;\r\nfont-weight: 500;\r\nmargin: 0;\r\nfont-size: 18px;\r\nfont-family: 'Rubik', sans-serif;\r\n}\r\n\r\n" +
                "   .stylemensajecentral {\r\nfont-size: 16px;\r\nmargin: 0 0 10px 0;\r\nfont-family: Arial, sans-serif;\r\n}\r\n\r\n" +
                "   th,\r\ntd {\r\npadding-top: 3px;\r\npadding-bottom: 3px;\r\npadding-left: 20px;\r\npadding-right: 3px;\r\n}\r\n" +
                "</style>\r\n" +
                "</head>\r\n\r\n" +
                "<body class=\"style4\">\r\n" +
                "   <form id=\"form1\" runat=\"server\">\r\n" +
                "   <table class=\"styletable\">\r\n" +
                "       <tr>\r\n" +
                "           <td colspan=\"2\" class=\"encabezado\">\r\n" +
                "               <img src='https://portalalumnos.uisek.edu.ec/media/LOGO_UISEK_LETRAS_BLANCO-TRANSPARENTE.png'\r\nwidth='250px'></img>\r\n" +
                "           </td>\r\n" +
                "       </tr>\r\n" +
                "       <tr>\r\n" +
                "            <td class=\"style4\">&nbsp;</td>\r\n" +
                "       </tr>\r\n" +
                "       <tr>\r\n" +
                "           <td class=\"styleTitulo\"" +
                "               ><b>Estimad@</b> " + emaildata.nombreCoordinador +","+ 
                "           </td>\r\n" +
                "       </tr>\r\n" +
                "       <tr>\r\n" +
                "           <td class=\"style4\">&nbsp;</td>\r\n" +
                "       </tr>\r\n" +
                "       <tr>\r\n" +
                "           <td>\r\n" +
                "               <p style=\"margin:0 0 12px 0;font-size:16px;line-height:24px;font-family:Arial,sans-serif;\">\r\n" +
                "                       Se le informa que se actualizó el estado de su solicitud de contratación de:\r\n" +
                "               </p>\r\n" +
                "           </td>\r\n" +
                "       </tr>\r\n" +
                "       <tr>\r\n" +
                "           <td>\r\n" +
                "               <ul>\r\n" +
                "                   <li>CI: "+emaildata.cedulaDocente+"</li>\r\n" +
                "                   <li>"+emaildata.nombreDocente+"</li>\r\n" +
                "                   <li>"+emaildata.nombreFacultad+"</li>\r\n" +
                "                   <li>"+emaildata.periodo+"</li>\r\n" +
                "               </ul>\r\n" +
                "           </td>\r\n" +
                "       </tr>\r\n" +
                "       <tr>\r\n" +
                "           <td>\r\n" +
                "               <p style=\"margin:0 0 12px 0;font-size:16px;line-height:24px;font-family:Arial,sans-serif;\">\r\n" +
                "                   Estado: "+emaildata.estadoSolicitud+"\r\n" +
                "               </p>\r\n" +
                "           </td>\r\n" +
                "       </tr>\r\n" +
                "       <tr>\r\n" +
                "           <td>\r\n" +
                "               <p style=\"margin:0 0 12px 0;font-size:16px;line-height:24px;font-family:Arial,sans-serif;\">\r\n" +
                "                   Observación: "+emaildata.observacionSolicitud+"\r\n" +
                "               </p>\r\n" +
                "           </td>\r\n" +
                "       </tr>\r\n" +
                "       <tr>\r\n" +
                "           <td class=\"styleParrafo\">" +
                "               <b>En caso de dudas o de algún inconveniente se puede contactar en los\r\n" +
                "               siguientes canales de la Universidad Internacional SEK.</b>" +
                "           </td>\r\n" +
                "       </tr>\r\n" +
                "       <tr>\r\n" +
                "           <td>\r\n" +
                "               <img src='https://portalalumnos.uisek.edu.ec/media/whatsappIcon.png' width='15px'\r\n height=\"15px\"></img> &nbsp; " +
                "                   <a class=\"styleParrafo\"\r\n" +
                "                       href=\"https://api.whatsapp.com/send?phone=593998369476&text=\" target=\"_blank\">Whatsapp</a>\r\n" +
                "           </td>\r\n" +
                "       </tr>\r\n" +
                "       <tr>\r\n" +
                "           <td>\r\n" +
                "               <img src='https://portalalumnos.uisek.edu.ec/media/phoneicon.png' width='15px' height='15px'>" +
                "               </img>\r\n &nbsp; <b>Teléfonos:</b> 1800 800 100 &nbsp; " +
                "                   <a class='styleParrafo'\r\n" +
                "                       href='https://uisek.edu.ec/wp-content/uploads/2022/04/extensiones-telefonicas-uisek.pdf'\r\n" +
                "                           target='_blank'>Extensiones</a>\r\n" +
                "           </td>\r\n" +
                "       </tr>\r\n" +
                "       <tr>\r\n" +
                "           <td>\r\n" +
                "               <img class=\"styleParrafo\" src='https://portalalumnos.uisek.edu.ec/media/mailicon.png' width='15px'\r\n" +
                "                   height='18px'>&nbsp; " +
                "                       <b>Correo Electrónico:</b> Soporte UISEK helpdesk@uisek.edu.ec " +
                "               </img>\r\n" +
                "           </td>\r\n" +
                "       </tr>\r\n" +
                "       <tr>\r\n" +
                "           <td class=\"style4\"> &nbsp; " +
                "           </td>\r\n" +
                "       </tr>\r\n" +
                "       <tr>\r\n" +
                "           <td class=\"style4\"> &nbsp; " +
                "           </td>\r\n" +
                "       </tr>\r\n" +
                "       <tr>\r\n" +
                "           <td class=\"style2\">NO RESPONDA A ESTE CORREO. " +
                "           </td>\r\n" +
                "       </tr>\r\n" +
                "       <tr>\r\n" +
                "       <td class=\"style4\"> &nbsp; " +
                "       </td>\r\n" +
                "       </tr>\r\n" +
                "   </table>\r\n" +
                "   </form>\r\n" +
                "</body>\r\n\r\n" +
                "</html>";

            System.Net.Mime.ContentType mimeType = new System.Net.Mime.ContentType("text/html");
            // Add the alternate body to the message.

            AlternateView alternate = AlternateView.CreateAlternateViewFromString(bodyTmp, mimeType);

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
        public async Task SendEmailIngreso(EmailDto emaildata)
        {
            MailMessage correo = new MailMessage();
            //correo.To.Add(emaildata.toEmail);//TODO: aqui modificar por los correo de TH -> en emaildata.idDedicacion envío el valor para comprobar si es TIEMPO COMPLETO, ETC
            // si es TIEMPO COMPLETO
            if (emaildata.idDedicacion == 1)
            {
                correo.CC.Add("contrataciones.tc@uisek.edu.ec");
            }
            else
            {
                correo.CC.Add("contrataciones.tp@uisek.edu.ec");
            }

            correo.CC.Add(emaildata.cc);
            correo.Bcc.Add("edwin.villalobos@uisek.edu.ec");
            correo.Bcc.Add("franklin.onofa@uisek.edu.ec");

            correo.From = new MailAddress("no.reply@uisek.edu.ec", "Notificación Zeus", System.Text.Encoding.UTF8);
            correo.Subject = emaildata.subject;
            correo.SubjectEncoding = System.Text.Encoding.UTF8;
            correo.BodyEncoding = System.Text.Encoding.UTF8;

            string bodyTmp = "<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n" +
                "<head>\r\n" +
                "<style type=\"text/css\">\r\n" +
                "   .style3 {\r\nwidth: 30%;\r\n}\r\n\r\n" +
                "   .style2 {\r\ncolor: red;\r\n}\r\n\r\n" +
                "   .styletable {\r\nborder: 0;\r\nborder-radius: 14px 14px 14px 14px;\r\nbackground: #F7F7F7;\r\n}\r\n\r\n" +
                "   .styleTitulo {\r\nborder: 0;\r\nfont-size: 18px;\r\ncolor: #000000;\r\n}\r\n\r\n" +
                "   .stylecentrado {\r\nborder: 0;\r\ntext-align: center;\r\nfont-size: 18px;\r\ncolor: #000000;\r\n}\r\n\r\n" +
                "   .encabezado {\r\ntext-align: center;\r\nbackground-color: #0b5a9c;\r\nheight: 100px;\r\n}\r\n\r\n" +
                "   .styleParrafo {\r\nfont-family: 'Ubuntu', sans-serif;\r\nfont-size: 15px;\r\nletter-spacing: 0px;\r\nword-spacing: 0px;\r\ncolor: #545454;\r\n}\r\n\r\n" +
                "   .styletoken {\r\ncolor: #1e1e2d;\r\nfont-weight: 500;\r\nmargin: 0;\r\nfont-size: 18px;\r\nfont-family: 'Rubik', sans-serif;\r\n}\r\n\r\n" +
                "   .stylemensajecentral {\r\nfont-size: 16px;\r\nmargin: 0 0 10px 0;\r\nfont-family: Arial, sans-serif;\r\n}\r\n\r\n" +
                "   th,\r\ntd {\r\npadding-top: 3px;\r\npadding-bottom: 3px;\r\npadding-left: 20px;\r\npadding-right: 3px;\r\n}\r\n" +
                "</style>\r\n" +
                "</head>\r\n\r\n" +
                "<body class=\"style4\">\r\n" +
                "   <form id=\"form1\" runat=\"server\">\r\n" +
                "   <table class=\"styletable\">\r\n" +
                "       <tr>\r\n" +
                "           <td colspan=\"2\" class=\"encabezado\">\r\n" +
                "               <img src='https://portalalumnos.uisek.edu.ec/media/LOGO_UISEK_LETRAS_BLANCO-TRANSPARENTE.png'\r\nwidth='250px'></img>\r\n" +
                "           </td>\r\n" +
                "       </tr>\r\n" +
                "       <tr>\r\n" +
                "            <td class=\"style4\">&nbsp;</td>\r\n" +
                "       </tr>\r\n" +
                "       <tr>\r\n" +
                "           <td class=\"styleTitulo\"" +
                "               ><b>Estimad@,</b> " +
                "           </td>\r\n" +
                "       </tr>\r\n" +
                "       <tr>\r\n" +
                "           <td class=\"style4\">&nbsp;</td>\r\n" +
                "       </tr>\r\n" +
                "       <tr>\r\n" +
                "           <td>\r\n" +
                "               <p style=\"margin:0 0 12px 0;font-size:16px;line-height:24px;font-family:Arial,sans-serif;\">\r\n" +
                "                       Se le informa que se ha ingresado una nueva solicitud de contratación con los siguientes datos:\r\n" +
                "               </p>\r\n" +
                "           </td>\r\n" +
                "       </tr>\r\n" +
                "       <tr>\r\n" +
                "           <td>\r\n" +
                "               <ul>\r\n" +
                "                   <li>CI: " + emaildata.cedulaDocente + "</li>\r\n" +
                "                   <li>" + emaildata.nombreDocente + "</li>\r\n" +
                "                   <li>" + emaildata.nombreFacultad + "</li>\r\n" +
                "                   <li>" + emaildata.periodo + "</li>\r\n" +
                "               </ul>\r\n" +
                "           </td>\r\n" +
                "       </tr>\r\n" +
                "       <tr>\r\n" +
                "           <td>\r\n" +
                "               <p style=\"margin:0 0 12px 0;font-size:16px;line-height:24px;font-family:Arial,sans-serif;\">\r\n" +
                "                   Estado: " + emaildata.estadoSolicitud + "\r\n" +
                "               </p>\r\n" +
                "           </td>\r\n" +
                "       </tr>\r\n" +
                "       <tr>\r\n" +
                "           <td class=\"styleParrafo\">" +
                "               <b>En caso de dudas o de algún inconveniente se puede contactar en los\r\n" +
                "               siguientes canales de la Universidad Internacional SEK.</b>" +
                "           </td>\r\n" +
                "       </tr>\r\n" +
                "       <tr>\r\n" +
                "           <td>\r\n" +
                "               <img src='https://portalalumnos.uisek.edu.ec/media/whatsappIcon.png' width='15px'\r\n height=\"15px\"></img> &nbsp; " +
                "                   <a class=\"styleParrafo\"\r\n" +
                "                       href=\"https://api.whatsapp.com/send?phone=593998369476&text=\" target=\"_blank\">Whatsapp</a>\r\n" +
                "           </td>\r\n" +
                "       </tr>\r\n" +
                "       <tr>\r\n" +
                "           <td>\r\n" +
                "               <img src='https://portalalumnos.uisek.edu.ec/media/phoneicon.png' width='15px' height='15px'>" +
                "               </img>\r\n &nbsp; <b>Teléfonos:</b> 1800 800 100 &nbsp; " +
                "                   <a class='styleParrafo'\r\n" +
                "                       href='https://uisek.edu.ec/wp-content/uploads/2022/04/extensiones-telefonicas-uisek.pdf'\r\n" +
                "                           target='_blank'>Extensiones</a>\r\n" +
                "           </td>\r\n" +
                "       </tr>\r\n" +
                "       <tr>\r\n" +
                "           <td>\r\n" +
                "               <img class=\"styleParrafo\" src='https://portalalumnos.uisek.edu.ec/media/mailicon.png' width='15px'\r\n" +
                "                   height='18px'>&nbsp; " +
                "                       <b>Correo Electrónico:</b> Soporte UISEK helpdesk@uisek.edu.ec " +
                "               </img>\r\n" +
                "           </td>\r\n" +
                "       </tr>\r\n" +
                "       <tr>\r\n" +
                "           <td class=\"style4\"> &nbsp; " +
                "           </td>\r\n" +
                "       </tr>\r\n" +
                "       <tr>\r\n" +
                "           <td class=\"style4\"> &nbsp; " +
                "           </td>\r\n" +
                "       </tr>\r\n" +
                "       <tr>\r\n" +
                "           <td class=\"style2\">NO RESPONDA A ESTE CORREO. " +
                "           </td>\r\n" +
                "       </tr>\r\n" +
                "       <tr>\r\n" +
                "       <td class=\"style4\"> &nbsp; " +
                "       </td>\r\n" +
                "       </tr>\r\n" +
                "   </table>\r\n" +
                "   </form>\r\n" +
                "</body>\r\n\r\n" +
                "</html>";

            System.Net.Mime.ContentType mimeType = new System.Net.Mime.ContentType("text/html");
            // Add the alternate body to the message.

            AlternateView alternate = AlternateView.CreateAlternateViewFromString(bodyTmp, mimeType);

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
