
using System.Net;
using System.Net.Mail;

namespace Email;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void buttonSend_Click(object sender, EventArgs e)
    {
        //IMAP / pop3
        /* smtp
            ip/host
            user
            pass
            
            hr@fad.ir
            gmail
            ethereal.email
        */

        var user = "kendra.donnelly@ethereal.email";
        var pass = "pKk7Re3Zhy4ytTEgHE";
        var host = "smtp.ethereal.email";
        var port = 587;


        var message = new MailMessage
        {
            Subject = textBoxSubject.Text,
            Body = textBoxBody.Text,
            From = new MailAddress(user),
            IsBodyHtml = true,
        };
        message.To.Add(textBoxTo.Text);
        //message.Attachments.Add()

        var client = new SmtpClient(host, port);
        client.Credentials = new NetworkCredential(user, pass);
        client.EnableSsl = true;
        //client.UseDefaultCredentials = false;

        client.Send(message);

    }
}
