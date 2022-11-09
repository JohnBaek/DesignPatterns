using Mediator.Models;

namespace Mediator.Interfaces;

/// <summary>
/// Interface of ChatRoom
/// </summary>
public interface IChatRoom
{
    /// <summary>
    /// Register Participant
    /// </summary>
    /// <param name="participant">Participant</param>
    void Register(IParticipant participant);

    /// <summary>
    /// Send To Message
    /// </summary>
    /// <param name="from">from</param>
    /// <param name="to">to</param>
    /// <param name="message">message</param>
    void SendMessage(string from, string to, string message);
}