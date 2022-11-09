using Mediator.Implements;

namespace Mediator.Models;

/// <summary>
/// 참가자 구현체
/// </summary>
public class Participant : IParticipant
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
    /// 생성자
    /// </summary>
    /// <param name="name"></param>
    public Participant(string name)
    {
        this.name = name;
    }
    
    /// <summary>
    /// 메세지를 보낸다
    /// </summary>
    /// <param name="to">상대방</param>
    /// <param name="message">메세지</param>
    public void SendMessage(string to, string message)
    {
        chatRoom.SendMessage(name,to,message);
    }

    /// <summary>
    /// 메세지를 받는다
    /// </summary>
    /// <param name="from">보내온 상대방</param>
    /// <param name="message">메세지</param>
    public virtual void ReceiveMessage(string from, string message)
    {
        Console.WriteLine("{0} to {1}: '{2}'", from, name, message);
    }
}