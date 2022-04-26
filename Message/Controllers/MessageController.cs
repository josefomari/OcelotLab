using Message.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Message.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private readonly IMessageRepository _messageRepository;
        public MessageController(IMessageRepository userRepository)
        {
            _messageRepository = userRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<Message>>> GetAllUsers()
        {
            return await _messageRepository.GetAllMessages();
        }
    }
}