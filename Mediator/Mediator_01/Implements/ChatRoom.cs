using Mediator.Interfaces;
using Mediator.Models;

namespace Mediator.Implements;

/// <summary>
/// Implements IChatRoom 
/// </summary>
public class ChatRoom : IChatRoom
{
    /// <summary>
    /// List of current Participant
    /// </summary>
    public Dictionary<string, IParticipant> participants { get; set; } = new ();
    
    /// <summary>
    /// Register Participant
    /// </summary>
    /// <param name="participant">Participant</param>
    public void Register(IParticipant participant)
    {
        try
        {
            // New participants
            if (!participants.ContainsValue(participant))
            {
                participants[participant.name] = participant;
                Console.WriteLine($"[Register] New Participant has Registered : { participant.name }");                
            }

            participant.chatRoom = this;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw e;
        }
    }

    /// <summary>
    /// Send To Message
    /// </summary>
    /// <param name="from">from</param>
    /// <param name="to">to</param>
    /// <param name="message">message</param>
    public void SendMessage(string from, string to, string message)
    {
        try
        {
            // Get target User
            IParticipant participant = participants[to];

            // If is not Validate
            if (participant == null)
                new Exception("[SendMessage] Participant Cannot be Null");

            // Callback Receive Message
            participant.ReceiveMessage(from,message);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw e;
        }
    }
}