using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class UserRepository : BaseRepository, IUserRepository
    {
        public UserRepository() : base(Helper.CnnVal())
        {
        }
        public void Create(UserDTO newUser)
        {
            using (SqlConnection connection = new(connectionString))
            {
                connection.Open();
                SqlCommand command = new(@"spAddUser", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@login", newUser.Login));
                command.Parameters.Add(new SqlParameter("@password", newUser.Password));
                command.Parameters.Add(new SqlParameter("@disp_name", newUser.DispName));
                command.ExecuteNonQuery();
            }
        }
        public List<UserDTO> GetAll()
        {
            using (SqlConnection connection = new(connectionString))
            {
                connection.Open();
                SqlCommand command = new("SELECT * FROM users", connection);
                List<UserDTO> users = new List<UserDTO>();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                        users.Add(new UserDTO()
                        {
                            Id = (int)reader["id"],
                            Login = (string)reader["login"],
                            Password = (string)reader["password"],
                            DispName = (string)reader["disp_name"],
                            InsertTime = (DateTime)reader["insert_time"],
                            UpdateTime = (DateTime)reader["update_time"]
                        });
                }
                return users;
            }
        }
        public void DeleteAll()
        {
            using (SqlConnection connection = new(connectionString))
            {
                connection.Open();
                SqlCommand command = new(@"DELETE FROM users;", connection);
                command.ExecuteNonQuery();
            }
        }
        public UserDTO Get(string login)
        {
            using (SqlConnection connection = new(connectionString))
            {
                connection.Open();
                SqlCommand command = new("spGetUserByLogin", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@login", login));
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                        return new UserDTO()
                        {
                            Id = (int)reader["id"],
                            Login = (string)reader["login"],
                            Password = (string)reader["password"],
                            DispName = (string)reader["disp_name"],
                            InsertTime = (DateTime)reader["insert_time"],
                            UpdateTime = (DateTime)reader["update_time"]
                        };
                }
                return null;
            }
        }
        public UserDTO Get(int id)
        {
            using (SqlConnection connection = new(connectionString))
            {
                connection.Open();
                SqlCommand command = new("spGetUserByID", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@id", id));
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                        return new UserDTO()
                        {
                            Id = (int)reader["id"],
                            Login = (string)reader["login"],
                            Password = (string)reader["password"],
                            DispName = (string)reader["disp_name"],
                            InsertTime = (DateTime)reader["insert_time"],
                            UpdateTime = (DateTime)reader["update_time"]
                        };
                }
                return null;
            }
        }
        public void UpdateDispName(string login, string newDispName)
        {
            using (SqlConnection connection = new(connectionString))
            {
                connection.Open();
                SqlCommand command = new(@"spUpdateDisplayName", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@new_disp_name", newDispName));
                command.Parameters.Add(new SqlParameter("@login", login));
                command.ExecuteNonQuery();
            }
        }
        public void UpdatePassword(string login, string newPassword)
        {
            using (SqlConnection connection = new(connectionString))
            {
                connection.Open();
                SqlCommand command = new(@"spUpdatePassword", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@new_password", newPassword));
                command.Parameters.Add(new SqlParameter("@login", login));
                command.ExecuteNonQuery();
            }
        }
    }
}