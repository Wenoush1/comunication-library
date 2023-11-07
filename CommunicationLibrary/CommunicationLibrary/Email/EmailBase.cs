using CommunicationLibrary.Common;

namespace CommunicationLibrary.Email;

/// <summary>
/// Represents a base class for email communication that implements the <see cref="ICommunication"/> interface.
/// </summary>
public abstract class EmailBase : ICommunication
{
    /// <summary>
    /// The sender's email address or identifier.
    /// </summary>
    public string Sender { get; set; }
    /// <summary>
    /// A value indicating whether the email body is in HTML format.
    /// </summary>
    public bool IsBodyHtml { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="EmailBase"/> class with the specified sender's email address and HTML body format.
    /// </summary>
    /// <param name="sender">The sender's email address.</param>
    /// <param name="isBodyHtml">A value indicating whether the email body is in HTML format.</param>
    public EmailBase(string sender, bool isBodyHtml)
    {
        this.Sender = sender;
        this.IsBodyHtml = isBodyHtml;
    }

    /// <summary>
    /// Sends an email message to the specified recipient with the given subject and message content.
    /// This method is abstract and must be implemented by derived classes.
    /// </summary>
    /// <param name="recipient">The recipient's email address.</param>
    /// <param name="subject">The subject or title of the email.</param>
    /// <param name="message">The content of the email to be sent.</param>
    public abstract void Send(string recipient, string subject, string message);

}
