using DTO;

namespace DAL
{
    public interface IUserRepository
    {
        void Create(UserDTO newUser);
        void UpdateDispName(string login, string newDispName);
        void UpdatePassword(string login, string newPassword);
        UserDTO Get(string login);
        UserDTO Get(int id);
    }
}