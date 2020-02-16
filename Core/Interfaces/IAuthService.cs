using Core.Entities;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IAuthService
    {
        Task<User> Register(User user, string password);
        void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt);
        Task<User> Login(string username, string password);
        bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt);
        Task<bool> UserExists(string username);
    }
}
