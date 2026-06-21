namespace AIChatbotIntegration.Services
{
    public class BotService
    {
        public string GetResponse(string message)
        {
            message = message.ToLower();

            if (message.Contains("hello"))
                return "Hello! How can I assist you today?";

            if (message.Contains("help"))
                return "I can answer your questions and assist you.";

            if (message.Contains("bye"))
                return "Goodbye! Have a great day.";

            return "I'm an AI chatbot integrated with Azure Bot Service.";
        }
    }
}
