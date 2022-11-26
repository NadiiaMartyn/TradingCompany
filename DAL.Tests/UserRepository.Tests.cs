using DTO;
using Xunit;

namespace DAL.Tests
{
   public class UserRepositoryTests : RepositoryTestsBase
   {
       [Fact]
       public void GetId_Test()
       {
           //Arrange
           UserRepository userRepository = new UserRepository(_connectionString);
           UserDTO expected = new UserDTO()
           {
               Id = 1,
               Login = "mark2002007",
               Password = "1111",
               DispName = "MarKson"
           };
           //Act
           UserDTO actual = userRepository.Get(expected.Id);
           //Assert
           Assert.Equal(actual.Login, expected.Login);
           Assert.Equal(actual.Password, expected.Password);
           Assert.Equal(actual.DispName, expected.DispName);
       }
       [Fact]
       public void GetLogin_Test()
       {
           //Arrange
           UserRepository userRepository = new UserRepository(_connectionString);
           UserDTO expected = new UserDTO()
           {
               Login = "mark2002007",
               Password = "1111",
               DispName = "MarKson"
           };
           //Act
           UserDTO actual = userRepository.Get(expected.Login);
           //Assert
           Assert.Equal(actual.Login, expected.Login);
           Assert.Equal(actual.Password, expected.Password);
           Assert.Equal(actual.DispName, expected.DispName);
       }
       [Fact]
       public void UpdateDispName_Test()
       {
           //Arrange
           UserRepository userRepository = new UserRepository(_connectionString);
           UserDTO expected = new UserDTO
           {
               Login = "mark2002007",
               Password = "1111",
               DispName = "markson"
           };
           //Act
           bool isTrue = userRepository.UpdateDispName(expected.Login, expected.DispName);
           UserDTO actual = userRepository.Get(1);
           //Assert
           Assert.True(isTrue);
           Assert.Equal(actual.Login,expected.Login);
           Assert.Equal(actual.Password, expected.Password);
           Assert.Equal(actual.DispName, expected.DispName);
       }
       [Fact]
       public void UpdatePassword_Test()
       {
           //Arrange
           UserRepository userRepository = new UserRepository(_connectionString);
           UserDTO expected = new UserDTO
           {
               Login = "mark2002007",
               Password = "1234",
               DispName = "MarKson"
           };
           //Act
           bool isTrue = userRepository.UpdatePassword(expected.Login, expected.Password);
           UserDTO actual = userRepository.Get(1);
           //Assert
           Assert.True(isTrue);
           Assert.Equal(actual.Login,expected.Login);
           Assert.Equal(actual.Password, expected.Password);
           Assert.Equal(actual.DispName, expected.DispName);
       }
   }
}