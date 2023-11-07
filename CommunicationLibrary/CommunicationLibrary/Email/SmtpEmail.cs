using System.Net.Mail;

namespace CommunicationLibrary.Email;

/// <summary>
/// Represents a class for sending email messages using SMTP (Simple Mail Transfer Protocol).
/// This class inherits from the <see cref="EmailBase"/> class and implements the email sending logic.
/// </summary>
public class SmtpEmail : EmailBase
{

    private SmtpClient _smtpClient;


    /// <summary>
    /// Initializes a new instance of the <see cref="SmtpEmail"/> class with the specified SMTP client, sender's email address, and HTML body format.
    /// </summary>
    /// <param name="smtpClient">The SMTP client to be used for sending email.</param>
    /// <param name="sender">The sender's email address.</param>
    /// <param name="isBodyHtml">A value indicating whether the email body is in HTML format.</param>
    public SmtpEmail(SmtpClient smtpClient, string sender, bool isBodyHtml) : base(sender, isBodyHtml)
    {
        _smtpClient = smtpClient;
    }

    /// <summary>
    /// Sends an email message to the specified recipient using the SMTP client, with the given subject and message content.
    /// </summary>
    /// <param name="recipient">The recipient's email address.</param>
    /// <param name="subject">The subject or title of the email.</param>
    /// <param name="message">The content of the email to be sent.</param>
    public override void Send(string recipient, string subject, string message)
    {
        using MailMessage mail = new MailMessage();
        mail.From = new MailAddress(Sender);
        mail.To.Add(recipient);
        mail.Subject = subject;
        mail.Body = message;
        mail.IsBodyHtml = IsBodyHtml;

        _smtpClient.Send(mail);
    }

}