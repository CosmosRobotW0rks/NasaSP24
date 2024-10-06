
using Microsoft.AspNetCore.Components.Web;
using System.Collections.Concurrent;

namespace NasaSPBackend.Chatbot.ChatbotSessionTracker
{
    public class ChatbotSessionTrackerService(ILogger<ChatbotSessionTrackerService> logger) : BackgroundService
    {
        private ILogger<ChatbotSessionTrackerService> _logger = logger;

        private ConcurrentQueue<ChatbotSession> Sessions = new();

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                CheckSessions();

                await Task.Delay(500);
            }
        }

        public ChatbotSession CreateSession(string openAIThreadID)
        {
            string sid = CreateSID(true);

            var ses = new ChatbotSession(openAIThreadID, sid);
            Sessions.Enqueue(ses);

            return ses;
        }

        public ChatbotSession? GetSessionByThreadID(string openAIThreadID) => Sessions.FirstOrDefault(x => x.OpenAIThreadID == openAIThreadID);
        public ChatbotSession? GetSessionBySessionID(string sessionID) => Sessions.FirstOrDefault(x => x.SessionID == sessionID);


        private void CheckSessions()
        {
            if (Sessions.Count > 0 && Sessions.Last().IsExpired)
            {
                bool delSuc = Sessions.TryDequeue(out ChatbotSession? ses);

                if (!delSuc) _logger.LogWarning($"Failed to delete session {ses?.OpenAIThreadID}");
                else _logger.LogInformation($"Deleted session {ses?.OpenAIThreadID}");
            }
        }

        private string CreateSID(bool unique)
        {
            string sid = "";

            do
            {
                string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

                for (int i = 0; i < 100; i++) sid += chars[Random.Shared.Next(chars.Length)];
            }
            while (unique && SIDExists(sid));

            return sid;
        }

        private bool SIDExists(string sid) => Sessions.Any(x => x.SessionID == sid);
    }

}
