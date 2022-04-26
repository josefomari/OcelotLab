using System.Collections.Generic;
using System.Threading.Tasks;

namespace Message.Repositories
{
    public interface IMessageRepository
    {
        public Task<List<Message>> GetAllMessages();
    }
}
