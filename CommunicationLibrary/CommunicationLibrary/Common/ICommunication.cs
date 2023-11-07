namespace CommunicationLibrary.Common;

/// <summary>
/// Defines the contract for sending messages to a recipient.
/// </summary>
public interface ICommunication
{
    /// <summary>
    /// Sends a message to the specified recipient with the given subject and message content.
    /// </summary>
    /// <param name="recipient">The recipient's address or identifier.</param>
    /// <param name="subject">The subject or title of the message.</param>
    /// <param name="message">The content of the message to be sent.</param>
    void Send(string recipient, string subject, string message);

}