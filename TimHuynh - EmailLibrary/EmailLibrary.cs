using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Threading.Tasks;

namespace TimHuynh___EmailLibrary
{
    public class EmailLibrary
    {
        //Public - can be accessed by EmailDemo
        //Static - can be accessed by MainMethod
        public static void EmailCreator()
        {
            MailMessage message = new MailMessage();
            SmtpClient emailClient = new SmtpClient();

            message.IsBodyHtml = true;
            message.From = new MailAddress("slym@wp.pl", "Sly M");
            message.Subject = "How to Send Email from C# Console App";
            message.Body = "This is a test email.<br/>Here is another line of content.</br>";
            message.Body += "And here is a hyperlink: <a href='https://google/com'>Google</a>";
            message.To.Add("mazsylwester@wp.pl");
            message.CC.Add("smazurek@pl.sii.eu");

            string file = @"C:\users\Sylwester\Desktop\hist.txt";
            Attachment data = new Attachment(file);
            message.Attachments.Add(data);

            message.Attachments.Add(new Attachment(@"C:\users\Sylwester\Desktop\Code.txt"));

            emailClient.Send(message);

            // Clean up
            message.Dispose();
        }
    }
}
