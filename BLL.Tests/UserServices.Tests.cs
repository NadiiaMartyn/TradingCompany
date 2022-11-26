using Autofac.Extras.Moq;
using DAL;
using DTO;
using Moq;
using Tools;
using Xunit;

namespace BLL.Tests
{
    public class UserServicesTests
    {
        [Fact]
        public void GetInt_Valid()
        {
            using (var mock = AutoMock.GetLoose())
            {
                mock.Mock<IUserRepository>()
                    .Setup(x => x.Get(1))
                    .Returns(GetSampleUser());
                var service = mock.Create<UserServices>();

                var expected = GetSampleUser();
                var actual = service.Get(1);

                Assert.True(actual != null);
                Assert.Equal(expected.Id, actual.Id);
                Assert.Equal(expected.Login, actual.Login);
                Assert.Equal(expected.Password, actual.Password);
                Assert.Equal(expected.DispName, actual.DispName);
            }
        }

        [Fact]
        public void GetString_Valid()
        {
            using (var mock = AutoMock.GetLoose())
            {
                mock.Mock<IUserRepository>()
                    .Setup(x => x.Get("nadia07"))
                    .Returns(GetSampleUser());
                var service = mock.Create<UserServices>();

                var expected = GetSampleUser();
                var actual = service.Get("nadia07");

                Assert.True(actual != null);
                Assert.Equal(expected.Id, actual.Id);
                Assert.Equal(expected.Login, actual.Login);
                Assert.Equal(expected.Password, actual.Password);
                Assert.Equal(expected.DispName, actual.DispName);
            }
        }

        [Fact]
        public void UpdateDisplayName_Valid()
        {
            using (var mock = AutoMock.GetLoose())
            {
                mock.Mock<IUserRepository>()
                    .Setup(x => x.UpdateDispName("nadia07", "nadia"));

                var service = mock.Create<UserServices>();
                service.UpdateDispName("nadia07", "nadia");

                mock.Mock<IUserRepository>()
                    .Verify(x => x.UpdateDispName("nadia07", "nadia"), Times.Exactly(1));
            }
        }

        [Fact]
        public void UpdatePassword_Valid()
        {
            using (var mock = AutoMock.GetLoose())
            {
                string login = "nadia07";
                string newPassword = "1234";
                var passwordHash = PasswordHasher.Hash(newPassword);

                mock.Mock<IUserRepository>()
                    .Setup(x => x.UpdatePassword(login, passwordHash));

                var service = mock.Create<UserServices>();
                service.UpdatePassword(login, newPassword);
                mock.Mock<IUserRepository>()
                    .Verify(x => x.UpdatePassword(login, passwordHash), Times.Never());
                mock.Mock<IUserRepository>()
                    .Verify(x => x.UpdatePassword(login, newPassword), Times.Never());
            }
        }

        private UserDTO GetSampleUser() =>
            new UserDTO
            {
                Id = 1,
                Login = "nadia07",
                Password = "1111",
                DispName = "nadia"
            };
    }
}