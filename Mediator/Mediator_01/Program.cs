// Mediator Patterns
// https://www.dofactory.com/net/mediator-design-pattern

using Mediator.Implements;
using Mediator.Models;
using Mediator.Models.Participants;

Console.WriteLine("Mediator Patterns");

// 중재자 ( Mediator )
// 채팅룸을 생각해보면된다 채팅룸은 모든 채팅 참가자들의 HUB 역할을 수행한다.
try
{
    // 하나의 채팅룸을 개설한다.
    ChatRoom chatRoom = new ChatRoom();

    // 채팅방 참가자를 생성한다.
    IParticipant george = new Beatle("George");
    IParticipant paul = new Beatle("Paul");
    IParticipant john = new NonBeatle("John");
    
    // 참가자 등록
    chatRoom.Register(george);
    chatRoom.Register(paul);
    chatRoom.Register(john);
    
    george.SendMessage("John", "Hi");
    john.SendMessage("George","Yeah");
}
catch (Exception e)
{
    Console.WriteLine(e);
}

