using Forsøg2.Models;

namespace Forsøg2.Data
{
    public interface IUserService
    {
        User ValidateUser(string userName, string password);
    }
}