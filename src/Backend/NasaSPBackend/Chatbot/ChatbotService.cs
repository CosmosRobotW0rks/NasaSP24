using NasaSPBackend.Chatbot.ChatbotSessionTracker;
using OpenAI;
using OpenAI.Assistants;
using System.Text;
using System.Threading;

#pragma warning disable OPENAI001

namespace NasaSPBackend.Chatbot
{
    public class ChatbotService
    {

        private readonly ChatbotSessionTrackerService _tracker;
        private readonly ILogger<ChatbotService> _logger;

        private OpenAIClient client;

        public ChatbotService(IServiceProvider services, ILogger<ChatbotService> logger)
        {
            var serv = services.CreateScope().ServiceProvider.GetRequiredService<ChatbotSessionTrackerService>();

            _tracker = services.GetRequiredService<ChatbotSessionTrackerService>();
            _logger = logger;


            client = new(key);
        }

        public ChatbotSession CreateSession()
        {
            var assistantCli = client.GetAssistantClient();

            var thread = assistantCli.CreateThread().Value;

            string threadID = thread.Id;

            return _tracker.CreateSession(threadID);
        }


        public string? SendMessageAndGetResponse(ChatbotSession session, string message)
        {
            var assistantCli = client.GetAssistantClient();

            var msg = assistantCli.CreateMessage(session.OpenAIThreadID, OpenAI.Assistants.MessageRole.User, [MessageContent.FromText(message)]).Value;

            var run = assistantCli.CreateRun(session.OpenAIThreadID, assistantID).Value;

            while(run.Status == RunStatus.Queued || run.Status == RunStatus.InProgress)
            {
                run = assistantCli.GetRun(session.OpenAIThreadID, run.Id);
            }

            if(run.Status != RunStatus.Completed)
            {
                _logger.LogError($"Runstatus is not completed, {run.Status} instead");
                return null;
            }

            var messages = assistantCli.GetMessages(session.OpenAIThreadID).ToList();

            return messages[0].Content.First().Text;

        }
    }
}
