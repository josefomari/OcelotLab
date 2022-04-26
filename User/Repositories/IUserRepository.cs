using System.Collections.Generic;
using System.Threading.Tasks;

namespace User.Repositories
{
    public interface IUserRepository
    {
        public Task<List<User>> GetAllUsers();
        public Task<User> AddUser(User user);
    }
}
