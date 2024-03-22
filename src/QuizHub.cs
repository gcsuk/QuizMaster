using Microsoft.AspNetCore.SignalR;

namespace Quiz;

public class QuizHub : Hub
{
    public async Task StartGame(int id)
    {
        await Clients.All.SendAsync("StartGame", id);
    }

    public async Task ChangeQuestion(int questionNumber)
    {
        await Clients.All.SendAsync("ChangeQuestion", questionNumber);
    }

    public async Task RevealAnswer()
    {
        await Clients.All.SendAsync("RevealAnswer");
    }

    public async Task AnswerSubmitted(int playerId, bool isCorrect)
    {
        await Clients.All.SendAsync("AnswerSubmitted", playerId, isCorrect);
    }

    public async Task ShowResults()
    {
        await Clients.All.SendAsync("ShowResults");
    }
}