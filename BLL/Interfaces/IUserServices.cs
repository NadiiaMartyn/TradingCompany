using DAL;
using DTO;

namespace BLL
{
    public interface IUserServices
    {
        IUserRepository _userRepository { get; set; }
        void Add(UserDTO user);
        bool CheckPassword(string login, string password);
        UserDTO Get(string login);
        UserDTO Get(int id);
        void UpdateDispName(string login, string newDispName);
        void UpdatePassword(string login, string newPassword);
    }
}