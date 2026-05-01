using TaskPlanner.API.Repositories.Interfaces;
using TaskPlanner.API.Data;
using TaskPlanner.API.Models;

namespace TaskPlanner.API.Repositories.Implementations
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
