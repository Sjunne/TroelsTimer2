using SimpleLogn.Models;

namespace SimpleLogn.Data
{
    public interface IUserService
    {
        User ValidateUser(string userName, string password);
    }
}