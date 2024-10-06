using Microsoft.AspNetCore.Mvc;
using NasaSPBackend.Chatbot;
using NasaSPBackend.Chatbot.ChatbotSessionTracker;

namespace NasaSPBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ChatbotController(ILogger<ChatbotController> logger, ChatbotService chatbot, ChatbotSessionTrackerService sessionTrackerService) : ControllerBase
    {
        private readonly ILogger<ChatbotController> _logger = logger;
        private readonly ChatbotService _chatbot = chatbot;
        private readonly ChatbotSessionTrackerService _sessionTracker = sessionTrackerService;

        [HttpPost("createsession")]
        public IActionResult createSession()
        {
            var session = _chatbot.CreateSession();

            return Ok(session.SessionID);
        }

        [HttpPost("message")]
        public IActionResult message(string sid, string message)
        {
            var session = _sessionTracker.GetSessionBySessionID(sid);

            if(session == null)
            {
                _logger.LogWarning($"Session not found ({sid})");

                return BadRequest("session_not_found");
            }


            string? response = _chatbot.SendMessageAndGetResponse(session, message);

            if(response == null)
            {
                return BadRequest("Something went wrong");
            }

            return Ok(response);
        }
    }
}
