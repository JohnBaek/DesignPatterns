using Mediator.Implements;

namespace Mediator.Models.Participants;

public class Beatle : Participant
{
    /// <summary>
    /// 생성자
    /// </summary>
    /// <param name="name"></param>
    public Beatle(string name) : base(name)
    {
    }

    /// <summary>
    /// ReceiveMessage
    /// </summary>
    /// <param name="from"></param>
    /// <param name="message"></param>
    public override void ReceiveMessage(string from, string message)
    {
        Console.Write("[ReceiveMessage] To a Beatle: ");
        base.ReceiveMessage(from,message);
    }
}