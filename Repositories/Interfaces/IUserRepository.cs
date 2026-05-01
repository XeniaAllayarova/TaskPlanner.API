using Task_planner.API.Models;

namespace Task_planner.API.Repositories.Interfaces
{
    public interface IUserRepository
    {
        User GetUserByName(string name);
    }
}
