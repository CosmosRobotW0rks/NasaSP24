namespace NasaSPBackend.Chatbot.ChatbotSessionTracker
{
    public class ChatbotSession
    {
        private readonly TimeSpan ExpiryIncrementor = TimeSpan.FromMinutes(30);

        public DateTime Expire { get; private set; }

        public bool IsExpired => DateTime.Now > Expire;

        public string OpenAIThreadID { get; private set; }

        public string SessionID { get; private set; }

        public ChatbotSession(string openAIThreadID, string sessionID)
        {
            OpenAIThreadID = openAIThreadID;
            SessionID = sessionID;

            ExtendExpiryDT();
        }

        public void ExtendExpiryDT() => Expire = DateTime.Now.Add(ExpiryIncrementor);


    }
}
