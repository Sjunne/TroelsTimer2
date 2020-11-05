using System.Threading.Tasks;
using User = Assignment3WebAPI.UserService.User;

namespace Assignment3WebAPI.UserService
{
    public interface IUserService
    {
        Task<User> ValidateUser(string userName, string password);
    }
}