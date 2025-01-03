using Wordle.API.Models;

namespace Wordle.API.Abstractions;

public interface IUsersRepository
{
    Task<IEnumerable<User>> GetUsersAsync();
    Task<User> GetUserByUserIdAsync(Guid id);
    Task<User> GetUserByUsernameAsync(string username);
    
}