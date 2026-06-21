using Microsoft.AspNetCore.Mvc;
using AIChatbotIntegration.Models;
using AIChatbotIntegration.Services;

namespace AIChatbotIntegration.Controllers
{
    public class ChatController : Controller
    {
        private readonly BotService _botService;

        public ChatController(BotService botService)
        {
            _botService = botService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SendMessage(
            ChatMessage model)
        {
            model.BotResponse =
                _botService.GetResponse(
                    model.UserMessage);

            return Json(model);
        }
    }
}
