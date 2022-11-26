using DAL;
using DTO;
using Tools;

namespace BLL
{
    public class UserServices : IUserServices
    {
        public IUserRepository _userRepository { get; set; }
        public UserServices(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public void Add(UserDTO newUser) => _userRepository.Create(newUser);
        public bool CheckPassword(string login, string password) => PasswordHasher.Check(_userRepository.Get(login)?.Password, password);
        public UserDTO Get(string login) => _userRepository.Get(login);
        public UserDTO Get(int id) => _userRepository.Get(id);
        public void UpdateDispName(string login, string newDispName) => _userRepository.UpdateDispName(login, newDispName);
        public void UpdatePassword(string login, string newPassword) => _userRepository.UpdatePassword(login, PasswordHasher.Hash(newPassword));
    }
}