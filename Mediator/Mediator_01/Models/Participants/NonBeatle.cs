using Mediator.Implements;

namespace Mediator.Models.Participants;

public class NonBeatle : Participant
{
    /// <summary>
    /// 생성자
    /// </summary>
    /// <param name="name"></param>
    public NonBeatle(string name) : base(name)
    {
    }

    /// <summary>
    /// ReceiveMessage
    /// </summary>
    /// <param name="from"></param>
    /// <param name="message"></param>
    public override void ReceiveMessage(string from, string message)
    {
        Console.Write("[ReceiveMessage] To a NonBeatle : ");
        base.ReceiveMessage(from,message);
    }
}