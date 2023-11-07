using CommunicationLibrary.Common;

namespace CommunicationLibrary.SMS;

/// <summary>
/// Provides a base class for SMS communication that implements the <see cref="ICommunication"/> interface.
/// </summary>
public abstract class SMSBase : ICommunication
{

    public readonly string Sender;

    /// <summary>
    /// Initializes a new instance of the <see cref="SMSBase"/> class with the specified sender's identifier.
    /// </summary>
    /// <param name="sender">The sender's identifier for SMS messages.</param>
    public SMSBase(string sender)
    {
        this.Sender = sender;
    }

    /// <summary>
    /// Sends an SMS message to the specified recipient with the given subject and message content.
    /// This method is abstract and must be implemented by derived classes.
    /// </summary>
    /// <param name="recipient">The recipient's identifier for SMS messages.</param>
    /// <param name="subject">The subject or title of the SMS.</param>
    /// <param name="message">The content of the SMS to be sent.</param>
    public abstract void Send(string recipient, string subject, string message);

}
