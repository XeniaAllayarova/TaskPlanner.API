using Task_planner.API.Data;
using Task_planner.API.Models;
using Task_planner.API.Repositories.Interfaces;

namespace Task_planner.API.Repositories.Implementations
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _dbContext;

        public UserRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public User GetUserByName(string name)
        {
            return _dbContext.Users.FirstOrDefault(user => user.Name == name);
        }
    }
}
