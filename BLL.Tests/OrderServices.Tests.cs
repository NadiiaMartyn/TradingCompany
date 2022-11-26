using Autofac.Extras.Moq;
using DAL;
using DTO;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BLL.Tests
{
    public class OrderServicesTests
    {
        [Fact]
        public void GetInt_Valid()
        {
            using (var mock = AutoMock.GetLoose())
            {
                int userId = 1;
                int productId = 1;

                mock.Mock<IOrderRepository>()
                    .Setup(x => x.CreateOrder(userId, productId));

                var service = mock.Create<OrderServices>();
                service.PlaceOrder(userId, productId);

                mock.Mock<IOrderRepository>().
                    Verify(x => x.CreateOrder(userId, productId), Times.Exactly(1));
            }
        }

        [Fact]
        public void GetOrder_Valid()
        {
            using (var mock = AutoMock.GetLoose())
            {
                int orderId = 1;

                mock.Mock<IOrderRepository>()
                    .Setup(x => x.Get(orderId))
                    .Returns(GetSampleOrders()[0]);

                var service = mock.Create<OrderServices>();
                var expected = GetSampleOrders()[0];
                var actual = service.GetOrder(orderId);

                Assert.True(actual != null);
                Assert.Equal(expected.Id, actual.Id);
                Assert.Equal(expected.UserId, actual.UserId);
                Assert.Equal(expected.ProductName, actual.ProductName);
                Assert.Equal(expected.ProductId, actual.ProductId);
            }
        }

        [Fact]
        public void GetOrderHistory_Valid()
        {
            using (var mock = AutoMock.GetLoose())
            {
                int userId = 1;

                mock.Mock<IOrderRepository>()
                    .Setup(x => x.GetOrderHistory(userId))
                    .Returns(GetSampleOrders());

                var service = mock.Create<OrderServices>();
                var expected = GetSampleOrders();
                var actual = service.GetOrderHistory(userId);

                Assert.True(actual != null);
                Assert.Equal(actual.Count, expected.Count);
                for (int i = 0; i < expected.Count; i++)
                {
                    Assert.Equal(expected[i].Id, actual[i].Id);
                    Assert.Equal(expected[i].UserId, actual[i].UserId);
                    Assert.Equal(expected[i].ProductName, actual[i].ProductName);
                    Assert.Equal(expected[i].ProductId, actual[i].ProductId);
                }
            }
        }

        [Fact]
        public void UserOrderCheck_Valid()
        {
            using (var mock = AutoMock.GetLoose())
            {
                int userId = 1;
                int orderId = 1;

                mock.Mock<IOrderRepository>()
                    .Setup(x => x.Get(orderId))
                    .Returns(GetSampleOrders()[0]);

                var service = mock.Create<OrderServices>();
                Assert.True(service.UserOrderCheck(userId, orderId));
            }
        }

        public List<OrderDTO> GetSampleOrders()
        {
            return new List<OrderDTO>()
            {
                new OrderDTO()
                {
                    Id = 1,
                    UserId = 1,
                    ProductId = 1,
                    ProductName = "Name1"
                },
                new OrderDTO()
                {
                    Id = 2,
                    UserId = 1,
                    ProductId = 2,
                    ProductName = "Name2"
                }

            };
        }
    }
}
