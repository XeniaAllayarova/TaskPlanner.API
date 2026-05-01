using TaskPlanner.API.Models;

namespace TaskPlanner.API.Repositories.Interfaces
{
    public interface IUserRepository
    {
        User GetUserByName(string name);
    }
}
