using ConfArch.Data.Models;

namespace ConfArch.Data.Repositories
{
    public interface IUserRepository
    {
        User GetByGoogleId(string googleId);
        User GetByUsernameAndPassword(string username, string password);
    }
}