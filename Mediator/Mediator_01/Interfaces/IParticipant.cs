using Mediator.Implements;

namespace Mediator.Models;

/// <summary>
/// Represents Participant
/// </summary>
public interface IParticipant
{
    /// <summary>
    /// Name of Participant
    /// </summary>
    public string name { get; set; }

    /// <summary>
    /// ChatRoom 
    /// </summary>
    public ChatRoom chatRoom { get; set; }

    /// <summary>
    /// Send to message
    /// </summary>
    /// <param name="to">to</param>
    /// <param name="message">message</param>
    void SendMessage(string to, string message);

    /// <summary>
    /// Receive Message
    /// </summary>
    /// <param name="from">from</param>
    /// <param name="message">message</param>
    void ReceiveMessage(string from, string message);
}